using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
  public  class EmployeeBUS
    {
        DocumentManageDataContext db = new DocumentManageDataContext();
        public Object LoadData()
        {
            var query = (from x in db.Employees
                         join d in db.Departments on x.IDDepart equals d.IDDepart
                         select new { IDEmployee = x.IDEmployee, EmployeeName = x.EmployeeName, DepartName = d.DepartName,IDDepart=d.IDDepart });
            return query;
        }
        public IEnumerable<Department> LoadDepartment()
        {
            var query = (from x in db.Departments
                         select x).ToList();
            return query;
        }
        public void InsertData(int IDEmployee, string EmployeeName, string IDDepart)
        {
            Employee e = new Employee();
            e.IDEmployee = IDEmployee;
            e.EmployeeName = EmployeeName;
            e.IDDepart = IDDepart;
            db.Employees.InsertOnSubmit(e);
            db.SubmitChanges();
        }
        public void DeleteDate(int IDEmployee)
        {
            Employee d = db.Employees.Where(x => x.IDEmployee == IDEmployee).SingleOrDefault();
            db.Employees.DeleteOnSubmit(d);
            db.SubmitChanges();
        }
        public void UpdateData(int IDEmployee, string EmployeeName, string IDDepart)
        {
            Employee d = db.Employees.Where(x => x.IDEmployee == IDEmployee).SingleOrDefault();
            d.EmployeeName = EmployeeName;
            d.IDDepart = IDDepart;
            db.SubmitChanges();
        }
    }
}
