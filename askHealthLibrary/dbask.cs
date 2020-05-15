using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADODB;

namespace askHealthLibrary
{
    class dbask
    {
        public static ADODB.Recordset PangggilDB(string db)
        {
            ADODB.Connection AC = new ADODB.Connection();

            if (AC.State.Equals(ObjectStateEnum.adStateOpen))
            {
                AC.Close();
                AC = null;
            }
            AC.CursorLocation = CursorLocationEnum.adUseClient;
            AC.Properties.Refresh();
            AC.Open("DSN=DSNask");

            object obj = Type.Missing;

            ADODB.Recordset AR = new ADODB.Recordset();
            AR = AC.Execute(db, out obj);

            return AR;
        }
        public static void ubahDB(string db)
        {
            ADODB.Connection aco = default(ADODB.Connection);
            aco = new ADODB.Connection();
            if (aco.State.Equals(ObjectStateEnum.adStateOpen))
            {
                aco.Close();
                aco = null;
            }
            aco.CursorLocation = CursorLocationEnum.adUseClient;
            aco.Properties.Refresh();
            aco.Open("DSN=DSNask");

            object obj = Type.Missing;
            aco.Execute(db, out obj);
        }
    }
}
