using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.Mall.BE
{
    /// <summary>
    /// 郵局
    /// </summary>
    public class PostOffice : IAction
    {
        /// <summary>
        /// 郵局的計算
        /// </summary>
        /// <param name="deliveryItem"></param>
        /// <returns></returns>
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
