namespace PI.Utilities.Interfaces
{
    public interface IFile
    {
        
        /// <summary>
        /// Gets/sets the object id
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// The raw Content-Type header of the file.
        /// </summary>
        string ContentType { get; set;  }
        
        /// <summary>
        /// The file length in bytes.
        /// </summary>
        long Length { get; set;  }

        /// <summary>
        /// The name of the file
        /// </summary>
        string Name { get; set;  }

        /// <summary>
        /// The file name of the file
        /// </summary>
        string FileName { get; set;  }

        /// <summary>
        /// Sets the stored state for the file
        /// </summary>
        string StoredState { get; set; }
        
    }
}
