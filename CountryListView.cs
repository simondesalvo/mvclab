using System;
using System.Collections.Generic;
namespace mvclab
{
    public class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> Countries)
        {
            this.Countries = Countries;
        }

        public void DisplayList()
        {
            for (int i =0; i < Countries.Count; i++)
            {
                Console.WriteLine(i + " " + Countries[i].Name);
            }
        }
        
    }
}
