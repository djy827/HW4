using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kemuyi.DAL;
using kemuyi.Models;

namespace kemuyi.BLL
{
   public  class OptionsManager
    {
        public static Options GetQues(int QuesID)
        {

            var ques = OptionsService.GetQues(QuesID);
            return ques;
        }
    }
}
