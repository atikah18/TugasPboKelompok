using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace askHealthLibrary
{
    public class Buyer
    {
        
        public void Data(string nama, string email, string nomor, string obat)
        {
            
             dbask2.ubahDB2("insert into Buyer (Nama, Email, [Nomor Wa], Obat ) values('" + nama + "','" + email + "','" + nomor + "','" + obat + "')");
            
        }
    }
}
