using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kemuyi.Models;

namespace kemuyi.DAL
{
  public    class QuestionService
    {
        public static void Add(int QuestionID, string Content, string Answer)
        {
            kemuyiEntities db = new kemuyiEntities();
            db.Question.Add(new Question() { QuestionID = QuestionID, Content = Content, Answer = Answer });
            db.SaveChanges();
        }

        public static bool Delete(int QuestionID)
        {
            kemuyiEntities db = new kemuyiEntities();
            var Question = new Question { QuestionID = QuestionID };
            db.Question.Attach(Question);
            db.Question.Remove(Question);
            db.SaveChanges();

            return false;
        }
        public static bool Updata(int QuestionID, string Content, string Answer)
        {

            kemuyiEntities db = new kemuyiEntities();
            var Question = db.Question.Find(QuestionID);
            Question.Content = Content;
            Question.Answer = Answer;
            db.SaveChanges();

            return false;
        }

        public static bool TransactionScope(int QuestionID)
        {
            kemuyiEntities db = new kemuyiEntities();
            var Question = new Question { QuestionID = QuestionID };
            db.Question.Attach(Question);
            return false;
        }
   
        public static bool Selects(int QuestionID)
        {
            kemuyiEntities db = new kemuyiEntities();
            var Question = db.Question.Where(u => u.Content == "要查询的用户名").Select(u => new { Id = u.QuestionID, Name = u.Content, Psw = u.Answer }).FirstOrDefault();
            return true;
        }
        public static Question GetQues(int QuesID)
        {
            kemuyiEntities dbcontext = new kemuyiEntities();
            var Ques = dbcontext.Question.Find(QuesID);
            return Ques;
        }
    }
}
