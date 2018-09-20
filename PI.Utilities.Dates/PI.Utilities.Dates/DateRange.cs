using System;
using System.Globalization;

namespace PI.Utilities.Dates
{

    public static class DateRange
    {
        public const string Total = "Total";
        public const string Year = "Year";
        public const string Month = "Month";
        public const string Week = "Week";
        public const string Day = "Day";
        public const string Hour = "Hour";
        public const string HalfHour = "HalfHour";
        public const string FifteenMinutes = "FifteenMinutes";
        public const string TenMinutes = "TenMinutes";
        public const string FiveMinutes = "FiveMinutes";
        public const string Timespan = "Timespan";

        public static bool IsValid(string dateRange)
        {
            switch (dateRange.ToLower())
            {
                case "total":
                    return true;
                case "year":
                    return true;
                case "month":
                    return true;
                case "week":
                    return true;
                case "day":
                    return true;
                case "hour":
                    return true;
                case "halfhour":
                    return true;
                case "fifteenminutes":
                    return true;
                case "tenminutes":
                    return true;
                case "fiveminutes":
                    return true;
                case "timespan":
                    return true;
            }
            return false;
        }
    }
    
}
