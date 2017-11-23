using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.Mall.BE
{
    /// <summary>
    /// 黑貓
    /// </summary>
    public class Tcat : IAction

    {
        /// <summary>
        /// 黑貓的計算方式
        /// </summary>
        /// <param name="deliveryItem"></param>
        /// <returns></returns>
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
