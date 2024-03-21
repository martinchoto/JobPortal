using Castle.Core.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = JobPortal.Core.Data.Models.Type;

namespace JobPortal.Data
{
    public class SeedData
    {
        public IEnumerable<Type> SeedTypes()
        {
            Type[] types = new Type[] {
            new Type(){ Id = 1,Name = "Technical"},
             new Type(){ Id = 2, Name = "Business"},
             new Type(){ Id = 3, Name = "Healthcare"},
             new Type(){  Id = 4, Name= "Creative"},
             new Type(){ Id = 5, Name = "Education"},
             new Type() {Id = 6, Name = "Customer Service"}
            };
            return types;
        }
    }
}