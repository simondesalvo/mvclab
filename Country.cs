using System;
using System.Collections.Generic;

namespace mvclab
{
    public class Country
    {
        public string Name { get; set; }
        public ContinentNum Continent { get; set; }
        public List<string> Colors { get; set; }

        public Country() { }
        public Country (string Name, ContinentNum Continent, List<string> Colors)
        {
            this.Name = Name;
            this.Continent = Continent;
            this.Colors = Colors;
        }
    }
}
