using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
   public class ExportDetailBUS
    {
        DocumentManageDataContext db = new DocumentManageDataContext();
        public Object LoadData(int IDDocumnet)
        {
            var query = (from x in db.DetailDocumentExports
                         where x.IDDocument == IDDocumnet
                         select new { IDDocument = x.IDDocument, IDDetail = x.IDDetail, StyleNo = x.StyleNo, MaterialStyle = x.MaterialStyle, MaterialDetails = x.MaterialDetails, Unit = x.Unit, NumberRequest = x.NumberRequest, NumberReceived = x.NumberReceived, Price = x.Price, TotalAmount = x.TotalAmount });
            return query;
        }
        public void InsertData(int IDDocument, string StyleNo, string MaterialStyle, string MaterialDetails, string Unit, float NumberRequest, float NumberReceived, decimal price, decimal TotalAmount)
        {
            DetailDocumentExport de = new DetailDocumentExport();
            de.IDDocument = IDDocument;
            de.StyleNo = StyleNo;
            de.MaterialStyle = MaterialStyle;
            de.MaterialDetails = MaterialDetails;
            de.Unit = Unit;
            de.NumberRequest = NumberRequest;
            de.NumberReceived = NumberReceived;
            de.Price = price;
            de.TotalAmount = TotalAmount;
            db.DetailDocumentExports.InsertOnSubmit(de);
            db.SubmitChanges();
        }
        public void UpdateData(int IDDetail, string StyleNo, string MaterialStyle, string MaterialDetails, string Unit, float NumberRequest, float NumberReceived, decimal price, decimal TotalAmount)
        {
            DetailDocumentExport de = db.DetailDocumentExports.Where(x => x.IDDetail == IDDetail).SingleOrDefault();
            de.StyleNo = StyleNo;
            de.MaterialStyle = MaterialStyle;
            de.MaterialDetails = MaterialDetails;
            de.Unit = Unit;
            de.NumberRequest = NumberRequest;
            de.NumberReceived = NumberReceived;
            de.Price = price;
            de.TotalAmount = TotalAmount;
            db.SubmitChanges();
        }
        public void DeleteData(int IDDetail)
        {
            DetailDocumentExport de = db.DetailDocumentExports.Where(x => x.IDDetail == IDDetail).SingleOrDefault();
            db.DetailDocumentExports.DeleteOnSubmit(de);
            db.SubmitChanges();
        }
    }
}
