<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtrlRegister.ascx.cs" Inherits="Lab02.Controls.CtrlRegister" %>
<link href="../css/bootstrap.min.css" rel="stylesheet" />
<div class="container">
<div class="row">
    <div class="col-3">
        Email
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

<div class="row">
    <div class="col-3">
        Mật khẩu nhập lại
    </div>
    <div class="col-9">
        <asp:TextBox ID="TextBox3" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
    </div>
</div>
</div>