namespace PI.Utilities.Interfaces
{
    public interface IBaseNameProperties
    {
        /// <summary>
        /// Gets/sets the name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets/sets a quick search value for the object
        /// </summary>
        string QuickSearchValue { get; set; }
    }
}