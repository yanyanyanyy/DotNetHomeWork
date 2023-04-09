using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class OrderDetail
    {
        public Good Good { get; set; }
        public int Num { get; set; }
        public OrderDetail(Good good, int num)
        {
            if(Num < 0) { throw new ArgumentOutOfRangeException(nameof(Num)); }
            this.Good = good;
            this.Num = num;
        }
        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetail;
            return detail != null && Good.Equals(detail.Good);
        }
        public override string ToString()
        {
            return $"订单明细:\n\t{Good}\n\t数目：{Num}\n\t总价：{Good.Price*Num}";
        }
    }
}
