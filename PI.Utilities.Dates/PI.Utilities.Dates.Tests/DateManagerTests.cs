using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PI.Utilities.Dates.Models;
using PI.Utilities.Dates;
using PI.Utilities.Dates.Interfaces;

namespace PI.Utilities.Dates.Tests
{

    [TestClass]
    public class DateManagerTests
    {

        [TestMethod]
        public void BaseStartEndDatePair_Year_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = DateTime.UtcNow;

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.Year);

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(1, pair.StartDate.Month);
            Assert.AreEqual(1, pair.StartDate.Day);
            Assert.AreEqual(date.Year + 1, pair.EndDate.Year);
            Assert.AreEqual(1, pair.EndDate.Month);
            Assert.AreEqual(1, pair.EndDate.Day);
        }

        [TestMethod]
        public void BaseStartEndDatePair_Year_SetDate_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = new DateTime(2015, 3, 3, 15, 47, 20);

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.Year, date);

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(1, pair.StartDate.Month);
            Assert.AreEqual(1, pair.StartDate.Day);
            Assert.AreEqual(date.Year + 1, pair.EndDate.Year);
            Assert.AreEqual(1, pair.EndDate.Month);
            Assert.AreEqual(1, pair.EndDate.Day);
        }

        [TestMethod]
        public void BaseStartEndDatePair_Month_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = DateTime.UtcNow;

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.Month);

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(1, pair.StartDate.Day);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month + 1, pair.EndDate.Month);
            Assert.AreEqual(1, pair.EndDate.Day);
        }

        [TestMethod]
        public void BaseStartEndDatePair_Month_SetDate_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = new DateTime(2015, 3, 3, 15, 47, 20);

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.Month, date);

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(1, pair.StartDate.Day);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month + 1, pair.EndDate.Month);
            Assert.AreEqual(1, pair.EndDate.Day);
        }

        [TestMethod]
        public void BaseStartEndDatePair_Day_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = DateTime.UtcNow;

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.Day);

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(0, pair.StartDate.Hour);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day + 1, pair.EndDate.Day);
            Assert.AreEqual(0, pair.EndDate.Hour);
        }

        [TestMethod]
        public void BaseStartEndDatePair_Day_SetDate_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = new DateTime(2015, 3, 3, 15, 47, 20);

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.Day, date);

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(0, pair.StartDate.Hour);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day + 1, pair.EndDate.Day);
            Assert.AreEqual(0, pair.EndDate.Hour);
        }

        [TestMethod]
        public void BaseStartEndDatePair_Hour_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = DateTime.UtcNow;

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.Hour);

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(0, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            Assert.AreEqual(date.Hour + 1, pair.EndDate.Hour);
            Assert.AreEqual(0, pair.EndDate.Minute);
        }

        [TestMethod]
        public void BaseStartEndDatePair_Hour_SetDate_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = new DateTime(2015, 3, 3, 15, 47, 20);

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.Hour, date);

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(0, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            Assert.AreEqual(date.Hour + 1, pair.EndDate.Hour);
            Assert.AreEqual(0, pair.EndDate.Minute);
        }

        [TestMethod]
        public void BaseStartEndDatePair_HalfHour_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = DateTime.UtcNow;

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.HalfHour);

            //expect either 0 or 30 depending if it is past or on the 30 min mark
            int min = (date.Minute >= 30) ? 30 : 0;

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(min, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            var hour = (min > 0) ? date.Hour + 1 : date.Hour;
            Assert.AreEqual(hour, pair.EndDate.Hour);
            Assert.AreEqual(pair.StartDate.AddMinutes(30).Minute, pair.EndDate.Minute);
        }

        [TestMethod]
        public void BaseStartEndDatePair_HalfHour_SetDate_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = new DateTime(2015, 3, 3, 15, 12, 20);

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.HalfHour, date);

            //expect min to be 0 as it is set to 12
            int min = 0;

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(min, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            Assert.AreEqual(date.Hour, pair.EndDate.Hour);
            Assert.AreEqual(pair.StartDate.AddMinutes(30).Minute, pair.EndDate.Minute);
        }

        [TestMethod]
        public void BaseStartEndDatePair_HalfHour_SetDate1_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = new DateTime(2015, 3, 3, 15, 30, 20);

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.HalfHour, date);

            //expect min to be 30 as it is set to 30
            int min = 30;

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(min, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            Assert.AreEqual(date.Hour + 1, pair.EndDate.Hour); //should be into the next hour
            Assert.AreEqual(pair.StartDate.AddMinutes(30).Minute, pair.EndDate.Minute);
        }

        [TestMethod]
        public void BaseStartEndDatePair_HalfHour_SetDate2_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = new DateTime(2015, 3, 3, 15, 47, 20);

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.HalfHour, date);

            //expect min to be 30 as it is set to 47
            int min = 30;

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(min, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            Assert.AreEqual(date.Hour + 1, pair.EndDate.Hour); //should be into the next hour
            Assert.AreEqual(pair.StartDate.AddMinutes(30).Minute, pair.EndDate.Minute);
        }


        [TestMethod]
        public void BaseStartEndDatePair_FifteenMinutes_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = DateTime.UtcNow;

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.FifteenMinutes);

            //expect either 0, 15, 30 or 45 depending where the current date rests
            var min = (date.Minute >= 45) ? 45 : (date.Minute >= 30) ? 30 : (date.Minute >= 15) ? 15 : 0;

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(min, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            var hour = (min >= 45) ? date.Hour + 1 : date.Hour;
            Assert.AreEqual(hour, pair.EndDate.Hour);
            Assert.AreEqual(pair.StartDate.AddMinutes(15).Minute, pair.EndDate.Minute);
        }

        [TestMethod]
        public void BaseStartEndDatePair_FifteenMinutes_SetDate_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = new DateTime(2015, 3, 3, 15, 12, 20);

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.FifteenMinutes, date);

            //expect 0 as min set to 12
            var min = 0;

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(min, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            Assert.AreEqual(date.Hour, pair.EndDate.Hour);
            Assert.AreEqual(pair.StartDate.AddMinutes(15).Minute, pair.EndDate.Minute);
        }

        [TestMethod]
        public void BaseStartEndDatePair_FifteenMinutes_SetDate1_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = new DateTime(2015, 3, 3, 15, 15, 20);

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.FifteenMinutes, date);

            //expect 15 as min set to 15
            var min = 15;

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(min, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            Assert.AreEqual(date.Hour, pair.EndDate.Hour);
            Assert.AreEqual(pair.StartDate.AddMinutes(15).Minute, pair.EndDate.Minute);
        }

        [TestMethod]
        public void BaseStartEndDatePair_FifteenMinutes_SetDate2_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = new DateTime(2015, 3, 3, 15, 27, 20);

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.FifteenMinutes, date);

            //expect 15 as min set to 27
            var min = 15;

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(min, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            Assert.AreEqual(date.Hour, pair.EndDate.Hour);
            Assert.AreEqual(pair.StartDate.AddMinutes(15).Minute, pair.EndDate.Minute);
        }

        [TestMethod]
        public void BaseStartEndDatePair_FifteenMinutes_SetDate3_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = new DateTime(2015, 3, 3, 15, 30, 20);

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.FifteenMinutes, date);

            //expect 30 as min set to 30
            var min = 30;

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(min, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            Assert.AreEqual(date.Hour, pair.EndDate.Hour);
            Assert.AreEqual(pair.StartDate.AddMinutes(15).Minute, pair.EndDate.Minute);
        }

        [TestMethod]
        public void BaseStartEndDatePair_FifteenMinutes_SetDate4_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = new DateTime(2015, 3, 3, 15, 42, 20);

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.FifteenMinutes, date);

            //expect 30 as min set to 42
            var min = 30;

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(min, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            Assert.AreEqual(date.Hour, pair.EndDate.Hour);
            Assert.AreEqual(pair.StartDate.AddMinutes(15).Minute, pair.EndDate.Minute);
        }

        [TestMethod]
        public void BaseStartEndDatePair_FifteenMinutes_SetDate5_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = new DateTime(2015, 3, 3, 15, 45, 20);

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.FifteenMinutes, date);

            //expect 45 as min set to 45
            var min = 45;

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(min, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            Assert.AreEqual(date.Hour + 1, pair.EndDate.Hour); //should be into the next hour
            Assert.AreEqual(pair.StartDate.AddMinutes(15).Minute, pair.EndDate.Minute);
        }

        [TestMethod]
        public void BaseStartEndDatePair_FifteenMinutes_SetDate6_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();
            //set the date
            DateTime date = new DateTime(2015, 3, 3, 15, 52, 20);

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.FifteenMinutes, date);

            //expect 45 as min set to 52
            var min = 45;

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(min, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            Assert.AreEqual(date.Hour + 1, pair.EndDate.Hour); //should be into the next hour
            Assert.AreEqual(pair.StartDate.AddMinutes(15).Minute, pair.EndDate.Minute);
        }

        [TestMethod]
        public void BaseStartEndDatePair_TenMinutes_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();

            //set the date
            DateTime date = DateTime.UtcNow;

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.TenMinutes);

            //expect either 0, 10, 20, etc depending where the current date rests
            var min = (date.Minute >= 50) ? 50 : (date.Minute >= 40) ? 40 : (date.Minute >= 30) ? 30 : (date.Minute >= 20) ? 20 : (date.Minute >= 10) ? 10 : 0;

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(min, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            var hour = (min > 50) ? date.Hour + 1 : date.Hour;
            Assert.AreEqual(hour, pair.EndDate.Hour);
            Assert.AreEqual(pair.StartDate.AddMinutes(10).Minute, pair.EndDate.Minute);
        }

        [TestMethod]
        public void BaseStartEndDatePair_FiveMinutes_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();

            //set the date
            DateTime date = DateTime.UtcNow;

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.FiveMinutes);

            //expect either 0, 5, 10, etc depending where the current date rests
            var min = (date.Minute >= 55) ? 55 : (date.Minute >= 50) ? 50 : (date.Minute >= 45) ? 45 : (date.Minute >= 40) ? 40 : (date.Minute >= 35) ? 35 : (date.Minute >= 30) ? 30 : (date.Minute >= 25) ? 25 : (date.Minute >= 20) ? 20 : (date.Minute >= 15) ? 15 : (date.Minute >= 10) ? 10 : (date.Minute >= 5) ? 5 : 0;

            //check results
            Assert.AreEqual(date.Year, pair.StartDate.Year);
            Assert.AreEqual(date.Month, pair.StartDate.Month);
            Assert.AreEqual(date.Day, pair.StartDate.Day);
            Assert.AreEqual(date.Hour, pair.StartDate.Hour);
            Assert.AreEqual(min, pair.StartDate.Minute);
            Assert.AreEqual(date.Year, pair.EndDate.Year);
            Assert.AreEqual(date.Month, pair.EndDate.Month);
            Assert.AreEqual(date.Day, pair.EndDate.Day);
            var hour = (min > 55) ? date.Hour + 1 : date.Hour;
            Assert.AreEqual(hour, pair.EndDate.Hour);
            Assert.AreEqual(pair.StartDate.AddMinutes(5).Minute, pair.EndDate.Minute);

        }


        [TestMethod]
        public void BaseStartEndDatePair_Timespan_Pass()
        {
            //create pair
            StartEndDatePair pair = new StartEndDatePair();

            DateTime blankStart = new DateTime(2000, 1, 1);
            DateTime blankEnd = new DateTime(2100, 1, 1);

            //call method
            DateManager.BaseStartEndDatePair(pair, DateRange.Timespan);

            //check results
            Assert.AreEqual(blankStart.Year, pair.StartDate.Year);
            Assert.AreEqual(blankStart.Month, pair.StartDate.Month);
            Assert.AreEqual(blankStart.Day, pair.StartDate.Day);
            Assert.AreEqual(blankStart.Hour, pair.StartDate.Hour);
            Assert.AreEqual(blankStart.Minute, pair.StartDate.Minute);
            Assert.AreEqual(blankEnd.Year, pair.EndDate.Year);
            Assert.AreEqual(blankEnd.Month, pair.EndDate.Month);
            Assert.AreEqual(blankEnd.Day, pair.EndDate.Day);
            Assert.AreEqual(blankEnd.Hour, pair.EndDate.Hour);
            Assert.AreEqual(blankEnd.Minute, pair.EndDate.Minute);
        }


        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Year_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.Year);

            //check results
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Month_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.Month);

            //check results
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Day_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.Day);

            //check results
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Hour_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.Hour);

            //check results
            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void GetUseBaseFromDateRangeArray_HalfHour_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.HalfHour);

            //check results
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_FifteenMinutes_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.FifteenMinutes);

            //check results
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_TenMinutes_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.TenMinutes);

            //check results
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_FiveMinutes_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.FiveMinutes);

            //check results
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Timespan_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.Timespan);

            //check results
            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Year2_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.Year, new string[] { "year" });

            //check results
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Year3_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.Year, new string[] { "blah" });

            //check results
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Month2_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.Month, new string[] { "month" });

            //check results
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Month3_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.Month, new string[] { "blah" });

            //check results
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Day2_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.Day, new string[] { "day" });

            //check results
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Day3_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.Day, new string[] { "blah" });

            //check results
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Hour2_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.Hour, new string[] { "hour" });

            //check results
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Hour3_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.Hour, new string[] { "blah" });

            //check results
            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void GetUseBaseFromDateRangeArray_HalfHour2_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.HalfHour, new string[] { "halfhour" });

            //check results
            Assert.AreEqual(true, result);
        }


        [TestMethod]
        public void GetUseBaseFromDateRangeArray_HalfHour3_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.HalfHour, new string[] { "blah" });

            //check results
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_FifteenMinutes2_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.FifteenMinutes, new string[] { "fifteenminutes" });

            //check results
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_FifteenMinutes3_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.FifteenMinutes, new string[] { "blah" });

            //check results
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_TenMinutes2_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.TenMinutes, new string[] { "tenminutes" });

            //check results
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_TenMinutes3_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.TenMinutes, new string[] { "blah" });

            //check results
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_FiveMinutes2_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.FiveMinutes, new string[] { "FiveMinutes" });

            //check results
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_FiveMinutes3_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.FiveMinutes, new string[] { "blah" });

            //check results
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Timespan2_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.Timespan, new string[] { "timeSpan" });

            //check results
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Timespan3_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray(DateRange.Timespan, new string[] { "blah" });

            //check results
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Blah_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray("blah");

            //check results
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Blah2_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray("blah", new string[] { "blah" });

            //check results
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetUseBaseFromDateRangeArray_Blah3_Pass()
        {

            //call method
            var result = DateManager.GetUseBaseFromDateRangeArray("blah", new string[] { "notblah" });

            //check results
            Assert.AreEqual(false, result);
        }
    }
}
