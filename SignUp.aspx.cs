using System;
using CarParkingBooking.ENTITY;
using CarParkingBooking.DAL;
namespace CarParkingBooking
{
    public partial class SignUp : System.Web.UI.Page
    {
        UserRepository user = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SignUp_Click(object sender, EventArgs e)
        {
            UserEntitySignUp userEntitySignUp = new UserEntitySignUp(txtFirstName.Text, txtLastName.Text, rbGender.SelectedItem.ToString(), txtMobileNumber.Text, txtAddress.Text,txtMailId.Text, txtPassword.Text);
            int rows = user.AddCustomer(userEntitySignUp);
            if (rows >= 1)
                Response.Redirect("SignIn.aspx");
        }
    }
}