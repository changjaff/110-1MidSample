using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1MidSample {
    public partial class Sample1Com : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(IsPostBack == false)
            {
                lb_Msg.Text += Request.Form.Get("tb_CellPhone") + "<br />";
                lb_Msg.Text += Request.Form.Get("tb_ps") + "<br />";

                if (Request.Form.Get("rb_Gender") == "男")
                {
                    lb_Msg.Text = lb_Msg.Text + "男" + "<br />";
                }

                if (Request.Form.Get("rb_Gender") == "女")
                {
                    lb_Msg.Text = lb_Msg.Text + "女" + "<br />";
                }
                if (Request.Form.Get("rb_Gender") == "其他")
                {
                    lb_Msg.Text = lb_Msg.Text + "其他" + "<br />";
                }

                lb_Msg.Text += Request.Form.Get("tb_Num") + "<br />";
                lb_Msg.Text += Request.Form.Get("hd_Num") + "<br />";

                lb_Msg.Text += mt_2MD5(Request.Form.Get("tb_Num"));









            }

           








        }

        // To convert a plain-text string into a md5 string
        public string mt_2MD5(string s_Str) {
            System.Security.Cryptography.MD5 cryptoMD5 = System.Security.Cryptography.MD5.Create();
            byte[] ba_Bytes = System.Text.Encoding.UTF8.GetBytes(s_Str);
            byte[] ba_Hash = cryptoMD5.ComputeHash(ba_Bytes);

            string s_Md5 = BitConverter.ToString(ba_Hash)
                .Replace("-", String.Empty)
                .ToUpper();
            return s_Md5;
        }
    }
}