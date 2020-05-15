using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADODB;

namespace askHealthLibrary
{
    public class Seller
    {
        private string _name;
        private string _password;
        

        public string Nama
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Seller()
        {

        }
        public Seller(string name, string pass)
        {
            this.Nama = name;
            this.Password = pass;
        }
        public int Login(string name, string pass)
        {
            ADODB.Recordset ar1 = new ADODB.Recordset();
            ar1 = dbask.PangggilDB("select * from Seller where Username = '" + name + "' and Password = '" + pass + "'");

            if (ar1.RecordCount >= 1)
            {

                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void Register(string name, string pass)
        {
            dbask.ubahDB("insert into Seller (Username, Password) values('" + name + "','" + pass + "')");
        }
      

    }
}
