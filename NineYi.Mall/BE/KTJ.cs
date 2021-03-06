﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.Mall.BE
{
    /// <summary>
    /// 大榮貨運
    /// </summary>
    public class KTJ : IAction
    {
        /// <summary>
        /// 大榮的計算
        /// </summary>
        /// <param name="deliveryItem"></param>
        /// <returns></returns>
        public double Caculate(DeliveryEntity deliveryItem)
        {
            var length = deliveryItem.ProductLength;
            var width = deliveryItem.ProductWidth;
            var height = deliveryItem.ProductHeight;

            var size = length * width * height;

            if (length > 50 || width > 50 || height > 50)
            {
                return size * 0.00001 * 110 + 50;
            }
            else
            {
                return size * 0.00001 * 120;
            }
        }
    }
}
