using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
   public class ReportBUS
    {
        DocumentManageDataContext db = new DocumentManageDataContext();
        public IEnumerable<DetailDocument> getDetails(int IDDocument)
        {
            var query = (from x in db.DetailDocuments
                         where x.IDDocument == IDDocument
                         select x).ToList();
            return query;
        }
        public IEnumerable<DetailDocumentExport> getDetailExports(int IDDocument)
        {
            var query = (from x in db.DetailDocumentExports
                         where x.IDDocument == IDDocument
                         select x).ToList();
            return query;
        }
        public IEnumerable<InforDocument> getInfo(int IDDocument)
        {
            var query = (from x in db.InforDocuments
                         where x.IDDocument == IDDocument
                         select x).ToList();
            return query;
        }
        public IEnumerable<InforDocumentExport> getInfoExport(int IDDocument)
        {
            var query = (from x in db.InforDocumentExports
                         where x.IDDocument == IDDocument
                         select x).ToList();
            return query;
        }
        //public string ImagePerson1(int IDDocument)
        //{
        //    var query = db.Documents.Where(x => x.IDDocument == IDDocument).Select(x => x.Person1).SingleOrDefault();
        //    return query;
        //}
    }
}
