using System.Collections.Generic;

namespace PI.Utilities.Interfaces
{
    public interface IDataResult
    {
        /// <summary>
        /// Get/set if the data process was compelted
        /// </summary>
        bool Completed { get; set; }

        /// <summary>
        /// Get/set the messages
        /// </summary>
        List<string> Messages { get; set; }

        /// <summary>
        /// Get/set the detailed messages
        /// </summary>
        List<object> DetailedMessages { get; set; }

        /// <summary>
        /// Get/set if the data process was acknowledged
        /// </summary>
        bool IsAcknowledged { get; set; }

        /// <summary>
        /// Get/set if the data process has a modified count
        /// </summary>
        bool IsModifiedCountAvailable { get; set; }

        /// <summary>
        /// Get/set the data process has a match count
        /// </summary>
        long MatchedCount { get; set; }

        /// <summary>
        /// Get/set the data process Modified Count
        /// </summary>
        long ModifiedCount { get; set; }
        
        /// <summary>
        /// Method to set the expected data results and messages
        /// </summary>
        /// <param name="isAcknowledged">Sets the IsAcknowledged</param>
        /// <param name="isModifiedCountAvailable">Sets the IsModifiedCountAvailable</param>
        /// <param name="matchedCount">Sets the MatchedCount</param>
        /// <param name="modifiedCount">Sets the ModifiedCount</param>
        /// <param name="expectedMatchedCount">The expected Match Count</param>
        /// <param name="expectedModifiedCount">The expected Modified Count</param>
        void SetDataResults(bool isAcknowledged, bool isModifiedCountAvailable, long matchedCount, long modifiedCount, long expectedMatchedCount = 1, long expectedModifiedCount = 1);

        /// <summary>
        /// Adds the detailed message and also adds it to the messages using ToString()
        /// </summary>
        /// <param name="message">The detailed message to add</param>
        void AddDetailedMessage(object message);
    }
}