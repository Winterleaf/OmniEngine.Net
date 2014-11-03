


#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using System.ComponentModel;
using System.Threading;
using  WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Demo.Full.Models.User.Extendable;
#endregion

namespace WinterLeaf.Demo.Full.Models.Base
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(TypeConverterGeneric<ConsoleLogger_Base>))]
    public partial class ConsoleLogger_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ConsoleLogger_Base ts, string simobjectid)
            {
            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }
  /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
            {
            return base.GetHashCode();
            }
  /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
            {
            
            return (this._ID ==(string)myReflections.ChangeType( obj,typeof(string)));
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ConsoleLogger_Base ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);

            }


            /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string( ConsoleLogger_Base ts)
            {
            if (object.ReferenceEquals(ts, null))
                 return "0";
            return ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ConsoleLogger_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ConsoleLogger_Base) Omni.self.getSimObject(simobjectid,typeof(ConsoleLogger_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ConsoleLogger_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ConsoleLogger_Base(int simobjectid)
            {
            return  (ConsoleLogger) Omni.self.getSimObject((uint)simobjectid,typeof(ConsoleLogger_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ConsoleLogger_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ConsoleLogger_Base(uint simobjectid)
            {
            return  (ConsoleLogger_Base) Omni.self.getSimObject(simobjectid,typeof(ConsoleLogger_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Determines the priority level and attention the logged entry gets when recorded\n\n 
/// </summary>
[MemberGroup("Logging")]
public TypeLogLevel level
       {
       get
          {          return (TypeLogLevel) Omni.self.GetVar(_ID + ".level");
          }
       set
          {
          Omni.self.SetVar(_ID + ".level", value.ToString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// () Attaches the logger to the console and begins writing to file
/// 			  @tsexample
/// 			  // Create the logger
/// 			  // Will automatically start writing to testLogging.txt with normal priority
/// 			  new ConsoleLogger(logger, \"testLogging.txt\", false);
/// 			  // Send something to the console, with the logger consumes and writes to file
/// 			  echo(\"This is logged to the file\");
/// 			  // Stop logging, but do not delete the logger
/// 			  logger.detach();
/// 			  echo(\"This is not logged to the file\");
/// 			  // Attach the logger to the console again
/// 			  logger.attach();
/// 			  // Logging has resumed
/// 			  echo(\"Logging has resumed\");
/// 			  @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool attach(){

return pInvokes.m_ts.fn_ConsoleLogger_attach(_ID);
}
/// <summary>
/// () Detaches the logger from the console and stops writing to file
/// 			  @tsexample
/// 			  // Create the logger
/// 			  // Will automatically start writing to testLogging.txt with normal priority
/// 			  new ConsoleLogger(logger, \"testLogging.txt\", false);
/// 			  // Send something to the console, with the logger consumes and writes to file
/// 			  echo(\"This is logged to the file\");
/// 			  // Stop logging, but do not delete the logger
/// 			  logger.detach();
/// 			  echo(\"This is not logged to the file\");
/// 			  // Attach the logger to the console again
/// 			  logger.attach();
/// 			  // Logging has resumed
/// 			  echo(\"Logging has resumed\");
/// 			  @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool detach(){

return pInvokes.m_ts.fn_ConsoleLogger_detach(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public ConsoleLogger_Base (){}
}}
