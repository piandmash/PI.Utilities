using System.Collections.Generic;
namespace PI.Utilities.Interfaces
{
    public interface INotes
    {
        /// <summary>
        /// Gets/sets the notes assigned to the object
        /// </summary>
        List<INote> Notes { get; set; }
    }
}
