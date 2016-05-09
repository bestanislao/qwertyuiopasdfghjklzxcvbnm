using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;

namespace UNBUM.DAO.Workflow.Interfaces
{
    public interface IPaymentWorkflow
    {
        int InsertPayment(Payment payment);
        Payment GetPayment(int id);
    }
}
