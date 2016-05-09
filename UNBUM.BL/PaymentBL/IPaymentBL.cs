using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;

namespace UNBUM.BL.PaymentBL
{
    public interface IPaymentBL
    {
        int InsertPayment(Payment payment);
        Payment GetPayment(int id);
    }
}
