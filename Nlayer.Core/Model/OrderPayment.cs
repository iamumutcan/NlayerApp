using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Core.Model
{
    public class OrderPayment:BaseEntity
    {
        public int OrderID { get; set; }
        public _OrderType OrderType { get; set; }
        public decimal Price { get; set; }
        public string Bank { get; set; }
    }
    public enum _OrderType
    {
        Havale = 0,
        CreditCart = 1,
        RcCoin = 2
    }
}
