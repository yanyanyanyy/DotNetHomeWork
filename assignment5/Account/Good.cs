using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class Good
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public Good(int id, string name, float price)
        {
            if(price < 0) { throw new ArgumentOutOfRangeException(nameof(price)); }
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public override bool Equals(object obj)
        {
            var goods = obj as Good;
            return goods != null && Id == goods.Id;
        }
        public override string ToString()
        {
            return $"商品信息:\aId:{Id}, Name:{Name}, Price:{Price}";
        }
    }
}
