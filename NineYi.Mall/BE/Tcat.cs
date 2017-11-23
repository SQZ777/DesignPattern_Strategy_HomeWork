using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.Mall.BE
{
    public class Tcat : IAction
    {
        public double Caculate(DeliveryEntity deliveryItem)
        {
            if (deliveryItem.ProductWeight > 20)
            {
                return 400d;
            }
            else
            {
                return 100 + deliveryItem.ProductWeight * 10;
            }
        }
    }
}
