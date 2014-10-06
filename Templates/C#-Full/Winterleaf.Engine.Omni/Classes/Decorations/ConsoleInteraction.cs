using System;

namespace WinterLeaf.Engine.Classes.Decorations
    {
    /// <summary>
    /// This class is Method Decorator to expose a function in an assembly to the T3D engine.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class ConsoleInteraction : Attribute
        {
        private readonly bool _exposeToConsole;
        private readonly string _alias;
        public ConsoleInteraction()
        {
            _exposeToConsole = true;
            _alias = "";
            }
        /// <summary>
        /// This decoration is used to flag a function for exposure in the console.
        /// </summary>
        /// <param name="exposeToConsole">Allow the function to be called from the game console.</param>
        public ConsoleInteraction(bool exposeToConsole)
            {
            _exposeToConsole = exposeToConsole;
            _alias = "";
            }
        public ConsoleInteraction(bool exposeToConsole, string alias)
            {
            _exposeToConsole = exposeToConsole;
            _alias = alias;
            }

        /// <summary>
        /// Flag which determines if the function is exposed to the game console.
        /// </summary>
        public bool ExposeToConsole
            {
            get { return _exposeToConsole; }
            }

        public string Alias
            {
            get { return _alias; }
            }
        }
    }
