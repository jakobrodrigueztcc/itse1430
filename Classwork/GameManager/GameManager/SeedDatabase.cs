using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    public static class SeedDatabase
    {
        public static void Seed (this IGameDatabase source)
        {
            //Collection initializer
            var games = new Game[]
                {
                    new Game() { Name = "TimeSplitters", Description = "2000", Price = 49.99M },
                    new Game() { Name = "Super Smash Bros. Ultimate", Description = "2018", Price = 59.99M },
                    new Game() { Name = "Steven Universe: Save the Light", Description = "2017", Price = 24.99M }
                };

            foreach (var game in games)
                source.Add(game);
        }
    }
}
