using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public Customer()
        {
        }
        public Customer(int Id)
        {
            this.Id = Id;
            
        }
        public Customer(int Id,string Name)
        {
            this.Id = Id;
            this.Name = Name;
            
        }
    }
}
