﻿using Nop.Core.Caching;
using Nop.Core.Infrastructure;
using Nop.Services.Messages;
using Nop.Services.Tasks;

namespace Nop.Services.Caching
{
    /// <summary>
    /// Clear cache schedueled task implementation
    /// </summary>
    public partial class ClearCacheTask : ITask
    {
        private readonly IStaticCacheManager _staticCacheManager;

        public ClearCacheTask(IStaticCacheManager staticCacheManager)
        {
            this._staticCacheManager = staticCacheManager;
        }

        /// <summary>
        /// Executes a task
        /// </summary>
        public void Execute()
        {
            _staticCacheManager.Clear();
        }
    }
}
