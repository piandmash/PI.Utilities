using System;

namespace PI.Utilities.Dates.Interfaces
{
    
    public interface IStartEndDatePair
    {
        /// <summary>
        /// The date the counter started from
        /// </summary>
        DateTime StartDate { get; set; }

        /// <summary>
        /// The date the counter ended at
        /// </summary>
        DateTime EndDate { get; set; }
    }
    
}
