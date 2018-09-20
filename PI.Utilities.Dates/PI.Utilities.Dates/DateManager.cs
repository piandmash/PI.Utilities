using System;
using System.Globalization;
using PI.Utilities.Dates.Interfaces;
using PI.Utilities;

namespace PI.Utilities.Dates
{
    
    public static class DateManager
    {
        
        /// <summary>
        /// Sets the date pair to the start and end dates based on the type of date range sent, defaults the date to the UTC Now DateTime
        /// </summary>
        /// <param name="datePair">The date pair to set</param>
        /// <param name="dateRange">The DateRange to use to get the start date for</param>
        public static void BaseStartEndDatePair(IStartEndDatePair datePair, string dateRange)
        {
            BaseStartEndDatePair(datePair, dateRange, DateTime.UtcNow);
        }

        /// <summary>
        /// Sets the date pair to the start and end dates based on the type of date range sent
        /// </summary>
        /// <param name="datePair">The date pair to set</param>
        /// <param name="dateRange">The DateRange to use to get the start date for</param>
        /// <param name="date">The date to to get the start from</param>
        public static void BaseStartEndDatePair(IStartEndDatePair datePair, string dateRange, DateTime date, CultureInfo culture = null)
        {
            switch (dateRange)
            {
                case DateRange.Year:
                    datePair.StartDate = new DateTime(date.Year, 1, 1);
                    datePair.EndDate = datePair.StartDate.AddYears(1);
                    break;
                case DateRange.Month:
                    datePair.StartDate = new DateTime(date.Year, date.Month, 1);
                    datePair.EndDate = datePair.StartDate.AddMonths(1);
                    break;
                case DateRange.Week:
                    if(culture == null) culture = System.Threading.Thread.CurrentThread.CurrentCulture;
                    datePair.StartDate = new DateTime(date.Year, date.Month, date.Day);
                    var diff = datePair.StartDate.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
                        if (diff < 0)
                            diff += 7;
                    datePair.StartDate = datePair.StartDate.AddDays(-diff);
                    datePair.EndDate = datePair.StartDate.AddDays(6);
                    break;
                case DateRange.Day:
                    datePair.StartDate = new DateTime(date.Year, date.Month, date.Day);
                    datePair.EndDate = datePair.StartDate.AddDays(1);
                    break;
                case DateRange.Hour:
                    datePair.StartDate = new DateTime(date.Year, date.Month, date.Day, date.Hour, 0, 0);
                    datePair.EndDate = datePair.StartDate.AddHours(1);
                    break;
                case DateRange.HalfHour:
                    var halfHourMin = (date.Minute >= 30) ? 30 : 0;
                    datePair.StartDate = new DateTime(date.Year, date.Month, date.Day, date.Hour, halfHourMin, 0);
                    datePair.EndDate = datePair.StartDate.AddMinutes(30);
                    break;
                case DateRange.FifteenMinutes:
                    var fifteenMin = (date.Minute >= 45) ? 45 : (date.Minute >= 30) ? 30 : (date.Minute >= 15) ? 15 : 0;
                    datePair.StartDate = new DateTime(date.Year, date.Month, date.Day, date.Hour, fifteenMin, 0);
                    datePair.EndDate = datePair.StartDate.AddMinutes(15);
                    break;
                case DateRange.TenMinutes:
                    var tenMin = (date.Minute >= 50) ? 50 : (date.Minute >= 40) ? 40 : (date.Minute >= 30) ? 30 : (date.Minute >= 20) ? 20 : (date.Minute >= 10) ? 10 : 0;
                    datePair.StartDate = new DateTime(date.Year, date.Month, date.Day, date.Hour, tenMin, 0);
                    datePair.EndDate = datePair.StartDate.AddMinutes(10);
                    break;
                case DateRange.FiveMinutes:
                    var fiveMin = (date.Minute >= 55) ? 55 : (date.Minute >= 50) ? 50 : (date.Minute >= 45) ? 45 : (date.Minute >= 40) ? 40 : (date.Minute >= 35) ? 35 : (date.Minute >= 30) ? 30 : (date.Minute >= 25) ? 25 : (date.Minute >= 20) ? 20 : (date.Minute >= 15) ? 15 : (date.Minute >= 10) ? 10 : (date.Minute >= 5) ? 5 : 0;
                    datePair.StartDate = new DateTime(date.Year, date.Month, date.Day, date.Hour, fiveMin, 0);
                    datePair.EndDate = datePair.StartDate.AddMinutes(5);
                    //not available
                    break;
                case DateRange.Timespan:
                    //not available
                    break;
            }
        }

        /// <summary>
        /// Sets the date pair to the start and end dates based on the type of date range sent, defaults the date to the UTC Now DateTime
        /// </summary>
        /// <param name="datePair">The date pair to set</param>
        /// <param name="dateRange">The DateRange to use to get the start date for</param>
        /// <param name="secondsForTimeSpan">The number of seconds to add for the timespan version - defaults to 60</param>
        public static void SetStartEndDatePair(IStartEndDatePair datePair, string dateRange, int secondsForTimeSpan = 60)
        {
            SetStartEndDatePair(datePair, dateRange, DateTime.UtcNow, secondsForTimeSpan);
        }

