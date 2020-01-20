using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;
using System.Data;
using System.Windows.Forms;

namespace ChapooDAL
{
    public class EmployeeDAO : Base
    {
        public void ChangePassword(Employee employee)
        {
            string query = "UPDATE Employees SET [password] = '@pw' WHERE [name] LIKE '@name'";
            query = query.Replace("@pw", employee.password);
            query = query.Replace("@name", employee.username);
            ExecuteEditQuery(query);
        }

        public Employee GetUser(string username, string password)
        {
            string query = "SELECT [employeeId], [name], [password], [role] FROM Employees WHERE [name] LIKE '@username' AND [password] LIKE '@password'";
            query = query.Replace("@username", username);
            query = query.Replace("@password", password);
            return RetrieveUser(ExecuteSelectQuery(query));
        }

        private Employee RetrieveUser(DataTable dataTable)
        {
            string name = "";
            string password = "";
            int role = 0;
            int id = 0;
            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    {
                        name = (string)dr["name"];
                        password = (string)dr["password"];
                        id = (int)dr["employeeId"];
                        role = (int)dr["role"];
                    };
                }
                return new Employee(id, name, password, role);
            }
            catch
            {
                return null;
            }
        }

        public List<string> GetUsernames()
        {
            string query = "SELECT [name] FROM Employees";
            return RetrieveUsernames(ExecuteSelectQuery(query));
        }

        private List<string> RetrieveUsernames(DataTable dataTable)
        {
            List<string> usernames = new List<string>();
            string name;
            foreach (DataRow dr in dataTable.Rows)
            {
                {
                    name = (string)dr["name"];
                };
                usernames.Add(name);
            }
            return usernames;
        }

        public void RegisterAccount(string un, string pw, int role)
        {
            string query = "INSERT INTO Employees([name], [password], [role]) VALUES('@name', '@pw', @role)";
            query = query.Replace("@name", un);
            query = query.Replace("@pw", pw);
            query = query.Replace("@role", role.ToString());
            ExecuteEditQuery(query);
        }

        public int GetEmployeeIds(string username)
        {
            string query = "SELECT [employeeId] FROM Employees WHERE username LIKE '" + username + "'";
            return RetrieveIds(ExecuteSelectQuery(query));
        }

        private int RetrieveIds(DataTable dataTable)
        {
            int id = 1;
            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    {
                        id = (int)dr["employeeId"];
                    };
                }
            }
            catch
            {
                return 0;
            }
            return id;
        }
    }
}
