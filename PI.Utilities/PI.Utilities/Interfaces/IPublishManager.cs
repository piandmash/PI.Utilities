using System;
using System.Threading.Tasks;
namespace PI.Utilities.Interfaces
{
    /// <summary>
    /// Methods for a manager that offers publication
    /// </summary>
    public interface IPublishManager<T>
    {

        /// <summary>
        /// Publishes the item to the new step
        /// </summary>
        /// <param name="item">The item to publish</param>
        /// <param name="properties">The publishing properties</param>
        /// <param name="dataResult">Optional data result interface</param>
        Task Publish(T item, IPublishingProperties properties, IDataResult dataResult = null);
        
        /// <summary>
        /// Revokes publication of the item from the current step to the new step
        /// </summary>
        /// <param name="item">The item to remove from publish</param>
        /// <param name="properties">The publishing properties</param>
        /// <param name="status">The status to reset the promotion to</param>
        /// <param name="dataResult">Optional data result interface</param>
        /// <returns>The matching IPromotion</returns>
        Task Revoke(T item, IPublishingProperties properties, IDataResult dataResult = null);

    }
}
