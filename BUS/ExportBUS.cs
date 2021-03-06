﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
   public class ExportBUS
    {
        DocumentManageDataContext db = new DocumentManageDataContext();
        public object loaddata()
        {
            var query = (from x in db.DocumentExports
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
                                        PartReceived = x.PartReceived,
                                        PersonReceived = x.PersonReceived,
                                        SoHopDong=x.SoHopDong,
                                        SoHoaDon=x.SoHoaDon
                                    });
            return query;
        }
      /*  public Object getDataDepart(int IDEmployee)
        {
            var query = (from x in db.Departments
                         where x.IDDepart != ((from e in db.Employees
                                               where e.IDEmployee == IDEmployee
                                               select e.IDDepart).FirstOrDefault())
                         select new { IDDepart = x.IDDepart, DepartName = x.DepartName }).ToList();
            return query;
        }*/
        public Object getDataDepart(int IDEmployee)
        {
            var query = (from x in db.Departments
                         where x.HD==true
                         select new { IDDepart = x.IDDepart, DepartName = x.DepartName }).ToList();
            return query;
        }
        public Object getFromStoreDepart()
        {
            var query = (from x in db.Departments
                         where x.HD == true
                         select new { IDDepart = x.IDDepart, DepartName = x.DepartName }).ToList();
            return query;
        }
        public string getFromStore(int IDEmployee)
        {
            //var query = db.Departments.Take(1).Select(x => x.IDDepart).FirstOrDefault();
            var query = (from x in db.Departments
                         where x.IDDepart == ((from e in db.Employees
                                               where e.IDEmployee == IDEmployee
                                               select e.IDDepart).FirstOrDefault())
                         select new { IDDepart = x.IDDepart }).Take(1).Select(x => x.IDDepart).FirstOrDefault();
            return query;
        }
        public void InsertData(string DocumentNumber, string NoTK, string CoTK, DateTime Date, string FromStore, string ToStore, string Description, int IDEmployee,string PartReceived,string PersonReceived,string SoHopDong,string SoHoaDon)
        {
            DocumentExport dc = new DocumentExport();
            dc.DocumentNumber = DocumentNumber;
            dc.NoTK = NoTK;
            dc.CoTK = CoTK;
            dc.Date = Date;
            dc.FromStore = FromStore;
            dc.ToStore = ToStore;
            dc.Description = Description;
            dc.IDEmployee = IDEmployee;
            dc.PartReceived = PartReceived;
            dc.PersonReceived = PersonReceived;
            dc.SoHopDong = SoHopDong;
            dc.SoHoaDon = SoHoaDon;
            db.DocumentExports.InsertOnSubmit(dc);
            db.SubmitChanges();
        }
        public void UpdateData(int IDDocument,string DocumentNumber, string NoTK, string CoTK, DateTime Date,string FromStore, string ToStore, string Description, string PartReceived, string PersonReceived,string SoHopDong,string SoHoaDon)
        {
            DocumentExport dc = db.DocumentExports.Where(x => x.IDDocument == IDDocument).SingleOrDefault();
            dc.DocumentNumber = DocumentNumber;
            dc.NoTK = NoTK;
            dc.CoTK = CoTK;
            dc.Date = Date;
            dc.FromStore = FromStore;
            dc.ToStore = ToStore;
            dc.Description = Description;
            dc.PartReceived = PartReceived;
            dc.PersonReceived = PersonReceived;
            dc.SoHopDong = SoHopDong;
            dc.SoHoaDon = SoHoaDon;
            db.SubmitChanges();
        }
        public void DeleteData(int IDDocument)
        {
            DocumentExport dc = db.DocumentExports.Where(x => x.IDDocument == IDDocument).SingleOrDefault();
            db.DocumentExports.DeleteOnSubmit(dc);
            db.SubmitChanges();
        }
        public int GetLastIdentity()
        {
            var query = db.DocumentExports.OrderByDescending(x => x.IDDocument).Take(1).Select(x => x.IDDocument).FirstOrDefault();
            return query;
        }
    }
}
