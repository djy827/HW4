using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using kemuyi.BLL;

namespace 网站
{
    public partial class questions : System.Web.UI.Page
    {
      
        static Random ran = new Random();

       static int QuesID = ran.Next(1, 10);
       static int []aaa=new int [99] ;
    protected void Page_Load(object sender, EventArgs e)
        {
           

            TextBox1.Text = QuestionManager.GetQues(QuesID).Content;
            TextBox2.Text = QuestionManager.GetQues(QuesID + 1).Content;
            TextBox3.Text = QuestionManager.GetQues(QuesID + 2).Content;
            TextBox4.Text = QuestionManager.GetQues(QuesID + 3).Content;
            TextBox5.Text = QuestionManager.GetQues(QuesID + 4).Content;
            TextBox6.Text = QuestionManager.GetQues(QuesID + 5).Content;
            TextBox7.Text = QuestionManager.GetQues(QuesID + 6).Content;
            TextBox8.Text = QuestionManager.GetQues(QuesID + 7).Content;
            TextBox9.Text = QuestionManager.GetQues(QuesID + 8).Content;
            TextBox10.Text = QuestionManager.GetQues(QuesID + 9).Content;
            Label1.Text = OptionsManager.GetQues(QuesID).A;
            Label2.Text = OptionsManager.GetQues(QuesID).B;
            Label3.Text = OptionsManager.GetQues(QuesID).C;
            Label4.Text = OptionsManager.GetQues(QuesID).D;
            Label5.Text = OptionsManager.GetQues(QuesID + 1).A;
            Label6.Text = OptionsManager.GetQues(QuesID + 1).B;
            Label7.Text = OptionsManager.GetQues(QuesID + 1).C;
            Label8.Text = OptionsManager.GetQues(QuesID + 1).D;
            Label9.Text = OptionsManager.GetQues(QuesID + 2).A;
            Label10.Text = OptionsManager.GetQues(QuesID + 2).B;
            Label11.Text = OptionsManager.GetQues(QuesID + 2).C;
            Label12.Text = OptionsManager.GetQues(QuesID + 2).D;
            Label13.Text = OptionsManager.GetQues(QuesID + 3).A;
            Label14.Text = OptionsManager.GetQues(QuesID + 3).B;
            Label15.Text = OptionsManager.GetQues(QuesID + 3).C;
            Label16.Text = OptionsManager.GetQues(QuesID + 3).D;
            Label17.Text = OptionsManager.GetQues(QuesID + 4).A;
            Label18.Text = OptionsManager.GetQues(QuesID + 4).B;
            Label19.Text = OptionsManager.GetQues(QuesID + 4).C;
            Label20.Text = OptionsManager.GetQues(QuesID + 4).D;
            Label21.Text = OptionsManager.GetQues(QuesID + 5).A;
            Label22.Text = OptionsManager.GetQues(QuesID + 5).B;
            Label23.Text = OptionsManager.GetQues(QuesID + 5).C;
            Label24.Text = OptionsManager.GetQues(QuesID + 5).D;
            Label25.Text = OptionsManager.GetQues(QuesID + 6).A;
            Label26.Text = OptionsManager.GetQues(QuesID + 6).B;
            Label27.Text = OptionsManager.GetQues(QuesID + 6).C;
            Label28.Text = OptionsManager.GetQues(QuesID + 6).D;
            Label29.Text = OptionsManager.GetQues(QuesID + 7).A;
            Label30.Text = OptionsManager.GetQues(QuesID + 7).B;
            Label31.Text = OptionsManager.GetQues(QuesID + 7).C;
            Label32.Text = OptionsManager.GetQues(QuesID + 7).D;
            Label33.Text = OptionsManager.GetQues(QuesID + 8).A;
            Label34.Text = OptionsManager.GetQues(QuesID + 8).B;
            Label35.Text = OptionsManager.GetQues(QuesID + 8).C;
            Label36.Text = OptionsManager.GetQues(QuesID + 8).D;
            Label37.Text = OptionsManager.GetQues(QuesID + 9).A;
            Label38.Text = OptionsManager.GetQues(QuesID + 9).B;
            Label39.Text = OptionsManager.GetQues(QuesID + 9).C;
            Label40.Text = OptionsManager.GetQues(QuesID + 9).D;
            }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            if (Convert.ToString(a) == QuestionManager.GetQues(QuesID).Answer)
            {
                int allscore = 0;
                allscore++;
              
                aaa[1] = allscore;
                Label41.Text = Convert.ToString(aaa[1]);
            }
         }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        int a;
        protected void RadioButton1_CheckedChanged1(object sender, EventArgs e)
        {if (RadioButton1.Checked) a = 1;

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked) a = 2;
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked) a = 3;
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked) a = 4;
        }
        
    }
}