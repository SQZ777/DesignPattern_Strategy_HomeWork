using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.Mall.BE
{
    public class PostOffice : IAction
    {
        public double Caculate(DeliveryEntity deliveryItem)
        {
            var length = deliveryItem.ProductLength;
            var width = deliveryItem.ProductWidth;
            var height = deliveryItem.ProductHeight;
            var sizeFee = length * width * height * 0.00001 * 110;
            var weightFee = deliveryItem.ProductWeight * 10 + 80;

            return sizeFee > weightFee ? sizeFee : weightFee;
        }
    }

}
