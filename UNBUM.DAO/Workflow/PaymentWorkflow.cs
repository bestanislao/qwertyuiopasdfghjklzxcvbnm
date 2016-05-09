using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;
using UNBUM.DAO.Repositories.Interfaces;
using UNBUM.DAO.Workflow.Interfaces;

namespace UNBUM.DAO.Workflow
{
    public class PaymentWorkflow : IPaymentWorkflow
    {
        IPaymentRepository _paymentRepository;
        IUnitOfWork _unitOfWork;
        public PaymentWorkflow(IPaymentRepository paymentRepository
                               , IUnitOfWork unitOfWork)
        {
            _paymentRepository = paymentRepository;
            _unitOfWork = unitOfWork;
        }

        public Payment GetPayment(int id)
        {
            return _paymentRepository.GetById(id);
        }

        public int InsertPayment(Payment payment)
        {
            _paymentRepository.Insert(payment);
            _unitOfWork.Save();
            return payment.Id;
        }
    }
}
