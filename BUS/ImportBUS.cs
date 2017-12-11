using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
  public class ImportBUS
    {
        DocumentManageDataContext db = new DocumentManageDataContext();
        public object loaddata()
        {
            var query = (from x in db.Documents
                         join e in db.Employees on x.IDEmployee equals e.IDEmployee
                         select new
                                    {
                                        IDDocument = x.IDDocument,
                                        DocumentNumber = x.DocumentNumber,
                                        NoTK = x.NoTK,
                                        CoTK = x.CoTK,
                                        Date = x.Date,
                                        FromStore = x.FromStore,
                                        ToStore = x.ToStore,
                                        Description = x.Description,
                                        IDEmployee = x.IDEmployee,
                                        EmployeeName = e.EmployeeName,
                                        PartSent = x.PartSent,
                                        PersonSent = x.PersonSent,
                                        SoHD = x.SoHD,
                                        SoPO = x.SoPO,
                                        HTThanhToan = x.HTThanhToan,
                                        PTVanChuyen = x.PTVanChuyen,
                                        DVTien = x.DVTien
                                    });
            return query;
        }
        public Object getDataDepart(int IDEmployee)
        {
            var query = (from x in db.Departments
                        where x.IDDepart!=((from e in db.Employees
                                           where e.IDEmployee==IDEmployee
                                           select e.IDDepart).FirstOrDefault())
                         select new { IDDepart = x.IDDepart, DepartName = x.DepartName }).ToList();
            return query;
        }
        public string getFromStore(int IDEmployee)
        {
            //var query = db.Departments.Take(1).Select(x => x.IDDepart).FirstOrDefault();
            var query = (from x in db.Departments
                        where x.IDDepart==((from e in db.Employees
                                            where e.IDEmployee==IDEmployee
                                            select e.IDDepart).FirstOrDefault())
                         select new { IDDepart = x.IDDepart }).Take(1).Select(x => x.IDDepart).FirstOrDefault();
            return query;
        }

        public void InsertData(
            string DocumentNumber,
            string NoTK,
            string CoTK,
            DateTime Date,
            string FromStore,
            string ToStore,
            string Description,
            int IDEmployee,
            string PartSent,
            string PersonSent,
            string SoHD,
            string SoPO,
            string HTThanhToan,
            string PTVanChuyen,
            string DVtien)
        {
            Document dc = new Document();
            dc.DocumentNumber = DocumentNumber;
            dc.NoTK = NoTK;
            dc.CoTK = CoTK;
            dc.Date = Date;
            dc.FromStore = FromStore;
            dc.ToStore = ToStore;
            dc.Description = Description;
            dc.IDEmployee = IDEmployee;
            dc.PartSent = PartSent;
            dc.PersonSent = PersonSent;
            dc.SoHD = SoHD;
            dc.SoPO = SoPO;
            dc.HTThanhToan = HTThanhToan;
            dc.PTVanChuyen = PTVanChuyen;
            dc.DVTien = DVtien;
            db.Documents.InsertOnSubmit(dc);
            db.SubmitChanges();
        }

        public void UpdateData(
            int IDDocument,
            string DocumentNumber,
            string NoTK,
            string CoTK,
            DateTime Date,
            string ToStore,
            string Description,
            string PartSent,
            string PersonSent,
            string SoHD,
            string SoPO,
            string HTThanhToan,
            string PTVanChuyen,
            string DVtien)
        {
            Document dc = db.Documents.Where(x => x.IDDocument == IDDocument).SingleOrDefault();
            dc.DocumentNumber = DocumentNumber;
            dc.NoTK = NoTK;
            dc.CoTK = CoTK;
            dc.Date = Date;
            dc.ToStore = ToStore;
            dc.Description = Description;
            dc.PartSent = PartSent;
            dc.PersonSent = PersonSent;
            dc.SoHD = SoHD;
            dc.SoPO = SoPO;
            dc.HTThanhToan = HTThanhToan;
            dc.PTVanChuyen = PTVanChuyen;
            dc.DVTien = DVtien;
            db.SubmitChanges();
        }

        public void DeleteData(int IDDocument)
        {
            Document dc = db.Documents.Where(x => x.IDDocument == IDDocument).SingleOrDefault();
            db.Documents.DeleteOnSubmit(dc);
            db.SubmitChanges();
        }
        public int GetLastIdentity()
        {
            var query = db.Documents.OrderByDescending(x=>x.IDDocument).Take(1).Select(x=>x.IDDocument).FirstOrDefault();
            return query;
        }
    }
}
