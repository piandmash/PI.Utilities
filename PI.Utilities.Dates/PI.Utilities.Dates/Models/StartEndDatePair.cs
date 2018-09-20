using System;
using System.Globalization;
using PI.Utilities.Dates.Interfaces;

namespace PI.Utilities.Dates.Models
{
    
    public class StartEndDatePair : IStartEndDatePair
    {
        /// <summary>
        /// The date the counter started from
        /// </summary>
        public DateTime StartDate { get; set; } = new DateTime(2000, 1, 1);

        /// <summary>
        /// The date the counter ended at
        /// </summary>
        public DateTime EndDate { get; set; } = new DateTime(2100, 1, 1);

        /// <summary>
        /// Basic constructor
        /// </summary>
        public StartEndDatePair() { }

        /// <summary>
        /// DateRange constructor
        /// </summary>
        /// <param name="dateRange">The date range to set the default values on</param>
        /// <param name="dateRagesForBase">An array of strings to match to set the date range to a base date rather than from the current date, if null then Year, Month and Day are all set as base</param>
        /// <param name="date">The date to to get the start from</param>
        /// <param name="culture">Optional culture to set the date ranges from</param>
        public StartEndDatePair(string dateRange, DateTime date, string[] dateRagesForBase = null, CultureInfo culture = null)
        {
            bool useBase = DateManager.GetUseBaseFromDateRangeArray(dateRange, dateRagesForBase);
            CallDateManager(dateRange, useBase, date, culture);
        }

        /// <summary>
        /// DateRange constructor
        /// </summary>
        /// <param name="dateRange">The date range to set the default values on</param>
        /// <param name="dateRagesForBase">An array of strings to match to set the date range to a base date rather than from the current date, if null then Year, Month and Day are all set as base</param>
        /// <param name="culture">Optional culture to set the date ranges from</param>
        public StartEndDatePair(string dateRange, string[] dateRagesForBase = null, CultureInfo culture = null)
        {
            bool useBase = DateManager.GetUseBaseFromDateRangeArray(dateRange, dateRagesForBase);
            CallDateManager(dateRange, useBase, DateTime.UtcNow, culture);
        }

        /// <summary>
        /// Forced Base or Start Date constructor
        /// </summary>
        /// <param name="dateRange">The date range to set the default values on</param>
        /// <param name="useBase">Set to true to use the base date range or false to use the start from now date</param>
        /// <param name="culture">Optional culture to set the date ranges from</param>
        public StartEndDatePair(string dateRange, bool useBase, CultureInfo culture = null)
        {
            CallDateManager(dateRange, useBase, DateTime.UtcNow, culture);
        }

        /// <summary>
        /// Forced Base or Start Date constructor
        /// </summary>
        /// <param name="dateRange">The date range to set the default values on</param>
        /// <param name="useBase">Set to true to use the base date range or false to use the start from now date</param>
        /// <param name="date">The date to to get the start from</param>
        /// <param name="culture">Optional culture to set the date ranges from</param>
        public StartEndDatePair(string dateRange, bool useBase, DateTime date, CultureInfo culture = null)
        {
            CallDateManager(dateRange, useBase, date, culture);
        }
        

        /// <summary>
        /// Method used to call the date manager
        /// </summary>
        /// <param name="dateRange">The date range to set the default values on</param>
        /// <param name="useBase">Set to true to use the base date range or false to use the start from now date</param>
        /// <param name="date">The date to to get the start from</param>
        /// <param name="culture">Optional culture to set the date ranges from</param>
        private void CallDateManager(string dateRange, bool useBase, DateTime date, CultureInfo culture = null)
        {
            if (useBase)
            {
                DateManager.BaseStartEndDatePair(this, dateRange, date, culture);
            }
            else
            {
                DateManager.SetStartEndDatePair(this, dateRange, date);
            }
        }
    }
    
}
