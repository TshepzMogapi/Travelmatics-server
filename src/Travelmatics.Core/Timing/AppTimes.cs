using System;
using Abp.Dependency;

namespace Travelmatics.Timing
{
    public class AppTimes : ISingletonDependency
    {
        /// <summary>
        /// Gets the startup time of the application.
        /// </summary>
        public DateTime StartupTime { get; set; }
    }
}
