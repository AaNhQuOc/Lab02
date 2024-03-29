﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02
{
    public partial class DangKyThanhVien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlNgay.Items.Add(new ListItem("--Chọn ngày--", ""));
                for (int i = 1; i <= 31; i++)
                {
                    ddlNgay.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }

                ddlThang.Items.Add(new ListItem("--Chọn tháng--", ""));
                for (int i = 1; i <= 12; i++)
                {
                    ddlThang.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }


                ddlNam.Items.Add(new ListItem("--Chọn năm--", ""));
                for (int i = 1950; i <= 2010; i++)
                {
                    ddlNam.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }

            }

        }

        protected void btDangKy_Click(object sender, EventArgs e)
        {

            //b2.tra ket qua ve client
            lbKetQua.Text = kq;
        }
    }
}