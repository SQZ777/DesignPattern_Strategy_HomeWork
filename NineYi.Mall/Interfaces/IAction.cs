using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.Mall.BE
{
    /// <summary>
    /// 動作
    /// </summary>
    public interface IAction
    {
        /// <summary>
        /// 計算介面
        /// </summary>
        /// <param name="deliveryItem"></param>
        /// <returns></returns>
        double Caculate(DeliveryEntity deliveryItem);
    }
}
