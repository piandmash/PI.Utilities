using PI.Utilities.Interfaces;
using System;

namespace PI.Utilities.Models
{
    /// <summary>
    /// Basic implementation used by all models requiring an id
    /// </summary>
    public abstract class BaseIdWithQuickSearchModel : BaseIdModel, IAuditFields, IAuditFieldsWithId, IQuickSearchValue
    {

        /// <summary>
        /// Gets/sets a quick search value for the object
        /// </summary>
        public virtual string QuickSearchValue { get; set; }

    }
}
