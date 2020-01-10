using System;
using System.Collections.Generic;
using System.Linq;

namespace PlSight.BegCShCollections.ReadAllCountries {
    class Program {
        static void Main(string[] args) {
            string filePath = @"C:\Temp\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();

            var filteredCountries = countries.Where(x => !x.Name.Contains(','));
            var filteredCountries2 = from country in countries
                                     where !country.Name.Contains(',')
                                     select country;
            // mixing the different LINQ syntaxes will make some people very upset
            // (like we have done here!)

            foreach (Country country in filteredCountries.Take(20)) {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            foreach (Country country in filteredCountries2.Take(20)) {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
