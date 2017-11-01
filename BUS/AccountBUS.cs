using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
   public class AccountBUS
    {
        DocumentManageDataContext db = new DocumentManageDataContext();
        public IEnumerable<Department> getDepartLogin()
        {
            var query = (from x in db.Departments
                         where x.HD == true
                         select x).ToList();
            return query;
        }
        public IEnumerable<Department> GetDepart()
        {
            var query = (from x in db.Departments
                         select x).ToList();
            return query;
        }
        public bool Dangnhap(string IDDepart,int IDEmployee)
        {
            int count = (from x in db.Employees
                         where x.IDDepart == IDDepart && x.IDEmployee == IDEmployee
                         select x).Count();
            if (count == 1)
            {
                return true;
            }
            else return false;
        }
    }
}
