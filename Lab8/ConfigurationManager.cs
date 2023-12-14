using System;
using System.Collections.Generic;

namespace Lab8
{
    public class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private Dictionary<string, string> settings;


        private ConfigurationManager()
        {
            settings = new Dictionary<string, string>();
        }


        public static ConfigurationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
                return instance;
            }
        }


        public string GetSetting(string key)
        {
            if (settings.ContainsKey(key))
            {
                return settings[key];
            }
            return null;
        }


        public void SetSetting(string key, string value)
        {
            settings[key] = value;
        }


        public void PrintSettings()
        {
            foreach (var kvp in settings)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
