using Ensek.Application.Validators.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ensek.Domain.Models;
using System.Collections.Generic;
using System.Text;
using System;
using Ensek.Application.Validators;

namespace Ensek.Tests.Application.Validators
{
    [TestClass]
    public class MeterReadingValidatorTest
    {
        private IValidateMeterReading _meterReadingValidator;

        public MeterReadingValidatorTest()
        {
            _meterReadingValidator = new MeterReadingValidator();
        }

        [TestMethod]
        public void IsValid_ValidData_ReturnTrue()
        {
            var isValid = _meterReadingValidator.IsValid(new MeterReading()
            {
                Date = DateTime.UtcNow,
                Value = 12345
            });
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void IsValid_ValueTooLong_ReturnFalse()
        {
            var isValid = _meterReadingValidator.IsValid(new MeterReading()
            {
                Date = DateTime.UtcNow,
                Value = 123456
            });
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsValid_ValueNegative_ReturnFalse()
        {
            var isValid = _meterReadingValidator.IsValid(new MeterReading()
            {
                Date = DateTime.UtcNow,
                Value = -123
            });
            Assert.IsFalse(isValid);
        }
    }
}