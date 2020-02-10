using System;
using CarParkingBooking.DAL;
using CarParkingBooking.ENTITY;
namespace CarParkingBooking
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SignIn_Click(object sender, EventArgs e)
        {
            UserEntitySignIn userEntitySignIn = new UserEntitySignIn(txtUserId.Text, txtPassword.Text);
            UserRepository user = new UserRepository();
            bool isValid = user.ValidateLogin(userEntitySignIn);
            if (isValid)
                Response.Write("Sign in successfully completed");
            else
                Response.Write("Sign in not completed..Please create your account");
        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }
    }
}