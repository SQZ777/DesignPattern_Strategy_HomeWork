﻿using System;

namespace NineYi.Mall.BE
{


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

        /// <summary>
        /// 計算
        /// </summary>
        /// <param name="deliveryItem"></param>
        /// <returns></returns>
        public double Caculate(DeliveryEntity deliveryItem)
        {
            return _action.Caculate(deliveryItem);
        }

        /// <summary>
        /// 設定動作類型
        /// </summary>
        /// <param name="iAction"></param>
        public void SetDeliveryType(IAction iAction)
        {
            _action = iAction;
        }
    }




   
}