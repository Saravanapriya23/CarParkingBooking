<%@ Page Language="C#" MasterPageFile="~/Home.Master" trace="false" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="CarParkingBooking.UserLogin" %>
<asp:Content ID="SignIn" runat="server" ContentPlaceHolderID="head">   </asp:Content>
 <asp:Content ID="contentHead" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

<body style="background-color:palegoldenrod">
    <style>
body {
  background-image: url('Car1.jfif');
  background-repeat: no-repeat;
  background-attachment: fixed;
  background-size: 100% 100%;
}
        </style>

        <div>
            <h1 style="text-align: center"><b>WELCOME TO SABARI CAR PARKING SITE</b></h1>
            <h4 style="text-align:center"><i>LOGIN TO SABARI PARKING SITE</i></h4>
            <table align="Center">
                <tr>
                    <td>Username</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtUserId" placeholder="Enter your mail id"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" placeholder="Enter your password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button runat="server" Text="Sign In" OnClick="SignIn_Click" />
                    </td>
                    <td>
                        <asp:Button runat="server" Text="Sign Up" OnClick="SignUp_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </body>
   </asp:Content>

