using BlazorAdventCalendar.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorAdventCalendar.Services
{
    public class PresentRepository : IPresentRepository
    {
        private List<Present> presents;
        private List<Resource> resources;
        public PresentRepository()
        {
            presents = new List<Present> {
                new Present { Id = 1, Name = "Twenty-four days until Christmas", Url = "", Date = new DateTime(2020, 12, 1) },
                new Present { Id = 2, Name = "Twenty-three days until Christmas", Url = "", Date = new DateTime(2020, 12, 2) },
                new Present { Id = 3, Name = "Twenty-two days until Christmas", Url = "", Date = new DateTime(2020, 12, 3) },
                new Present { Id = 4, Name = "Twenty-one days until Christmas", Url = "", Date = new DateTime(2020, 12, 4) },
                new Present { Id = 5, Name = "Twenty days until Christmas", Url = "", Date = new DateTime(2020, 12, 5) },
                new Present { Id = 6, Name = "Nineteen days until Christmas", Url = "", Date = new DateTime(2020, 12, 6) },
                new Present { Id = 7, Name = "Eighteen days until Christmas", Url = "", Date = new DateTime(2020, 12, 7) },
                new Present { Id = 8, Name = "Seventeen days until Christmas", Url = "", Date = new DateTime(2020, 12, 8) },
                new Present { Id = 9, Name = "Sixteen days until Christmas", Url = "", Date = new DateTime(2020, 12, 9) },
                new Present { Id = 10, Name = "Fifteen days until Christmas", Url = "", Date = new DateTime(2020, 12, 10) },
                new Present { Id = 11, Name = "Fourteen days until Christmas", Url = "", Date = new DateTime(2020, 12, 11) },
                new Present { Id = 12, Name = "Thirteen days until Christmas", Url = "", Date = new DateTime(2020, 12, 12) },
                new Present { Id = 13, Name = "Twelve days until Christmas", Url = "", Date = new DateTime(2020, 12, 13) },
                new Present { Id = 14, Name = "Eleven days until Christmas", Url = "", Date = new DateTime(2020, 12, 14) },
                new Present { Id = 15, Name = "Ten days until Christmas", Url = "", Date = new DateTime(2020, 12, 15) },
                new Present { Id = 16, Name = "Nine days until Christmas", Url = "", Date = new DateTime(2020, 12, 16) },
                new Present { Id = 17, Name = "Eight days until Christmas", Url = "", Date = new DateTime(2020, 12, 17) },
                new Present { Id = 18, Name = "Seven days until Christmas", Url = "", Date = new DateTime(2020, 12, 18) },
                new Present { Id = 19, Name = "Six days until Christmas", Url = "", Date = new DateTime(2020, 12, 19) },
                new Present { Id = 20, Name = "Five days until Christmas", Url = "", Date = new DateTime(2020, 12, 20) },
                new Present { Id = 21, Name = "Four days until Christmas", Url = "", Date = new DateTime(2020, 12, 21) },
                new Present { Id = 22, Name = "Three days until Christmas", Url = "", Date = new DateTime(2020, 12, 22) },
                new Present { Id = 23, Name = "Two days until Christmas", Url = "", Date = new DateTime(2020, 12, 23) },
                new Present { Id = 24, Name = "One day until Christmas", Url = "", Date = new DateTime(2020, 12, 24) },
                new Present { Id = 25, Name = "Christmas Day", Url = "", Date = new DateTime(2020, 12, 25) }
            };

            resources = new List<Resource>
            {
                new Resource { Id = 1, Url = "https://dotnet.microsuntilt.com/learn/aspnet/blazor-tutorial/intro" },
                new Resource { Id = 2, Url = "https://jsakamoto.github.io/awesome-blazor-browser/" },
                new Resource { Id = 3, Url = "https://lupblazordemos.z13.web.core.windows.net/" },
                new Resource { Id = 4, Url = "https://github.com/aspnet/samples/tree/master/samples/aspnetcore/blazor/FlightFinder" },
                new Resource { Id = 5, Url = "https://github.com/dotnet-presentations/blazor-workshop/" },
                new Resource { Id = 6, Url = "https://blazorboilerplate.com/" },
                new Resource { Id = 7, Url = "https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-5.0" },
                new Resource { Id = 8, Url = "https://mudblazor.com/" },
                new Resource { Id = 9, Url = "https://en.wikipedia.org/wiki/Blazor" },
                new Resource { Id = 10, Url = "https://blazor.radzen.com/" }
            };
        }

        public Present GetPresent(int id)
        {
            return presents.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Present> GetPresents()
        {
            return presents.Where(p => p.Date <= DateTime.Today);
        }

        public string GetResource()
        {
            var randomizer = new Random();
            var randomNumber = randomizer.Next(1, 10);

            return resources.Where(r => r.Id == randomNumber).Select(r => r.Url).FirstOrDefault();
        }
    }
}
