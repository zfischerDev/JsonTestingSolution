using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using zfJsonTestLibraries.Objects;
namespace zfJsonTestLibraries
{
    public class jsonTestLib
    {
        public string SerializeJsonToString(PolarisAccountHolder accountHolder)
        {
            string jasonString = JsonSerializer.Serialize<PolarisAccountHolder>(accountHolder);
            return jasonString;
        }

        public string SerializeFormattedJsonToString(PolarisAccountHolder accountHolder)
        {
            //Can also use var here, I just chose to explicitly declare it
            JsonSerializerOptions jsonOptions = new JsonSerializerOptions
            {
                //allows text to be indented to look nicer
                WriteIndented = true
            };
            string jasonString = JsonSerializer.Serialize<PolarisAccountHolder>(accountHolder,jsonOptions);
            return jasonString;
        }

        public PolarisAccountHolder DeserializeJsonFromString(string accountHolderString)
        {
            PolarisAccountHolder accountHolder = JsonSerializer.Deserialize<PolarisAccountHolder>(accountHolderString);

            return accountHolder;
        }

    }
}
