using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using kemuyi.BLL;

namespace 网站
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string loginID = txtLoginID.Text.Trim();
              int A = Convert.ToInt16(loginID);

            string loginpassword = txtLoginPassword.Text.Trim();
            if(loginID.Length>0&&loginpassword.Length>0)
            {
                if (   UsersManager.Selects(A)==false   )
                {
                    Server.Transfer("mainWeb.aspx");
                }
               
            }
            else
            {
                lblMess.Text = "登陆用户名或登陆密码为空，请重新输入。";
            }

        }

        protected void btnrg_Click(object sender, EventArgs e)
        {
            Server.Transfer("register.aspx");
        }
    }
}