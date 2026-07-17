using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_4A
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Student Name : " + TextBox1.Text +
                         "<br/>Gender : " + RadioButtonList1.SelectedItem.Text +
                         "<br/>Course : " + DropDownList1.SelectedItem.Text +
                         "<br/>Terms Accepted : " + CheckBox1.Checked +
                         "<br/>Date : " + Calendar1.SelectedDate.ToShortDateString();
        }
    }
}
