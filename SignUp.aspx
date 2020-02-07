 <%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="CarParkingBooking.SignUp" %>

<asp:Content ID="SignUp" runat="server" ContentPlaceHolderID="head">
    <marquee behavior="scroll" direction="right" scrollamount="40"><h1><b>WELCOME TO SABARI PARKING SITE </b></h1></marquee>
</asp:Content>
<asp:Content ID="contentHead" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

    <link rel="stylesheet" type="text/css" href="Styles.css" />
    <table class="a">
        <tr>
            <td>First Name</td>
            <td>
                <asp:TextBox runat="server" ID="txtFirstName"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="validateFirstName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First name required" Style="color: white"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="validateName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Enter valid name" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Last Name</td>
            <td>
                <asp:TextBox runat="server" ID="txtLastName"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="validateLastName" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last name required" Style="color: white"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rgvName" runat="server" ControlToValidate="txtLastName" ErrorMessage="Enter valid name" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Gender</td>
            <td>
                <asp:RadioButton ID="rdoMale" runat="server" Text="Male" GroupName="Gender" />
                <asp:RadioButton ID="rdoFemale" runat="server" Text="Female" GroupName="Gender" />
            </td>
        </tr>
        <tr>
            <td>Mobile Number</td>
            <td>
                <asp:TextBox runat="server" ID="txtMobileNumber"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="validateMobileNumber" runat="server" ControlToValidate="txtMobileNumber" ErrorMessage="Mobile number required" Style="color: white"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rgvMobileNumber" runat="server" ControlToValidate="txtMobileNumber" ErrorMessage="Enter valid mobile number" ValidationExpression="^[6789]\d{9}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Address</td>
            <td>
                <asp:TextBox runat="server" ID="txtAddress"></asp:TextBox>
            </td>
        </tr>
        <td>Mail Id</td>
        <td>
            <asp:TextBox runat="server" ID="txtMailId" TextMode="Email"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="validateMailId" runat="server" ControlToValidate="txtMailId" ErrorMessage="Mail id required" Style="color: white"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="rgvMailId" runat="server" ControlToValidate="txtMailId" ErrorMessage="Enter valid mail id" ValidationExpression="^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$"></asp:RegularExpressionValidator>
        </td>
        </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password required" Style="color: white"></asp:RequiredFieldValidator>
                    </td>
                </tr>

        <tr>
            <td>Confirm Password</td>
            <td>
                <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator runat="server" ID="rfvConfirmPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Confirm password required" Style="color: white"></asp:RequiredFieldValidator>
                <asp:CompareValidator runat="server" ID="validatePassword" ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword" ErrorMessage="Password and Confirm password must be same"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button runat="server" ID="buttonSignUp" Text="Sign up" OnClick="SignUp_Click" />
            </td>
        </tr>
    </table>
    <asp:ValidationSummary ID="validationSummary" runat="server" />
</asp:Content>

