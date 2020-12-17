using BlazorAdventCalendar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdventCalendar.Services
{
    interface IPresentRepository
    {
        Present GetPresent(int id);
        IEnumerable<Present> GetPresents();
    }
}
