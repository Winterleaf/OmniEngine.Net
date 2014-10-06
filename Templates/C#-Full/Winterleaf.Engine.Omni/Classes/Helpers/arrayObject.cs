using System;

namespace WinterLeaf.Engine.Classes.Helpers
    {
    /// <summary>
    /// Used to display member properties of SimObjects which store data in Arrays.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class arrayObject<T>
        {
        private string _name = "";
        private ModelBase _parent;
        private int _upperbound = 0;

        /// <summary>
        /// Creates a new Array Object handler
        /// </summary>
        /// <param name="upperbound">Number of elements</param>
        /// <param name="name">Name of Parameter</param>
        /// <param name="structuretype">Not Used</param>
        /// <param name="isscript">Not Used</param>
        /// <param name="parent">Parent Proxy Object.</param>
        public arrayObject(int upperbound, string name, string structuretype, bool isscript, ModelBase parent)
            {
            _upperbound = upperbound;
            _name = name;
            _parent = parent;
            }

        /// <summary>
        /// Gets the element at this position in the array.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public T this[int key]
            {
            get
                {
                if (key < 0 || key > _upperbound)
                    throw new Exception("OUT OF BOUNDS!");

                string newValue = Omni.self.GetVar(_parent + "." + _name + "[" + key + "]");

                return (T)(myReflections.ChangeType(newValue, typeof(T)));
                }
            set
                {
                if (key < 0 || key > _upperbound)
                    throw new Exception("OUT OF BOUNDS!");

                string newValue = value.ToString();

                Omni.self.SetVar(_parent + "." + _name + "[" + key + "]",
                    (String)myReflections.ChangeType(newValue, typeof(string)));
                }
            }

        /// <summary>
        /// Gets the upperbound defined for the array.
        /// </summary>
        /// <returns></returns>
        public int getUpperbound()
            {
            return _upperbound;
            }
        }
    }