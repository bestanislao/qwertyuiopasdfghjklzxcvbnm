using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;
using UNBUM.DAO.Workflow.Interfaces;

namespace UNBUM.BL.PaymentBL
{
    public class PaymentBL : IPaymentBL
    {
        IPaymentWorkflow _paymentWorkflow;
        public PaymentBL(IPaymentWorkflow paymentWorkflow)
        {
            _paymentWorkflow = paymentWorkflow;
        }

        public Payment GetPayment(int id)
        {
            return _paymentWorkflow.GetPayment(id);
        }

        public int InsertPayment(Payment payment)
        {
            payment.DateModified = DateTime.Now;
            return _paymentWorkflow.InsertPayment(payment);
        }
    }
}
