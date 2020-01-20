using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class EmployeeLogic
    {
        EmployeeDAO employee_db = new EmployeeDAO();

        public bool CheckUsername(string username)
        {
            if (employee_db.GetUsernames().Contains(username))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RegisterAccount(string un, string pw, int role)
        {
            employee_db.RegisterAccount(un, pw, role);
        }

        public void ChangePassword(Employee employee)
        {
            employee_db.ChangePassword(employee);
        }

        public int GetEmployeeIds(string username)
        {
            return employee_db.GetEmployeeIds(username);
        }

        public Employee GetUser(string username, string password)
        {
            return employee_db.GetUser(username, password);
        }
    }
}
