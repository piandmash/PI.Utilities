using PI.Utilities.Interfaces;

namespace PI.Utilities.Models
{
    /// <summary>
    /// Basic implementation used by all models
    /// </summary>
    public abstract class BaseModel : BaseIdModel, IAuditFields, IAuditFieldsWithId, IQuickSearchValue
    {
        /// <summary>
        /// Gets/sets a quick search value for the object
        /// </summary>
        public virtual string QuickSearchValue { get; set; }
        
    }
}
