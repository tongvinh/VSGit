using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
   public class DepartmentBUS
    {
        DocumentManageDataContext db = new DocumentManageDataContext();
        public Object LoadData()
        {
            var query = (from x in db.Departments
                         select new { IDDepart = x.IDDepart, DepartName = x.DepartName, Description = x.Description });
            return query;
        }
        public void InsertData(string IDDepart,string DepartName,string Description)
        {
            Department d = new Department();
            d.IDDepart = IDDepart;
            d.DepartName = DepartName;
            d.Description = Description;
            db.Departments.InsertOnSubmit(d);
            db.SubmitChanges();
        }
        public void DeleteDate(string IDDepart)
        {
            Department d = db.Departments.Where(x => x.IDDepart == IDDepart).SingleOrDefault();
            db.Departments.DeleteOnSubmit(d);
            db.SubmitChanges();
        }
        public void UpdateData(string IDDepart,string DepartName,string Description)
        {
            Department d = db.Departments.Where(x => x.IDDepart == IDDepart).SingleOrDefault();
            d.DepartName = DepartName;
            d.Description = Description;
            db.SubmitChanges();
        }
    }
}
