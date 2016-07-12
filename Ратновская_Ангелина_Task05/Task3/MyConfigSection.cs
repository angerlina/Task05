using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace Task3
{
    public class MyConfigSection : ConfigurationSection
    {
        

        [ConfigurationProperty("DefaultCapacity")]
        public int DefaultCapacity
        {
            get { return ((int)(base["Capacity"])); }
        }
    }
}  