        /// <summary>
        /// Sets the date pair to the start and end dates based on the type of date range sent
        /// </summary>
        /// <param name="datePair">The date pair to set</param>
        /// <param name="dateRange">The DateRange to use to get the start date for</param>
        /// <param name="date">The date to to get the start from</param>
        /// <param name="secondsForTimeSpan">The number of seconds to add for the timespan version - defaults to 60</param>
        public static void SetStartEndDatePair(IStartEndDatePair datePair, string dateRange, DateTime date, int secondsForTimeSpan = 60)
        {
            switch (dateRange)
            {
                case DateRange.Year:
                    datePair.StartDate = date;
                    datePair.EndDate = datePair.StartDate.AddYears(1);
                    break;
                case DateRange.Month:
                    datePair.StartDate = date;
                    datePair.EndDate = datePair.StartDate.AddMonths(1);
                    break;
                case DateRange.Week:
                    datePair.StartDate = date;
                    datePair.EndDate = datePair.StartDate.AddDays(7);
                    break;
                case DateRange.Day:
                    datePair.StartDate = date;
                    datePair.EndDate = datePair.StartDate.AddDays(1);
                    break;
                case DateRange.Hour:
                    datePair.StartDate = date;
                    datePair.EndDate = datePair.StartDate.AddHours(1);
                    break;
                case DateRange.HalfHour:
                    datePair.StartDate = date;
                    datePair.EndDate = datePair.StartDate.AddMinutes(30);
                    break;
                case DateRange.FifteenMinutes:
                    datePair.StartDate = date;
                    datePair.EndDate = datePair.StartDate.AddMinutes(15);
                    break;
                case DateRange.TenMinutes:
                    datePair.StartDate = date;
                    datePair.EndDate = datePair.StartDate.AddMinutes(10);
                    break;
                case DateRange.FiveMinutes:
                    datePair.StartDate = date;
                    datePair.EndDate = datePair.StartDate.AddMinutes(5);
                    break;
                case DateRange.Timespan:
                    datePair.StartDate = date;
                    datePair.EndDate = datePair.StartDate.AddSeconds(secondsForTimeSpan);
                    break;
            }
        }


        /// <summary>
        /// Gets the use base value based on the sent date range matching the date ranges for base array
        /// </summary>
        /// <param name="dateRange">The date range to set the default values on</param>
        /// <param name="dateRagesForBase">An array of strings to match to set the date range to a base date rather than from the current date, if null then Year, Month and Day are all set as base</param>
        /// <returns>A Bool to advise if to use the base date method</returns>
        public static bool GetUseBaseFromDateRangeArray(string dateRange, string[] dateRagesForBase = null)
        {
            bool useBase = false;
            if (dateRagesForBase == null)
            {
                if (String.Equals(dateRange, DateRange.Year, StringComparison.OrdinalIgnoreCase)
                    || String.Equals(dateRange, DateRange.Month, StringComparison.OrdinalIgnoreCase)
                    || String.Equals(dateRange, DateRange.Week, StringComparison.OrdinalIgnoreCase)
                    || String.Equals(dateRange, DateRange.Day, StringComparison.OrdinalIgnoreCase))
                {
                    useBase = true;
                }
            }
            else
            {
                foreach (string s in dateRagesForBase)
                {
                    if (String.Equals(s, dateRange, StringComparison.OrdinalIgnoreCase))
                    {
                        useBase = true;
                        break;
                    }
                }
            }
            return useBase;
        }

        /// <summary>
        /// Creates a random date between the sent date range
        /// </summary>
        /// <param name="startDate">The start date</param>
        /// <param name="endDate">The end date</param>
        /// <returns>The generated date</returns>
        public static DateTime RandomDate(DateTime startDate, DateTime endDate)
        {
            //get milliseconds between dates
            TimeSpan duration = endDate.Subtract(startDate);
            if (duration.Ticks <= 0) return startDate;
            //see if we can fit milliseconds to int
            bool usingMilliseconds = (duration.TotalMilliseconds < int.MaxValue + 0.5);
            bool usingSeconds = false;
            //if not then try seconds
            if (!usingMilliseconds) {
                usingSeconds = (duration.TotalSeconds < int.MaxValue + 0.5);
            }
            //create span
            int span = (usingMilliseconds) ? Convert.ToInt32(duration.TotalMilliseconds) : (usingSeconds) ? Convert.ToInt32(duration.TotalSeconds) : Convert.ToInt32(duration.TotalMinutes);
            //use crypto random for more randomness
            var rand = new CryptoRandom();
            var result = rand.Next(span);
            //add milliseconds and return
            return (usingMilliseconds) ? startDate.AddMilliseconds(result) : (usingSeconds) ? startDate.AddSeconds(result) : startDate.AddMinutes(result); 
        }
    }
    
}
