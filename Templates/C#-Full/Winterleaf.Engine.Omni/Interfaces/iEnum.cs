using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinterLeaf.Engine.Interfaces
    {
    /// <summary>
    /// Class used for custom interface to custom enumerations.
    /// </summary>
    public interface iEnum
        {
        List<string> keyList { get; }
        object this[string key] { get; }
        }
    }
