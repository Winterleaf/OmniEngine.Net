using System;
using System.Collections;
using System.Collections.Generic;

namespace WinterLeaf.Engine.Classes.View.Creators
{
   public class FieldWrapper<T> : IEnumerable
   {
      private IDictionary<string, string> mParentDictionary;
      private string mName;

      public void Set(ref IDictionary<string, string> pDictionary, string pName)
      {
         mParentDictionary = pDictionary;
         mName = pName;
      }

      public void Add(int arg1, T arg2)
      {
         mParentDictionary[mName + "[" + arg1 + "]"] = arg2.ToString();
      }

      public IEnumerator GetEnumerator()
      {
         throw new NotImplementedException();
      }
   }
}
