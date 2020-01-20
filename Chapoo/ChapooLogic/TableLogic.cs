using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooLogic
{
    public class TableLogic
    {
        TableDAO table_db = new TableDAO();

        public List<Table> GetTables()
        {
            return table_db.Db_Get_All_Tables();
        }

        public void ChangeState(Table table, bool newState)
        {
            table_db.ChangeState(table, newState);
        }


        public int GiveNewId(Table table, Employee employee)
        {
            return table_db.GiveNewId(table, employee);
        }
    }
}
