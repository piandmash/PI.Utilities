using System;
using System.Collections.Generic;
using System.Text;

namespace PI.Utilities.Models
{

    /// <summary>
    /// A class to manage search results
    /// </summary>
    public class SearchResult<T>
    {

        /// <summary>
        /// Get/set the total count of the result set
        /// </summary>
        public double TotalCount { get; set; }

        /// <summary>
        /// List of all the results
        /// </summary>
        public IEnumerable<T> Results { get; set; }

        /// <summary>
        /// Get/set the filter
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// Get/set the search term
        /// </summary>
        public string SearchTerm { get; set; }

        /// <summary>
        /// Get/set the sort order
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// Get/set the total count of the result set
        /// </summary>
        public int StartAt { get; set; }

        /// <summary>
        /// Get/set the total count of the result set
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Get/set the total page count
        /// </summary>
        public double TotalPageCount
        {
            get
            {
                return Math.Ceiling(TotalCount / PageSize);
            }
        }

    }
}
