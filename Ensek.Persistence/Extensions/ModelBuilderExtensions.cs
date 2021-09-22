using Ensek.Domain.Models;
using ExcelDataReader;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Ensek.Persistence.Extensions
{
    internal static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            using (var fileStream = File.OpenRead("..\\Ensek.Persistence\\SeedData\\Accounts.xlsx"))
            using (var excelReader = ExcelReaderFactory.CreateReader(fileStream))
            {
                var dataSet = excelReader.AsDataSet(new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });
                var dataTable = dataSet.Tables[0];

                var accounts = new List<Account>();

                foreach (DataRow row in dataTable.Rows)
                {
                    var account = new Account
                    {
                        Id = Convert.ToInt32(row[0]),
                        FirstName = Convert.ToString(row[1]),
                        LastName = Convert.ToString(row[2])
                    };
                    accounts.Add(account);
                }

                modelBuilder.Entity<Account>().HasData(accounts);
            }
        }
    }
}