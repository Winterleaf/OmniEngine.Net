using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinterLeaf.Engine.Classes.Helpers
    {
    /// <summary>
    /// Internal use.
    /// </summary>
    internal class IndexingResult
        {
        public IndexingResult()
            {
            ClassesFound = new List<string>();
            GlobalFunctsFound = new List<string>();
            }

        public List<string> ClassesFound { get; set; }

        public List<string> GlobalFunctsFound { get; set; }
        }
    }
