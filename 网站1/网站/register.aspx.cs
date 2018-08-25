using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using kemuyi.BLL;
using System.Windows;


namespace 网站
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtPsw_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtPswOK_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt16(txtID.Text);
            if (txtPsw.Text == txtPswOK.Text)
            {
                UsersManager.Add(A, txtName.Text, txtPsw.Text);
                lblMess.Text = "注册成功。";

            }
            else
            {

            }

        }
    }
}