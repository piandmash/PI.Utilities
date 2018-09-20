using PI.Utilities.Interfaces;
using System;

namespace PI.Utilities.Models
{
    /// <summary>
    /// Basic implementation used by all models requiring a string Id
    /// </summary>
    public abstract class BaseIdModel : BaseAuditModel, IAuditFields, IAuditFieldsWithId
    {
        private string _id = Guid.NewGuid().ToString();
        /// <summary>
        /// Gets/sets the object id
        /// </summary>
        public virtual string Id { get { return _id; } set { _id = value; } }
        
    }
}
