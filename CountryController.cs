using System;
using System.Collections.Generic;
namespace mvclab
{
    public class CountryController
    {
        List<Country> CountryDB = new List<Country>
        {
            new Country("Italy", ContinentNum.Europe, new List<string>(){"Red", "Green", "White" }),
            new Country("United States", ContinentNum.NorthAmerica, new List<string>(){"Red", "White", "Blue"}),
            new Country("Indonesia", ContinentNum.Asia, new List<string>(){"Red", "White"}),
            new Country("Argentina", ContinentNum.SouthAmerica, new List<string>(){"Blue", "White", "Gold"}),
            new Country("Egypt", ContinentNum.Africa, new List<string>(){"Red","White","Gold" }),
        };

        public void CountryAction (Country c)
        {
            CountryView v = new CountryView(c);
            v.Display(c);
        }

        public void WelcomeAction()
        {
            bool programStart = true;
            while (programStart)
            {
                CountryListView clv = new CountryListView(CountryDB);
                Console.WriteLine("Hey there! Pick a country from the following list: (use the display number)");
                clv.DisplayList();
                string input = Console.ReadLine();
                int numInput;
                int.TryParse(input, out numInput);

                    if (numInput >=0 && numInput < CountryDB.Count)
                    {
                        CountryView cv = new CountryView(CountryDB[numInput]);
                    cv.Display(CountryDB[numInput]);
                        Console.WriteLine("Want to learn about another country? y/n");
                        string cont = Console.ReadLine();
                        cont.ToLower();
                        if (cont == "y" || cont == "yes")
                        {
                            Console.WriteLine("Cool beans!");
                            programStart = true;
                        }
                        else
                        {
                            Console.WriteLine("Ok cool, smell ya later");
                            programStart = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Whuh oh, not a number, try again.");
                        programStart = true;
                    }
            }
        }

        
    }
}
