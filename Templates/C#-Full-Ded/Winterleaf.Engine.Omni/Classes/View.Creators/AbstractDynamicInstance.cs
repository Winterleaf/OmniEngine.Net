using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine.Classes.Extensions;

namespace WinterLeaf.Engine.Classes.View.Creators
{
   /// <summary>
   /// 
   /// </summary>
   public abstract class AbstractDynamicInstance
   {
      private readonly IDictionary<string, object> mExpandoObject =
        new ExpandoObject();
      protected IDictionary<string, string> mFieldsDictionary =
        new Dictionary<string, string>();

      /// <summary>
      /// 
      /// </summary>
      public dynamic Dynamics
      {
         get { return mExpandoObject; }
      }

      protected IDictionary<string, string> Fields
      {
         get { return mFieldsDictionary; }
      }

      /// <summary>
      ///   This will return the TorqueScript code that will be executed when Create is called.
      /// </summary>
      /// <returns> </returns>
      public override string ToString()
      {
         StringBuilder result = new StringBuilder();
         result.Append(")\r\n{\r\n");
         foreach (KeyValuePair<string, string> ele in mFieldsDictionary)
         {
            result.Append(ele.Key);
            result.Append(" = ");
            result.Append(ele.Value.ToString().Trim() != string.Empty ? ele.Value : "\"\"");
            result.Append(";\r\n");
         }
         foreach (KeyValuePair<string, object> ele in mExpandoObject)
         {
            result.Append(ele.Key);
            result.Append(" = ");
            result.Append(ele.Value.ToString().Trim() != string.Empty ? ele.Value : "\"\"");
            result.Append(";\r\n");
         }
         result.Append("};\r\n");
         return (result.ToString());
      }
   }
}
