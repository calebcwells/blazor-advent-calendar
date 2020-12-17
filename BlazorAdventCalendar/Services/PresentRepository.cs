using BlazorAdventCalendar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdventCalendar.Services
{
    public class PresentRepository : IPresentRepository
    {
        private List<Present> presents;
        public PresentRepository()
        {
            presents = new List<Present> { 
                new Present { Id = 1, Name = "First day of Christmas", Url = "https://dotnet.microsoft.com/learn/aspnet/blazor-tutorial/intro", Date = new DateTime(2020, 12, 1) },
                new Present { Id = 2, Name = "Second day of Christmas", Url = "https://dotnet.microsoft.com/learn/aspnet/blazor-tutorial/intro", Date = new DateTime(2020, 12, 2) },
                new Present { Id = 3, Name = "Third day of Christmas", Url = "https://dotnet.microsoft.com/learn/aspnet/blazor-tutorial/intro", Date = new DateTime(2020, 12, 3) },
            };
        }

        public Present GetPresent(int id)
        {
            return presents.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Present> GetPresents()
        {
            return presents;
        }
    }
}
