using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 验证控件
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.IsValid)// 防止跳过客户端校验，IsValid表示是否所有Validator都已通过
            {

            }
            else
            {
                Label1.Text = "请认真检查填写数据是否有误";
                return;
            }

        }
    }
}
