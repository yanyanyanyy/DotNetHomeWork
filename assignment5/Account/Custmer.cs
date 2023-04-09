using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class Custmer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Custmer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"customerId:{Id}, CustomerName:{Name}";
        }

        public override bool Equals(object obj)
        {
            var customer = obj as Custmer;
            return customer != null && Id == customer.Id;
        }
    }
}
