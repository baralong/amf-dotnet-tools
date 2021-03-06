using System;
using System.Linq;

namespace AMF.Tools.Core
{
    [Serializable]
    public class GeneratorParameter
    {
        private readonly string[] reservedWords = { "ref", "out", "in", "base", "long", "int", "short", "bool", "string", "decimal", "float", "double", "default" };
        private string name;

        public string Type { get; set; }

        public string Description { get; set; }

        public string Name
        {
            get
            {
                if (reservedWords.Contains(name))
                    return "Ip" + name;

                return name; 
            }

            set { name = value; }
        }
    }
}