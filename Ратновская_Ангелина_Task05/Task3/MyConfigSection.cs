using System.Configuration;

namespace Task3
{
    public class MyConfigSection : ConfigurationSection
    {

        [ConfigurationProperty("Capacity")]
        public int DefaultCapacity
        {
            get { return (int)base["Capacity"]; }
            set { base["Capacity"] = value; }
        }
    }
}