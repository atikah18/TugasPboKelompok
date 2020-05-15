using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADODB;

namespace askHealthLibrary
{
    class dbask2
    {
        public static void ubahDB2(string db)
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
            aco.Open("DSN=DSNask2");

            object obj = Type.Missing;
            aco.Execute(db, out obj);
        }
    }
}
