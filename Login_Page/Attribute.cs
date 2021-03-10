using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_A
{
    public class Attribute
    {


        public string Name;
        public string Value;

        public Attribute(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public static List<Attribute> fromArray(string[] values)
        {
            List<Attribute> attributes = new List<Attribute>();
            for (int i = 0; i < values.Count(); i += 2)
            {
                attributes.Add(new Attribute(values[i], values[i + 1]));
            }
            return attributes;
        }
    }
}
