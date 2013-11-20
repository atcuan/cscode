using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 文件上传
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                //获得上传文件路径
                string upLoadPath = Server.MapPath("~/upload/");
                FileUpload1.SaveAs(upLoadPath + FileUpload1.FileName);
            }
        }
    }
}
