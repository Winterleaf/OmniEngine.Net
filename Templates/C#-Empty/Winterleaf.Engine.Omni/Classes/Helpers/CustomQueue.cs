using System;

namespace WinterLeaf.Engine.Classes.Helpers
{
    /// <summary>
    /// Internal Use.
    /// </summary>
    internal class CustomQueue
    {
        public const int Maxsize = 500000;
        private readonly int[] _mData = new int[Maxsize + 1];
        private int _mEnd = 0;
        private int _mStart = 0;

        private int _size = 0;

        public int size
        {
            get { return Maxsize + _size; }
        }

        internal void Push(int val)
        {
            _mData[_mEnd] = val;
            _mEnd++;
            if (_mEnd > Maxsize)
                _mEnd = 0;
#if DEBUG
            if ((_mEnd == _mStart) && _mEnd != 0)
                throw new Exception("Very Bad");
#endif
            _size--;
        }

        internal int Pop()
        {
            int returnval = _mData[_mStart];
            _mStart = _mStart + 1;
            if (_mStart > Maxsize)
                _mStart = 0;
#if DEBUG
            if (_mEnd == _mStart)
                throw new Exception("Very Bad");

#endif
            _size++;
            return returnval;
        }
    }
}