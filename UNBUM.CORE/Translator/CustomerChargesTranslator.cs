using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;

namespace UNBUM.CORE.Translator
{
    public class CustomerChargesTranslator
    {
        public static CustomerCharges UpdateCustomerChargesTranslator(CustomerCharges update, CustomerCharges fromDB)
        {
            CustomerCharges forUpdate = new CustomerCharges();
            forUpdate.Id = fromDB.Id;
            forUpdate.CustomerTransactionId = fromDB.CustomerTransactionId;
            forUpdate.ServiceTypeId = update.ServiceTypeId == 0 ? fromDB.ServiceTypeId : update.ServiceTypeId;
            forUpdate.ItemName = String.IsNullOrWhiteSpace(update.ItemName) ? fromDB.ItemName : update.ItemName;
            forUpdate.ItemDescription = String.IsNullOrWhiteSpace(update.ItemDescription) ? fromDB.ItemDescription : update.ItemDescription;
            forUpdate.ItemPrice = fromDB.ItemPrice;
            forUpdate.TotalAmount = fromDB.TotalAmount;
            forUpdate.Destination = String.IsNullOrWhiteSpace(update.Destination) ? fromDB.Destination : update.Destination;
            forUpdate.ComputedDistance = String.IsNullOrWhiteSpace(update.ComputedDistance) ? fromDB.ComputedDistance : update.ComputedDistance;
            //forUpdate.Change = fromDB.Change;
            //forUpdate.PromoCode = String.IsNullOrWhiteSpace(update.PromoCode) ? fromDB.PromoCode : update.PromoCode;
            //forUpdate.PictureSelfieFilePath = String.IsNullOrWhiteSpace(update.PictureSelfieFilePath) ? fromDB.PictureSelfieFilePath : update.PictureSelfieFilePath;
            //forUpdate.PictureSelfieFilePath = String.IsNullOrWhiteSpace(update.PictureSelfieFilePath) ? fromDB.PictureSelfieFilePath : update.PictureSelfieFilePath;
            return forUpdate;
        }
    }
}
