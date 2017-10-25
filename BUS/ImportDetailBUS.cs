using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class ImportDetailBUS
    {
        DocumentManageDataContext db = new DocumentManageDataContext();
        public Object LoadData(int IDDocumnet)
        {
            var query = (from x in db.DetailDocuments
                         where x.IDDocument == IDDocumnet
                         select new { IDDocument = x.IDDocument, IDDetail = x.IDDetail, StyleNo = x.StyleNo, MaterialStyle = x.MaterialStyle, MaterialDetails = x.MaterialDetails, Unit = x.Unit, NumberRequest = x.NumberRequest, NumberReceived = x.NumberReceived, Price = x.Price, TotalAmount = x.TotalAmount });
            return query;
        }
        public void InsertData(int IDDocument, string StyleNo, string MaterialStyle, string MaterialDetails, string Unit, float NumberRequest, float NumberReceived, decimal price, decimal TotalAmount)
        {
            DetailDocument de = new DetailDocument();
            de.IDDocument = IDDocument;
            de.StyleNo = StyleNo;
            de.MaterialStyle = MaterialStyle;
            de.MaterialDetails = MaterialDetails;
            de.Unit = Unit;
            de.NumberRequest = NumberRequest;
            de.NumberReceived = NumberReceived;
            de.Price = price;
            de.TotalAmount = TotalAmount;
            db.DetailDocuments.InsertOnSubmit(de);
            db.SubmitChanges();
        }
        public void UpdateData(int IDDetail, string StyleNo, string MaterialStyle, string MaterialDetails, string Unit, float NumberRequest, float NumberReceived, decimal price, decimal TotalAmount)
        {
            DetailDocument de = db.DetailDocuments.Where(x => x.IDDetail == IDDetail).SingleOrDefault();
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
            DetailDocument de = db.DetailDocuments.Where(x => x.IDDetail == IDDetail).SingleOrDefault();
            db.DetailDocuments.DeleteOnSubmit(de);
            db.SubmitChanges();
        }
    }
}