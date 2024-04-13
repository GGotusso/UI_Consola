using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Customer
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public Customer(int code, string name)
        {
            ID = Guid.NewGuid();
            Code = code;
            Name = name;

        }



    }
}
