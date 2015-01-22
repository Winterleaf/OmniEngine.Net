using System;
using System.Collections.Generic;
using System.Text;

namespace WinterLeaf.Engine.Classes.View.Creators
{
   public enum ObjectType
   {
      Instance,
      Datablock,
      Singleton
   }
   /// <summary>
   /// 
   /// </summary>
   public class ObjectInstance : AbstractDynamicInstance
   {
      private string mInstanceName;
      private string mClassName;
      private ObjectType mObjectType;

      public ObjectInstance(string pInstanceName, string pClassName, ObjectType pObjectType)
      {
         mClassName = pClassName;
         mInstanceName = pInstanceName;
         mObjectType = pObjectType;
      }

      /// <summary>
      ///   This will return the TorqueScript code that will be executed when Create is called.
      /// </summary>
      /// <returns> </returns>
      public override string ToString()
      {
         StringBuilder result = new StringBuilder();
         switch (mObjectType)
         {
            case ObjectType.Instance:
               result.Append(" new ");
               break;
            case ObjectType.Datablock:
               result.Append(" datablock ");
               break;
            case ObjectType.Singleton:
               result.Append(" singleton ");
               break;
         }
         result.Append(mClassName);
         result.Append("(");
         result.Append(mInstanceName);
         result.Append(base.ToString());
         return (result.ToString());
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator ModelBase(ObjectInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString() + ";", true);
         return UInt32.TryParse(id, out r) ? r : 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(ObjectInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString() + ";", true);
      }
   }
}
