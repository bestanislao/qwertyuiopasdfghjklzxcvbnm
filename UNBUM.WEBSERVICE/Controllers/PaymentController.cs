using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UNBUM.BL.PaymentBL;
using UNBUM.CORE.Types;
using UNBUM.WEBSERVICE.Models;

namespace UNBUM.WEBSERVICE.Controllers
{
    public class PaymentController : ApiController
    {
        IPaymentBL _paymentBL;
        public PaymentController(IPaymentBL paymentBL)
        {
            _paymentBL = paymentBL;
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Payment/InsertPayment/")]
        public PaymentVM InsertPayment([FromUri]PaymentVM paymentVM)
        {
            int id = _paymentBL.InsertPayment(Mapper.Map<PaymentVM, Payment>(paymentVM));
            Payment result = _paymentBL.GetPayment(id);
            return Mapper.Map<Payment, PaymentVM>(result);             
        }

    }
}
