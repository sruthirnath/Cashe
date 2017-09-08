using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CashingDemo
{
    public partial class WebGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Cache.SetExpires(DateTime.Now.AddSeconds(60));
            //Response.Cache.VaryByParams["None"] = true;
            //Response.Cache.SetCacheability(HttpCacheability.Server);
            if (!IsPostBack)
            {
                GetEmployeeByDesignation("All");
            }

        }
        private void GetEmployeeByDesignation(string v)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter("spGetEmployeeByDesignation", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter paramEmployeeDesignation = new SqlParameter();
            paramEmployeeDesignation.ParameterName = "@designation";
            paramEmployeeDesignation.Value = v;
            da.SelectCommand.Parameters.Add(paramEmployeeDesignation);

            DataSet DS = new DataSet();
            da.Fill(DS);
            GridView1.DataSource = DS;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEmployeeByDesignation(DropDownList1.SelectedItem.Value);
        }
    }
}