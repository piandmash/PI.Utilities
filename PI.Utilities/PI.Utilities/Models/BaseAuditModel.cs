using PI.Utilities.Interfaces;
using System;

namespace PI.Utilities.Models
{
    /// <summary>
    /// Basic implementation used by all models
    /// </summary>
    public abstract class BaseAuditModel : IAuditFields
    {

        /// <summary>
        /// Gets/sets the object creator
        /// </summary>
        public virtual string CreatedBy { get; set; }


        private DateTime _CreatedDate = new DateTime(1900, 1, 1);
        /// <summary>
        /// Gets/sets the created date
        /// </summary>
        public virtual DateTime CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }

        /// <summary>
        /// Gets/sets the last updater of the object
        /// </summary>
        public virtual string UpdatedBy { get; set; }


        private DateTime _UpdatedDate = new DateTime(1900, 1, 1);
        /// <summary>
        /// Gets/sets the last updated date
        /// </summary>
        public virtual DateTime UpdatedDate
        {
            get { return _UpdatedDate; }
            set { _UpdatedDate = value; }
        }

        /// <summary>
        /// Gets/sets if the items version, should be incremented as required
        /// </summary>
        public virtual int Version { get; set; } = 1;

        /// <summary>
        /// Gets/sets if the item is deleted
        /// </summary>
        public virtual bool Deleted { get; set; }

        /// <summary>
        /// Gets/sets if the item is archived
        /// </summary>
        public virtual bool Archived { get; set; }
    }
}
