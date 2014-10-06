//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Configuration;
//using System.Globalization;
//using System.ComponentModel;
//using System.Collections.Specialized;


//namespace WinterLeaf.Classes
//    {
//    /// <summary>
//    /// 
//    /// </summary>
//    public static class Settings
//        {
//        private static string CleanSectionName(string section)
//            {
//            return (section.Trim().ToLower().Replace('/', '.'));
//            }

//        /// <summary>
//        /// Returns whether or not the config has the section requested.
//        /// </summary>
//        /// <param name="section"></param>
//        /// <returns></returns>
//        internal static bool HasSection(string section)
//            {
//            section = CleanSectionName(section);
//            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
//            PrefConfigurationSection prefConfigSection = config.GetSection(section) as PrefConfigurationSection;
//            return (prefConfigSection != null);
//            }

//        /// <summary>
//        /// Retrieves a Variable from the given section with the name passed
//        /// </summary>
//        /// <param name="section">Which Section to Load From(Not Case Sensitive)</param>
//        /// <param name="variable">Variable Name (Not case sensitive)</param>
//        /// <returns></returns>
//        internal static string GetVariable(string section, string variable)
//            {
//            section = CleanSectionName(section);
//            variable = variable.Trim().ToLower();
//            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
//            PrefConfigurationSection prefConfigSection = config.GetSection(section) as PrefConfigurationSection;
//            if (prefConfigSection == null)
//                return string.Empty;
//            foreach (Pref p in from Pref p in prefConfigSection.Preferences where p.Name == variable select p)
//                return p.Value;
//            return string.Empty;
//            }

//        /// <summary>
//        /// Sets a variable for the given section with the value passed.
//        /// </summary>
//        /// <param name="section">Which Section to Load From(Not Case Sensitive)</param>
//        /// <param name="variable">Variable Name (Not Case Sensitive)</param>
//        /// <param name="value">New Value</param>
//        internal static void SetVariable(string section, string variable, string value)
//            {
//            section = CleanSectionName(section);
//            variable = variable.Trim().ToLower();
//            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
//            PrefConfigurationSection prefConfigSection = config.GetSection(section) as PrefConfigurationSection;
//            if (prefConfigSection == null)
//                {
//                prefConfigSection = new PrefConfigurationSection();
//                config.Sections.Add(section, prefConfigSection);
//                }
//            prefConfigSection.Preferences.Add(new Pref(variable, value));
//            config.Save(ConfigurationSaveMode.Full);
//            }

//        /// <summary>
//        /// Returns a dictioniary of Variable Name, Variable Value for the passed section
//        /// </summary>
//        /// <param name="section">Section(Not Case Sensitive)</param>
//        /// <returns></returns>
//        internal static Dictionary<string, string> GetVariables(string section)
//            {
//            section = CleanSectionName(section);
//            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
//            PrefConfigurationSection prefConfigSection = config.GetSection(section) as PrefConfigurationSection;
//            return prefConfigSection == null ? new Dictionary<string, string>() : prefConfigSection.Preferences.Cast<Pref>().ToDictionary(p => p.Name, p => p.Value);
//            }

//        /// <summary>
//        /// Replaces a sections variable definition with those of the passed dictionary.
//        /// </summary>
//        /// <param name="section">Section(Not Case Sensitive)</param>
//        /// <param name="variables">New Dictionary of Variables to replace that sections variables with(Not Case Sensitive)</param>
//        internal static void SetVariables(string section, Dictionary<string, string> variables)
//            {
//            section = CleanSectionName(section);
//            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
//            PrefConfigurationSection prefConfigSection = config.GetSection(section) as PrefConfigurationSection;
//            if (prefConfigSection == null)
//                {
//                prefConfigSection = new PrefConfigurationSection();
//                config.Sections.Add(section, prefConfigSection);
//                }
//            prefConfigSection.Preferences.Clear();
//            foreach (KeyValuePair<string, string> kvp in variables)
//                prefConfigSection.Preferences.Add(new Pref(kvp.Key.Trim().ToLower(), kvp.Value));
//            config.Save(ConfigurationSaveMode.Full);
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="section"></param>
//        internal static void ClearVariables(string section)
//            {
//            section = CleanSectionName(section);
//            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
//            PrefConfigurationSection prefConfigSection = config.GetSection(section) as PrefConfigurationSection;
//            if (prefConfigSection == null)
//                return;
//            prefConfigSection.Preferences.Clear();
//            config.Save(ConfigurationSaveMode.Full);
//            }

//        internal static void LoadSection(string section)
//            {
//            section = CleanSectionName(section);
//            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
//            PrefConfigurationSection prefConfigSection = config.GetSection(section) as PrefConfigurationSection;
//            if (prefConfigSection == null)
//                return;

//            foreach (Pref p in prefConfigSection.Preferences)
//                Omni.self.SetVar(p.Name, p.Value);

//            }

//        #region Settings Code
//        private class Pref : ConfigurationElement
//            {
//            public Pref() { }

//            public Pref(string name, string value)
//                {
//                Name = name;
//                Value = value;
//                }

//            [ConfigurationProperty("Name", DefaultValue = "_NotSet_", IsRequired = true, IsKey = true)]
//            public string Name
//                {
//                get { return (string)this["Name"]; }
//                set { this["Name"] = value; }
//                }

//            [ConfigurationProperty("Value", DefaultValue = "", IsRequired = true, IsKey = false)]
//            public string Value
//                {
//                get { return (string)this["Value"]; }
//                set { this["Value"] = value; }
//                }
//            }

//        private class PrefCollection : ConfigurationElementCollection
//            {
//            public Pref this[int index]
//                {
//                get { return (Pref)BaseGet(index); }
//                set
//                    {
//                    if (BaseGet(index) != null)
//                        {
//                        BaseRemoveAt(index);
//                        }
//                    BaseAdd(index, value);
//                    }
//                }

//            public void Add(Pref serviceConfig)
//                {
//                BaseAdd(serviceConfig);
//                }

//            public void Clear()
//                {
//                BaseClear();
//                }

//            protected override ConfigurationElement CreateNewElement()
//                {
//                return new Pref();
//                }

//            protected override object GetElementKey(ConfigurationElement element)
//                {
//                return ((Pref)element).Name;
//                }

//            public void Remove(Pref serviceConfig)
//                {
//                BaseRemove(serviceConfig.Name);
//                }

//            public void RemoveAt(int index)
//                {
//                BaseRemoveAt(index);
//                }

//            public void Remove(string name)
//                {
//                BaseRemove(name);
//                }
//            }

//        private class PrefConfigurationSection : ConfigurationSection
//            {
//            [ConfigurationProperty("Preferences", IsDefaultCollection = false)]
//            [ConfigurationCollection(typeof(PrefCollection), AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
//            public PrefCollection Preferences
//                {
//                get
//                    {
//                    return (PrefCollection)base["Preferences"];
//                    }
//                }
//            }
//        #endregion
//        }



//    }
