using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyHost.Services
{
    /// <summary>
    /// Defines Application-wide Settings.
    /// </summary>
    public interface IApplicationSettings
    {
        /// <summary>
        /// Base Path for the Nancy Modules.
        /// </summary>
        string NancyBasePath { get; }

        /// <summary>
        /// Base Path for the Token.
        /// </summary>
        string TokenEndpointBasePath { get; }

        /// <summary>
        /// Size of the salts for Password generation.
        /// </summary>
        int SaltSize { get; }
    }
}
