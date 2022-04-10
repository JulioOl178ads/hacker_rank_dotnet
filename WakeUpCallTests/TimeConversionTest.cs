using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class TimeConversionTest
    {
        [TestMethod()]
        public void TimePMTest()
        {
            string input = "11:00:32PM";
            string output = Result.TimeConversion(input);
            string desiredOutput = "23:00:32";
            Assert.AreEqual(desiredOutput, output);
        }

        [TestMethod()]
        public void TimePMAfternoon()
        {
            string input = "06:00:30PM";
            string output = Result.TimeConversion(input);
            string desiredOutput = "18:00:30";
            Assert.AreEqual(desiredOutput, output);
        }

        [TestMethod()]
        public void TimeAMTest()
        {
            string input = "11:00:32PM";
            string output = Result.TimeConversion(input);
            string desiredOutput = "23:00:32";
            Assert.AreEqual(desiredOutput, output);
        }

        [TestMethod()]
        public void TimeAMTestNight()
        {
            string input = "00:00:32AM";
            string output = Result.TimeConversion(input);
            string desiredOutput = "00:00:32";
            Assert.AreEqual(desiredOutput, output);
        }

        [TestMethod()]
        public void TimeAMTestNoon()
        {
            string input = "12:00:00AM";
            string output = Result.TimeConversion(input);
            string desiredOutput = "00:00:00";
            Assert.AreEqual(desiredOutput, output);
        }

        [TestMethod()]
        public void TimeIsNewDay()
        {
            string input = "12:00:00AM";
            string output = Result.TimeConversion(input);
            string desiredOutput = "00:00:00";
            Assert.AreEqual(desiredOutput, output);
        }

        [TestMethod()]
        public void StartNewDay()
        {
            string input = "00:00:10AM";
            string output = Result.TimeConversion(input);
            string desiredOutput = "00:00:10";
            Assert.AreEqual(desiredOutput, output);
        }

        [TestMethod()]
        public void AmHigherThanTwelve()
        {
            string input = "12:40:22AM";
            string output = Result.TimeConversion(input);
            string desiredOutput = "00:40:22";
            Assert.AreEqual(desiredOutput, output);
        }

        [TestMethod()]
        public void PmHigherThanTwelve()
        {
            string input = "12:45:54PM";
            string output = Result.TimeConversion(input);
            string desiredOutput = "12:45:54";
            Assert.AreEqual(desiredOutput, output);
        }

    }
}