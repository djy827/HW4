using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using kemuyi.DAL;

namespace kemuyi.BLL
{
    public class UsersManager
    {
        public static void Add(int ID, string Name, string Psw)
        {
            UsersService.Add(ID, Name, Psw);
        }
        public bool Delete(int ID)
        {
            UsersService.Delete(ID);
            return false;
        }
        public bool Updata(int ID,string Name,string Psw)
        {
            UsersService.Updata(ID, Name, Psw);
            return false;
        }
          public bool TransactionScope(int ID)
        {
             UsersService.TransactionScope(ID);
            return true;
        }
        public static bool Selects(int ID)
        {
            UsersService.Selects(ID);
            return false;
        }
    }
}
