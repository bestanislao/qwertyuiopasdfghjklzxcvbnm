using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UNBUM.BL.Interfaces;
using UNBUM.BL.ServicesBL;
using UNBUM.CORE.Types;
using UNBUM.WEBSERVICE.Models;

namespace UNBUM.WEBSERVICE.Controllers
{
    public class ServiceController : ApiController
    {
        IServicesBL _servicesBL;
        ICustomerTransactionBL _customerTransactionBL;
        public ServiceController(IServicesBL servicesBL, ICustomerTransactionBL customerTransactionBL)
        {
            _servicesBL = servicesBL;
            _customerTransactionBL = customerTransactionBL;
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Service/GetSearchCategoryByServiceIDLatLongLang/")]
        public List<ServicesVM> GetSearchCategoryByServiceIDLatLongLang(int serviceTypeId, string lat, string lng)
        {
            return Mapper.Map<List<Services>, List<ServicesVM>>(_servicesBL.GetSearchCategoryByServiceIDLatLongLang(serviceTypeId, lat, lng));
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Service/GetSearchCategoryByServiceID/")]
        public List<ServicesVM> GetSearchCategoryByServiceID(int serviceTypeId)
        {
            return Mapper.Map<List<Services>, List<ServicesVM>>(_servicesBL.GetSearchCategoryByServiceID(serviceTypeId));
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Service/RequestService/")]
        public int RequestService([FromUri]RequestServiceVM requestServiceVM)
        {
            requestServiceVM.DateCreated = DateTime.Now;
            requestServiceVM.DateModified = DateTime.Now;
            var request = Mapper.Map<RequestServiceVM, RequestService>(requestServiceVM);
            return _servicesBL.InsertRequestService(request);
        }


        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Service/GetRequestService/")]
        public List<RequestServiceVM> GetRequestService(int serviceId, int status)
        {
            List<RequestServiceVM> result = Mapper.Map<List<RequestService>, List<RequestServiceVM>>(_servicesBL.GetRequestService(serviceId, status));
            foreach (var item in result)
            {
                CustomerTransaction ctr = _customerTransactionBL.GetCustomerTransactionById(result.First().CustomerTransactionId);
                item.TransactionReferenceNumber = ctr.ReferenceNumber;
            }
            return result;
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Service/UpdateRequestServiceStatus/")]
        public int UpdateRequestServiceStatus([FromUri]RequestServiceVM requestServiceVM)
        {
            //RequestService result = _servicesBL.GetRequestServiceById(requestServiceVM.Id);
            //RequestServiceVM mapResult = Mapper.Map<RequestService, RequestServiceVM>(result);
            //mapResult.ModifiedBy = requestServiceVM.ModifiedBy;
            ////mapResult.Status = 1;          

            return _servicesBL.UpdateRequestServiceStatus(Mapper.Map<RequestServiceVM, RequestService>(requestServiceVM));
        }









        [Route("Service/Get/{id}")]
        public IHttpActionResult Get(int id)
        {
            return Ok();
        }
    }
}
