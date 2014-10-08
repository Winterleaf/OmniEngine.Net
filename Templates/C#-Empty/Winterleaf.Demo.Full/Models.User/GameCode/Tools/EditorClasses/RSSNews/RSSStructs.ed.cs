using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.EditorClasses.RSSNews
    {
    public class RSSStructs
        {
        [ConsoleInteraction]
        public static string constructRSSHeadline(string headline, string link)
            {
            ObjectCreator oc = new ObjectCreator("ScriptObject", "", typeof (RSSHeadline));
            oc["_headline"] = headline;
            oc["_link"] = link;

            RSSHeadline ret = oc.Create();

            return ret;
            }

        //------------------------------------------------------------------------------

        [ConsoleInteraction]
        public static string constructRSSHeadlineCollection()
            {
            RSSHeadlineCollection ret = new ObjectCreator("ScriptObject", "", typeof (RSSHeadlineCollection)).Create();

            // Create sim group for it
            ret._simGroup = new ObjectCreator("SimGroup").Create().AsString();

            return ret;
            }

        [TypeConverter(typeof (TypeConverterGeneric<RSSHeadline>))]
        public class RSSHeadline : ScriptObject
            {
            [ConsoleInteraction]
            public string getHeadline()
                {
                return this["_headline"];
                }

            [ConsoleInteraction]
            public string getLink()
                {
                return this["_link"];
                }

            [ConsoleInteraction]
            public bool sameAs(RSSHeadline headline)
                {
                return (Util.strcmp(this.toString(), headline.toString()) == 0);
                }

            [ConsoleInteraction]
            public string toString()
                {
                return this.getHeadline() + " ( " + this.getLink() + " ) ";
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RSSHeadline ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
                    : ts.Equals(simobjectid);
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
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(RSSHeadline ts, string simobjectid)
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
            public static implicit operator string(RSSHeadline ts)
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
            public static implicit operator RSSHeadline(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (RSSHeadline) Omni.self.getSimObject(simobjectid, typeof (RSSHeadline));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RSSHeadline ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RSSHeadline(int simobjectid)
                {
                return (RSSHeadline) Omni.self.getSimObject((uint) simobjectid, typeof (RSSHeadline));
                }


            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RSSHeadline ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RSSHeadline(uint simobjectid)
                {
                return (RSSHeadline) Omni.self.getSimObject(simobjectid, typeof (RSSHeadline));
                }

            #endregion
            }

        public class RSSHeadlineCollection : ScriptObject
            {
            public SimGroup _simGroup
                {
                get { return this["_simGroup"]; }
                set { this["_simGroup"] = value; }
                }

            [ConsoleInteraction]
            public string getObject(uint index)
                {
                string ret = this._simGroup.getObject(index);

                if (!ret.isObject())
                    {
                    Util._warn("No such index in headline collection.");
                    return "0";
                    }

                return ret;
                }

            [ConsoleInteraction]
            public int getCount()
                {
                return this._simGroup.getCount();
                }

            [ConsoleInteraction]
            public bool addHeadline(RSSHeadline headline, bool skipReorder)
                {
                for (uint i = 0; i < this.getCount(); i++)
                    {
                    RSSHeadline obj = this.getObject(i);

                    if (obj.sameAs(headline))
                        {
                        //echo( "cache hit headline: " @ %headline.toString() );
                        return false;
                        }
                    }

                this._simGroup.add(headline);

                if (!skipReorder)
                    this._simGroup.bringToFront(headline);

                //echo( "adding headline: " @ %headline.toString() );

                return true;
                }

            [ConsoleInteraction]
            public void writeToFile(string file)
                {
                iGlobal["$rssHeadlineCollection::count"] = this.getCount();

                for (uint i = 0; i < this.getCount(); i++)
                    {
                    RSSHeadline hdl = this.getObject(i);
                    sGlobal["$rssHeadlineCollection::headline[" + i + "]"] = hdl.getHeadline();
                    sGlobal["$rssHeadlineCollection::link[" + i + "]"] = hdl.getLink();
                    }

                Util.export("$rssHeadlineCollection::*", file, false);
                }

            [ConsoleInteraction]
            public void loadFromFile(string file)
                {
                this._simGroup.clear();

                iGlobal["$rssHeadlineCollection::count"] = 0;

                file = Util.getPrefsPath(file);
                if (Util.isFile(file) || Util.isFile(file + ".dso"))
                    Util.exec(file, false, false);

                for (int i = 0; i < iGlobal["$rssHeadlineCollection::count"]; i++)
                    {
                    //echo( "[LD: " @ %i @ "] Headline: " @ $rssHeadlineCollection::headline[%i] );
                    //echo( "[LD: " @ %i @ "] Link: " @ $rssHeadlineCollection::link[%i] );

                    RSSHeadline hdl = constructRSSHeadline(sGlobal["$rssHeadlineCollection::headline[" + i + "]"],
                        sGlobal["$rssHeadlineCollection::link[" + i + "]"]);

                    // This does negate the cache check, but that is ok -pw                             
                    this.addHeadline(hdl, true);
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RSSHeadlineCollection ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
                    : ts.Equals(simobjectid);
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
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(RSSHeadlineCollection ts, string simobjectid)
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
            public static implicit operator string(RSSHeadlineCollection ts)
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
            public static implicit operator RSSHeadlineCollection(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (RSSHeadlineCollection) Omni.self.getSimObject(simobjectid, typeof (RSSHeadlineCollection));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RSSHeadlineCollection ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RSSHeadlineCollection(int simobjectid)
                {
                return
                    (RSSHeadlineCollection) Omni.self.getSimObject((uint) simobjectid, typeof (RSSHeadlineCollection));
                }


            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RSSHeadlineCollection ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RSSHeadlineCollection(uint simobjectid)
                {
                return (RSSHeadlineCollection) Omni.self.getSimObject(simobjectid, typeof (RSSHeadlineCollection));
                }

            #endregion
            }
        }
    }