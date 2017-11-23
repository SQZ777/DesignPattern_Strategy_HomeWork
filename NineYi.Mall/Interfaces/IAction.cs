using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.Mall.BE
{
    public interface IAction
    {
        double Caculate(DeliveryEntity deliveryItem);
    }
}
