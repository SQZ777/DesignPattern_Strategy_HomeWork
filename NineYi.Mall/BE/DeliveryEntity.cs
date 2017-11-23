using System;

namespace NineYi.Mall.BE
{
    public interface IAction
    {
        double Caculate(DeliveryEntity deliveryItem);
    }

    /// <summary>
    /// 宅配資料
    /// </summary>
    public class DeliveryEntity
    {

        /// <summary>
        /// 動作介面
        /// </summary>
        private IAction _action;

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
            return _action.Caculate(deliveryItem);
        }

        public void SetDeliveryType(IAction iAction)
        {
            _action = iAction;
        }
    }




   
}