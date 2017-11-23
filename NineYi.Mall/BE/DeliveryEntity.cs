using System;

namespace NineYi.Mall.BE
{
    public interface ICaculate
    {
        double Caculate(DeliveryEntity deliveryItem);
    }

    /// <summary>
    /// 宅配資料
    /// </summary>
    public class DeliveryEntity
    {
        private ICaculate _caculate;

        /// <summary>
        /// 宅配類型
        /// </summary>
        public DeliveryTypeEnum DeliveryType { get; set; }

        /// <summary>
        /// 貨品高度
        /// </summary>
        public double ProductHeight { get; set; }

        /// <summary>
        /// 貨品長度
        /// </summary>
        public double ProductLength { get; set; }

        /// <summary>
        /// 貨品重量
        /// </summary>
        public double ProductWeight { get; set; }

        /// <summary>
        /// 貨品寬度
        /// </summary>
        public double ProductWidth { get; set; }

        public double Caculate(DeliveryEntity deliveryItem)
        {
            return _caculate.Caculate(deliveryItem);
        }

        public void SetDeliveryType(ICaculate iCaculate)
        {
            _caculate = iCaculate;
        }
    }

    public class KTJCaculate : ICaculate
    {
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
                return  size * 0.00001 * 120;
            }
        }
    }

    public class PostOfficeCaculate : ICaculate
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

    public class TcatCaculate : ICaculate
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