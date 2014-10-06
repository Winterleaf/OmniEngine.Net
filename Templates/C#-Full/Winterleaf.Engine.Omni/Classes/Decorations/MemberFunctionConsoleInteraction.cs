using System;

namespace WinterLeaf.Engine.Classes.Decorations
    {
    /// <summary>
    /// Internal use, Decorator used to inform the OMNI Framework that if this function is called by the engine to pass it back to the engine.  Avoid C++ calling C# to call c++
    /// </summary>
    public class MemberFunctionConsoleInteraction : Attribute
        {
        private readonly bool _exposeToConsole;
        /// <summary>
        /// This decoration is used to flag a function for exposure in the console by the autogenerator, not intended to be used by developer.
        /// </summary>
        /// <param name="exposeToConsole">Allow the function to be called from the game console.</param>
        public MemberFunctionConsoleInteraction(bool exposeToConsole)
            {
            _exposeToConsole = exposeToConsole;
            }

        /// <summary>
        /// Flag which determines if the function is exposed to the game console.
        /// </summary>
        public bool ExposeToConsole
            {
            get { return _exposeToConsole; }
            }
        }

  
    }
