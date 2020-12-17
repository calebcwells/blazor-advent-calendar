using BlazorAdventCalendar.Data;
using System.Collections.Generic;

namespace BlazorAdventCalendar.Services
{
    interface IPresentRepository
    {
        Present GetPresent(int id);
        IEnumerable<Present> GetPresents();
        string GetResource();
    }
}
