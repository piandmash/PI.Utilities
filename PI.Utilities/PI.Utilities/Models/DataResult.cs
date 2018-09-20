using System;
using System.Collections.Generic;
using System.Text;
using PI.Utilities.Interfaces;
namespace PI.Utilities.Models
{

    /// <summary>
    /// Class to manage data results
    /// </summary>
    /// <typeparam name="E">The entry type</typeparam>
    /// <typeparam name="T">The return type</typeparam>
    public class DataResult<E, T> : IDataResult
    {
        #region Errors

        /// <summary>
        /// The Set Data Results Match error
        /// </summary>
        public string Error_SetDataResults_Match { get; set; } = "The expected match count of {0} was not reached. {1} item(s) were matched.";
        
        /// <summary>
        /// The Set Data Results Match None error
        /// </summary>
        public string Error_SetDataResults_MatchNone { get; set; } = "No matching item found.";

        /// <summary>
        /// The Set Data Results Modified error
        /// </summary>
        public string Error_SetDataResults_Modified { get; set; } = "The expected modified count of {0} was not reached. {1} item(s) were modified.";

        /// <summary>
        /// The Set Data Results Modified None error
        /// </summary>
        public string Error_SetDataResults_ModifiedNone { get; set; } = "The item was not modified.";

        #endregion

        /// <summary>
        /// The entry object
        /// </summary>
        public E Entry { get; set; }

        /// <summary>
        /// The result object
        /// </summary>
        public T Result { get; set; }

        /// <summary>
        /// Get/set if the data process was compelted
        /// </summary>
        public bool Completed { get; set; } = false;

        /// <summary>
        /// Get/set the messages
        /// </summary>
        public List<string> Messages { get; set; } = new List<string>();

        /// <summary>
        /// Get/set the detailed messages
        /// </summary>
        public List<object> DetailedMessages { get; set; } = new List<object>();

        /// <summary>
        /// Get/set if the data process was acknowledged
        /// </summary>
        public bool IsAcknowledged { get; set; } = false;

        /// <summary>
        /// Get/set if the data process has a modified count
        /// </summary>
        public bool IsModifiedCountAvailable { get; set; } = false;

        /// <summary>
        /// Get/set the data process has a match count
        /// </summary>
        public long MatchedCount { get; set; } = 0;

        /// <summary>
        /// Get/set the data process Modified Count
        /// </summary>
        public long ModifiedCount { get; set; } = 0;

        /// <summary>
        /// Constructor with the entry
        /// </summary>
        /// <param name="entry">The entry item for the data result</param>
        public DataResult(E entry){
            Entry = entry;
        }

        /// <summary>
        /// Constructor with the entry
        /// </summary>
        /// <param name="entry">The entry item for the data result</param>
        /// <param name="modelErrors">Optional list of model errors, when passed they are added and the completed flag is set to false</param>
        public DataResult(E entry, List<ModelError> modelErrors = null)
        {
            Entry = entry;
            if(modelErrors != null)
            {
                foreach(var m in modelErrors) AddDetailedMessage(m);
                Completed = false;
            }
        }

        /// <summary>
        /// Method to set the expected data results and messages
        /// </summary>
        /// <param name="isAcknowledged">Sets the IsAcknowledged</param>
        /// <param name="isModifiedCountAvailable">Sets the IsModifiedCountAvailable</param>
        /// <param name="matchedCount">Sets the MatchedCount</param>
        /// <param name="modifiedCount">Sets the ModifiedCount</param>
        /// <param name="expectedMatchedCount">The expected Match Count</param>
        /// <param name="expectedModifiedCount">The expected Modified Count</param>
        public void SetDataResults(bool isAcknowledged, bool isModifiedCountAvailable, long matchedCount, long modifiedCount, long expectedMatchedCount = 1, long expectedModifiedCount = 1)
        {
            IsAcknowledged = isAcknowledged;
            IsModifiedCountAvailable = isModifiedCountAvailable;
            MatchedCount = matchedCount;
            ModifiedCount = modifiedCount;
            if(expectedMatchedCount != matchedCount)  Messages.Add((expectedMatchedCount > 1) ? String.Format(Error_SetDataResults_Match, expectedMatchedCount, matchedCount) : Error_SetDataResults_MatchNone);
            Completed = (expectedModifiedCount == modifiedCount);
            if (expectedMatchedCount == matchedCount && expectedModifiedCount != modifiedCount) Messages.Add((expectedMatchedCount > 1) ? String.Format(Error_SetDataResults_Modified, expectedMatchedCount, matchedCount) + " items were modified." : Error_SetDataResults_ModifiedNone);
        }

        /// <summary>
        /// Adds the detailed message and also adds it to the messages using ToString()
        /// </summary>
        /// <param name="message">The detailed message to add</param>
        public void AddDetailedMessage(object message)
        {
            DetailedMessages.Add(message);
            Messages.Add(message.ToString());
        }

        /// <summary>
        /// Adds the detailed message and also adds it to the messages using ToString()
        /// </summary>
        /// <param name="message">The detailed message to add</param>
        /// <param name="index">Optional zero based index the message should be added - defaults to 0</param>
        public void InsertDetailedMessage(object message, int index = 0)
        {
            DetailedMessages.Insert(index, message);
            Messages.Insert(index, message.ToString());
        }
    }
}
