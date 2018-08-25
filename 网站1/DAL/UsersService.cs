using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using kemuyi.Models;

namespace kemuyi.DAL
{
    public class UsersService
    {
        public static void Add(int ID, string Name, string Psw)
        {
            kemuyiEntities db = new kemuyiEntities();
            db.Users.Add(new Users() { ID = ID, Name = Name, Password = Psw });
            db.SaveChanges();
        }
        public static bool Delete(int ID)
        {
            kemuyiEntities db = new kemuyiEntities();
            var user = new Users { ID = ID };
            db.Users.Attach(user);
            db.Users.Remove(user);
            db.SaveChanges();

            return false;
        }
      public static bool Updata(int ID, string Name, string Psw)
        {

            kemuyiEntities db = new kemuyiEntities();
            var user = db.Users.Find(ID);
            user.Name = Name;
            user.Password = Psw;
            db.SaveChanges();

            return false;
        }

        public static bool TransactionScope(int ID)
        {
            kemuyiEntities db = new kemuyiEntities();
            var user = new Users { ID = ID };
            db.Users.Attach(user);
            return false ;
        }

        public static bool Selects(int ID)
        {
            kemuyiEntities db = new kemuyiEntities();
            var users = db.Users.Where(u =>u.Name == "要查询的用户名").Select(u => new { Id = u.ID, Name = u.Name, Psw = u.Password }).FirstOrDefault();
            return true;
        }
    }
}
