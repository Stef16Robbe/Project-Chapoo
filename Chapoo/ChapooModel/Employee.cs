using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Employee
    {
        public int employeeId;
        public string username;
        public string password;
        public int role;

        public Employee(int id, string name, string password, int role)
        {
            this.employeeId = id;
            this.username = name;
            this.password = password;
            this.role = role;
        }
    }
}
