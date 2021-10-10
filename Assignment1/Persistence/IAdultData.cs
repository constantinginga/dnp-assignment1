using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;

namespace Assignment1.Persistence
{
    interface IAdultData
    {
        void Add(Adult adult);
        IList<Adult> GetAdults();

        void RemoveAdult(Adult adult);
        void UpdateAdult(Adult adult);

        Adult Get(int id);
    }
}
