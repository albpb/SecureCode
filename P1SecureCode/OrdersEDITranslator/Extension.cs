using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEDITranslator
{
    public static class Extension<T>
    {
        public static T getOrderData(string propertyName, string propertyValue, List<T> list)
        {
            return list.Where(x => x.GetType().GetProperty(propertyName).GetValue(x, null)
            .Equals(propertyValue)).FirstOrDefault();
        }

    }
}
