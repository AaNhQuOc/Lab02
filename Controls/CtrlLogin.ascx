<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtrlLogin.ascx.cs" Inherits="Lab02.Controls.CtrlLogin" %>
<link href="../css/bootstrap.min.css" rel="stylesheet" />
<div class="row">
    <div class="col-3">
        Tên đăng nhập
    </div>
    <div class="col-9">
        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
</div>

<div class="row">
    <div class="col-3">
        Mật khẩu
    </div>
    <div class="col-9">
        <asp:TextBox ID="TextBox2" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
    </div>
</div>