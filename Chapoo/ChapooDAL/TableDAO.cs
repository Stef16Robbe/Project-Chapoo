using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using System.Configuration;
using ChapooModel;

namespace ChapooDAL
{
    public class TableDAO : Base
    {
        public List<Table> Db_Get_All_Tables()
        {
            string query = "SELECT DISTINCT T.tableId, T.free, ISNULL((SELECT MAX(O.orderId) FROM Orders INNER JOIN MenuOrders AS M ON t.tableId = M.tableId INNER JOIN Orders AS O ON O.orderId = M.orderId), 0) AS OrderId FROM[Table] AS T";
            return ReadTables(ExecuteSelectQuery(query));
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    TableId = (int)dr["tableId"],
                    Free = (bool)dr["free"],
                    OrderId = (int)dr["orderId"]
                };
                tables.Add(table);
            }
            return tables;
        }

        public void ChangeState(Table table, bool newState)
        {
            string query = "UPDATE [Table] SET free = @free WHERE tableId = @table";
            if (newState)
            {
                query = query.Replace("@free", 1.ToString());
            }
            else
            {
                query = query.Replace("@free", 0.ToString());
            }
            query = query.Replace("@table", table.TableId.ToString());
            ExecuteEditQuery(query);
        }

        public int GiveNewId(Table table, Employee employee)
        {
            //Determine what would be the next OrderId and implementing a new record in Orders
            string query = "SELECT COUNT(DISTINCT orderId) AS [count] FROM Orders";
            string newRecord = "INSERT INTO Orders(orderId, employeeId, totalPrice, paymentStatus, [date]) VALUES(@orderId, @employeeId, 0, 0, GETDATE())";
            int count = 0;
            DataTable r = ExecuteSelectQuery(query);
            foreach (DataRow dr in r.Rows)
            {
                count = (int)dr["count"];
            }
            newRecord = newRecord.Replace("@orderId", (count + 1).ToString());
            newRecord = newRecord.Replace("@employeeId", employee.employeeId.ToString());
            ExecuteEditQuery(newRecord);
            return count + 1;
        }

    }
}
