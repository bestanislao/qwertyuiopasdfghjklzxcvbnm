using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;

namespace UNBUM.CORE.Translator
{
    public class RequestServiceTranslator
    {
        public static RequestService UpdateRequestServiceStatusTranslator(RequestService update, RequestService fromDB)
        {
            RequestService forUpdate = new RequestService();
            forUpdate.CustomerTransactionId = fromDB.CustomerTransactionId;
            forUpdate.CustomerLocation = fromDB.CustomerLocation;
            forUpdate.Id = fromDB.Id;
            forUpdate.DateCreated = fromDB.DateCreated;
            forUpdate.Status = update.Status;
            forUpdate.DateModified = DateTime.Now;
            forUpdate.ModifiedBy = update.ModifiedBy;
            forUpdate.ServiceType = fromDB.ServiceType;
            return forUpdate;          
        }
    }
}
