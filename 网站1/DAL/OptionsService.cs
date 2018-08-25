using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kemuyi.Models;

namespace kemuyi.DAL
{
  public  class OptionsService
    {
        public static Options GetQues(int QuesID)
        {
            kemuyiEntities dbcontext = new kemuyiEntities();
            var Ques = dbcontext.Options.Find(QuesID);
            return Ques;
        }
    }
}
