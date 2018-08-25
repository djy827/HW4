using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kemuyi.DAL;
using kemuyi.Models;

namespace kemuyi.BLL
{
  public  class QuestionManager
    {
        public static void Add(int QuestionID, string Content, string Answer)
        {
            QuestionService.Add(QuestionID,Content,Answer);
        }

        public static bool Delete(int QuestionID)
        {
            QuestionService.Delete(QuestionID);
            return false;
        }
        public static bool Updata(int QuestionID, string Content, string Answer)
        {

            QuestionService.Updata(QuestionID, Content, Answer);

            return false;
        }

        public static bool TransactionScope(int QuestionID)
        {
            QuestionService.TransactionScope(QuestionID);
            return false;
        }

        public static bool Selects(int QuestionID)
        {
            QuestionService.Selects(QuestionID);
            return true;
        }
        public static  Question GetQues(int QuesID)
        {

           var  ques= QuestionService.GetQues(QuesID);
            return ques;
        }
    }
}
