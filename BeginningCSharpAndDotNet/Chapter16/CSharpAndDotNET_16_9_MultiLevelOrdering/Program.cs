﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAndDotNET_16_9_MultiLevelOrdering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer> {
                new Customer { ID="A", City="New York", Country="USA", Region="North America", Sales=9999},
                new Customer { ID="B", City="Mumbai", Country="India", Region="Asia", Sales=8888},
                new Customer { ID="C", City="Karachi", Country="Pakistan", Region="Asia", Sales=7777},
                new Customer { ID="D", City="Delhi", Country="India", Region="Asia", Sales=6666},
                new Customer { ID="E", City="São Paulo", Country="Brazil",  Region="South America", Sales=5555 },
                new Customer { ID="F", City="Moscow", Country="Russia", Region="Europe", Sales=4444 },
                new Customer { ID="G", City="Seoul", Country="Korea", Region="Asia", Sales=3333 },
                new Customer { ID="H", City="Istanbul", Country="Turkey", Region="Asia", Sales=2222 },
                new Customer { ID="I", City="Shanghai", Country="China", Region="Asia", Sales=1111 },
                new Customer { ID="J", City="Lagos", Country="Nigeria", Region="Africa", Sales=1000 },
                new Customer { ID="K", City="Mexico City", Country="Mexico", Region="North America", Sales=2000 },
                new Customer { ID="L", City="Jakarta", Country="Indonesia", Region="Asia", Sales=3000 },
                new Customer { ID="M", City="Tokyo", Country="Japan", Region="Asia", Sales=4000 },
                new Customer { ID="N", City="Los Angeles", Country="USA", Region="North America", Sales=5000 },
                new Customer { ID="O", City="Cairo", Country="Egypt", Region="Africa", Sales=6000 },
                new Customer { ID="P", City="Tehran", Country="Iran", Region="Asia", Sales=7000 },
                new Customer { ID="Q", City="London", Country="UK", Region="Europe", Sales=8000 },
                new Customer { ID="R", City="Beijing", Country="China", Region="Asia", Sales=9000 },
                new Customer { ID="S", City="Bogotá", Country="Colombia", Region="South America", Sales=1001 },
                new Customer { ID="T", City="Lima", Country="Peru", Region="South America", Sales=2002 }
            };

            var queryResult =
                from c in customers
                orderby c.Region, c.Country, c.City
                select new { c.ID, c.Region, c.Country, c.City };

            var queryResult1 = customers
                .OrderBy(c => c.Region)
                .ThenBy(c => c.Country)
                .ThenBy(c => c.City)
                .Select(c => new { c.ID, c.Region, c.Country, c.City });

            foreach (var item in queryResult)
            {
                Console.WriteLine(item);
            }

            var queryResult2 =
                from c in customers
                group c by c.Region into cg
                select new { TotalSales = cg.Sum(c => c.Sales), Region = cg.Key };

            var orderedResults =
                from cg in queryResult2
                orderby cg.TotalSales descending
                select cg;

            Console.WriteLine("Total\t: By\nSales\t: Region\n-----\t------");
            foreach (var item in orderedResults)
            {
                Console.WriteLine($"{item.TotalSales}\t: {item.Region}");
            }
        }
    }
}
