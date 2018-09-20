using System;
using System.Collections.Generic;
using System.Text;

namespace PI.Utilities.Models
{

    /// <summary>
    /// Static class to manage audit functions
    /// </summary>
    public class AuditContainer<T>
    {
        /// <summary>
        /// Get/set audit item id should be the same as all the audit items
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// List of all the audit items
        /// </summary>
        public List<T> AuditItems { get; set; }
    }
}
