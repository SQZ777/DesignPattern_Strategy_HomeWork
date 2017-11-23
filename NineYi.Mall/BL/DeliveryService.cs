using System;
using NineYi.Mall.BE;

namespace NineYi.Mall.BL
{
    /// <summary>
    /// 宅配Service
    /// </summary>
    public class DeliveryService
    {
        /// <summary>
        /// 計算運費
        /// </summary>
        /// <param name="deliveryItem">宅配資料</param>
        /// <returns>運費</returns>
        public double Calculate(DeliveryEntity deliveryItem)
        {
            if (deliveryItem == null)
            {
                throw new ArgumentException("請檢查 deliveryItem 參數");
            }

            if (deliveryItem.DeliveryType == DeliveryTypeEnum.TCat)
            {
                deliveryItem.SetDeliveryType(new Tcat());
                return deliveryItem.Caculate(deliveryItem);
            }
            else if (deliveryItem.DeliveryType == DeliveryTypeEnum.KTJ)
            {
                deliveryItem.SetDeliveryType(new KTJ());
                return deliveryItem.Caculate(deliveryItem);
            }
            else if (deliveryItem.DeliveryType == DeliveryTypeEnum.PostOffice)
            {
                deliveryItem.SetDeliveryType(new PostOffice());
                return deliveryItem.Caculate(deliveryItem);
            }
            else
            {
                throw new ArgumentException("請檢查 deliveryItem.DeliveryType 參數");
            }
        }
    }
}