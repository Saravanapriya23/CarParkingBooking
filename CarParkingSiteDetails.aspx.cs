using System;
using System.Data;
using System.Web.UI.WebControls;

namespace CarParkingBooking
{
    public partial class GridViewForm : System.Web.UI.Page
    {
        string connectionString = @"data source = LAPTOP-4L7SUSOL\SQLEXPRESS;database=CarParkingBookingManagement;User ID = sa; Password=special*23";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                PopulateGridView();
            }
        }
        void PopulateGridView()
        {
            DataTable table = AdminRepository.ViewParkingSiteDetails();
            gvCarParkingSiteDetails.DataSource = table;
            gvCarParkingSiteDetails.DataBind();
        }
        protected void gvCarParkingSiteDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvCarParkingSiteDetails.EditIndex = -1;
            PopulateGridView();
        }

        protected void gvCarParkingSiteDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int carserialNo = Convert.ToInt16(gvCarParkingSiteDetails.DataKeys[e.RowIndex].Values["serialNo"].ToString());
            AdminRepository.DeleteParkingSiteDetails(carserialNo);
            PopulateGridView();
        }

        protected void gvCarParkingSiteDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

            gvCarParkingSiteDetails.EditIndex = e.NewEditIndex;
            PopulateGridView();
        }

        protected void gvCarParkingSiteDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int carserialNo = Convert.ToInt16(gvCarParkingSiteDetails.DataKeys[e.RowIndex].Values["serialNo"].ToString());
            TextBox siteName = gvCarParkingSiteDetails.Rows[e.RowIndex].FindControl("txtsitetName") as TextBox;
            string carParkingSiteName = siteName.Text;
            TextBox location = gvCarParkingSiteDetails.Rows[e.RowIndex].FindControl("txtlocation") as TextBox;
            string carParkingLocation = location.Text;
            TextBox emailId = gvCarParkingSiteDetails.Rows[e.RowIndex].FindControl("txtemailId") as TextBox;
            string carParkingSiteEmailId = emailId.Text;
            TextBox parkingslots = gvCarParkingSiteDetails.Rows[e.RowIndex].FindControl("txtparkingSlots") as TextBox;
            string parkingSlots = parkingslots.Text;
            int carParkingSlots = Convert.ToInt16((parkingSlots.ToString()));
            AdminRepository.UpdateParkingSiteDetails(carserialNo, carParkingSiteName, carParkingLocation, carParkingSiteEmailId,carParkingSlots);
            gvCarParkingSiteDetails.EditIndex = -1;
            PopulateGridView();
        }
        protected void linkInsert_Click(object sender, EventArgs e)
        {
            TextBox sitename = (gvCarParkingSiteDetails.FooterRow.FindControl("txtsiteNameFooter") as TextBox);
            TextBox location = (gvCarParkingSiteDetails.FooterRow.FindControl("txtlocationFooter") as TextBox);
            TextBox emailid = gvCarParkingSiteDetails.FooterRow.FindControl("txtemailIdFooter") as TextBox;
            TextBox parkingslots = gvCarParkingSiteDetails.FooterRow.FindControl("txtparkingSlotsFooter") as TextBox;
            string carSiteName = sitename.Text;
            string carSiteLocation = location.Text;
            string emailId = emailid.Text;
            int carParkingSlots = Convert.ToInt32((parkingslots.Text).ToString());
            AdminRepository.InsertParkingSiteDetails(carSiteName, carSiteLocation, emailId, carParkingSlots);
            gvCarParkingSiteDetails.EditIndex = -1;
            PopulateGridView();
        }
    }
}