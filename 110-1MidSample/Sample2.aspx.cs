using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1MidSample {
    public partial class Sample2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            if(IsPostBack == false)
            {
                mt_Control(true);
                string s_Ver = mt_GenVeriStr();
                lb_Id.Text = s_Ver;
            }

        }

        // To generate a 4 digital number
        public string mt_GenVeriStr() {
            string s_Res = "";
            Random o_Ran = new Random();
            for (int i_Ct = 0; i_Ct < 4; i_Ct++) {
                int i_Tmp = o_Ran.Next(0, 10);
                s_Res = s_Res + i_Tmp.ToString();
            }
            return s_Res;
        }

        public void mt_Control(bool ans = false)  //新增下拉式選單 副程式
        {
            if(ans == true)
            {
                ddl_ZoneCode.Items.Clear();
                if(ddl_Type.SelectedValue == "手機")  //先處理1,2選單
                {
                    ListItem o_I = new ListItem("0911", "0911");
                    ddl_ZoneCode.Items.Add(o_I);
                    o_I = new ListItem("0921", "0921");
                    ddl_ZoneCode.Items.Add(o_I);
                    o_I = new ListItem("0960", "0960");
                    ddl_ZoneCode.Items.Add(o_I);

                }
                else
                {
                    ListItem o_I = new ListItem("02", "02");
                    ddl_ZoneCode.Items.Add(o_I);
                    o_I = new ListItem("04", "04");
                    ddl_ZoneCode.Items.Add(o_I);
                    o_I = new ListItem("07", "07");
                    ddl_ZoneCode.Items.Add(o_I);
                }

            }
            ddl_City.Items.Clear();

            switch (ddl_ZoneCode.SelectedValue)  //再來處理2,3選單
            {
                case "0911":
                case "0921":
                case "0960":
                    ListItem o_I = new ListItem("台北市", "台北市");
                    ddl_City.Items.Add(o_I);
                    o_I = new ListItem("新北市", "新北市");
                    ddl_City.Items.Add(o_I);
                    o_I = new ListItem("台中市", "台中市");
                    ddl_City.Items.Add(o_I);
                    o_I = new ListItem("台中縣", "台中縣");
                    ddl_City.Items.Add(o_I);
                    o_I = new ListItem("高雄市", "高雄市");
                    ddl_City.Items.Add(o_I);
                    o_I = new ListItem("高雄縣", "高雄縣");
                    ddl_City.Items.Add(o_I);

                    break;
                case "02":
                    ListItem o_I2 = new ListItem("台北市", "台北市");
                    ddl_City.Items.Add(o_I2);
                    o_I = new ListItem("新北市", "新北市");
                    ddl_City.Items.Add(o_I);
                    break;
                case "04":
                    ListItem o_I3 = new ListItem("台中市", "台中市");
                    ddl_City.Items.Add(o_I3);
                    o_I = new ListItem("台中縣", "台中縣");
                    ddl_City.Items.Add(o_I);
                    break;
                case "07":
                    ListItem o_I4 = new ListItem("高雄市", "高雄市");
                    ddl_City.Items.Add(o_I4);
                    o_I = new ListItem("高雄縣", "高雄縣");
                    ddl_City.Items.Add(o_I);
                    break;

            }

            

        }

        protected void ddl_Type_SelectedIndexChanged(object sender, EventArgs e)  
        {
            mt_Control(true);
        }

        protected void ddl_ZoneCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            mt_Control();
        }

        protected void rb_Des_SelectedIndexChanged(object sender, EventArgs e) //顯示資料方框
        {
            if(rb_Des.SelectedValue == "是")
            {
                tb_Des.Visible = true;
            }
            else
            {
                tb_Des.Visible = false;
            }
        }

        protected void btn_Submit_Click(object sender, EventArgs e) //顯示結果至lb_Id
        {

                lb_Msg.Text += lb_Id.Text + "<br/>";
                lb_Msg.Text += ddl_Type.SelectedValue + "<br/>";
                lb_Msg.Text += ddl_ZoneCode.SelectedValue + tb_Number.Text + "<br/>";
                lb_Msg.Text += ddl_City.SelectedValue + tb_Add.Text + "<br/>";
                lb_Msg.Text += tb_Des.Text;
           

        }


    }
}