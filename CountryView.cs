using System;
namespace mvclab
{
    public class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }


        public void Display(Country c)
        {
            Console.WriteLine($"{c.Name} is a country in {c.Continent}. Their flag colors are:");
            for (int i =0; i < c.Colors.Count; i++)
            {
                Console.WriteLine(c.Colors[i]);
            }
        }
    }
}
