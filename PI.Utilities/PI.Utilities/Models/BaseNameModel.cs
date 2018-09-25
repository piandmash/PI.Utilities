using PI.Utilities.Interfaces;
using System;

namespace PI.Utilities.Models
{
    /// <summary>
    /// Basic implementation used by all models requiring a client id
    /// </summary>
    public abstract class BaseNameModel : BaseIdWithQuickSearchModel, IName, IAuditFields, IAuditFieldsWithId, IQuickSearchValue
    {
        private string _QuickSearchValue = "";
        /// <summary>
        /// Gets/sets a quick search value for the object
        /// </summary>
        public override string QuickSearchValue
        {
            get
            {
                if (String.IsNullOrEmpty(_QuickSearchValue))
                {
                    _QuickSearchValue = Name;
                }
                return _QuickSearchValue;
            }
            set { _QuickSearchValue = value; }
        }

        /// <summary>
        /// Gets/sets the item name
        /// </summary>
        public string Name { get; set; }

    }
}
