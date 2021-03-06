﻿using System;

namespace PI.Utilities.Interfaces
{
    public interface IAuditFieldsWithId : IAuditFields
    {
        /// <summary>
        /// Gets/sets the object id
        /// </summary>
        string Id { get; set; }

    }
}
