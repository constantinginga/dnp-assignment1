using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;

namespace Assignment1.Persistence
{
    public class AdultData : IAdultData
    {

        private FileContext fileContext;

        public AdultData()
        {
            fileContext = new FileContext();
        }

        public void Add(Adult adult)
        {
            int max = fileContext.Adults.Max(adult => adult.Id);
            adult.Id = ++max;
            fileContext.Adults.Add(adult);
            fileContext.SaveChanges();
        }

        public IList<Adult> GetAdults()
        {
            return fileContext.Adults;
        }

        public void RemoveAdult(Adult adult)
        {
            // Adult toRemove = fileContext.Adults.First(a => a.Id == adult.Id);
            fileContext.Adults.Remove(adult);
            fileContext.SaveChanges();
        }

        public void UpdateAdult(Adult adult)
        {
            Adult toUpdate = fileContext.Adults.First(a => a.Id == adult.Id);
            toUpdate.FirstName = adult.FirstName;
            toUpdate.LastName = adult.LastName;
            toUpdate.HairColor = adult.HairColor;
            toUpdate.EyeColor = adult.EyeColor;
            toUpdate.Age = adult.Age;
            toUpdate.Height = adult.Height;
            toUpdate.Weight = adult.Weight;
            toUpdate.Sex = adult.Sex;
            toUpdate.JobTitle = adult.JobTitle;
            fileContext.SaveChanges();
        }

        public Adult Get(int id)
        {
            return fileContext.Adults.FirstOrDefault(a => a.Id == id);
        }
    }
}
