using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
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
            DataTable datatable = new DataTable();
            using (SqlConnection con=new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter("Select siteName,location,emailId,parkingSlots FROM CarParkingSiteDetails",con);
                dataadapter.Fill(datatable);
            }
            if(datatable.Rows.Count>0)
            {
                gvCarParkingSiteDetails.DataSource = datatable;
                gvCarParkingSiteDetails.DataBind();
            }
            else
            {
                datatable.Rows.Add(datatable.NewRow());
                gvCarParkingSiteDetails.DataSource = datatable;
                gvCarParkingSiteDetails.DataBind();
                gvCarParkingSiteDetails.Rows[0].Cells.Clear();
                gvCarParkingSiteDetails.Rows[0].Cells.Add(new TableCell());
                gvCarParkingSiteDetails.Rows[0].Cells[0].ColumnSpan = datatable.Columns.Count;
                gvCarParkingSiteDetails.Rows[0].Cells[0].Text="No Data Found...!!";
                gvCarParkingSiteDetails.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }
        }
    }
}