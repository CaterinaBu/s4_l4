using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace s4_l4
{
    public class DiaryProduct : Product
    {
        public List<DateTime> date = new List<DateTime>(2);

        public DiaryProduct(string name, decimal vendorCode, decimal price, DateTime date0, DateTime date1)
            : base(name, vendorCode, price)
        {
            date.Add(date0);
            date.Add(date1);
        }
    }
}