using System;
namespace CarParkingBooking
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string gender;
            if (rdoMale.Checked)
                gender = rdoMale.Text;
            else
                gender = rdoFemale.Text;
            long mobileNumber = long.Parse(txtMobileNumber.Text);
            string address = txtAddress.Text;
            string mailId = txtMailId.Text;
            string password = txtPassword.Text;
            UserRepository user = new UserRepository();
            int rows = user.AddCustomer(firstName, lastName, gender, mobileNumber, address, mailId, password);
            if (rows >= 1)
                Response.Redirect("SignIn.aspx");
        }
    }
}