using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourGui
{
    class ColourClass
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("hexvalue")]
        public string hexValue;

        [JsonProperty("r")]
        public int r;

        [JsonProperty("g")]
        public int g;

        [JsonProperty("b")]
        public int b;

        public ColourClass()
        {

        }
    }
}
