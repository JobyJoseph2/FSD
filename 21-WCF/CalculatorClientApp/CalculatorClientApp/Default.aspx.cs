// Modified to deploy in IIS for orignal code see the zip file***************
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorClientApp
{
	public partial class _Default : Page
	{
		ServiceReference1.CalculatorClient calculatorHTTPClient = null;
		protected void Page_Load(object sender, EventArgs e)
		{
			calculatorHTTPClient = new ServiceReference1.CalculatorClient("BasicHttpBinding_ICalculator");
		}

		protected void btnHD_Click(object sender, EventArgs e)
		{
			spnbtnHD.InnerText = calculatorHTTPClient.TodayProgram(btnHD.Text);
		}

		protected void btnGM_Click(object sender, EventArgs e)
		{
			spnGoodMorning.InnerText = calculatorHTTPClient.SayHello(txtName.Text);
		}

		protected void btnAdd_Click(object sender, EventArgs e)
		{
			lblCalResult.Text = calculatorHTTPClient.Add(double.Parse(TextBox2.Text) , double.Parse(TextBox3.Text)).ToString();
		}

		protected void btnSub_Click(object sender, EventArgs e)
		{
			calculatorHTTPClient.Subtract(double.Parse(TextBox2.Text), double.Parse(TextBox3.Text)).ToString();
		}

		protected void btnMul_Click(object sender, EventArgs e)
		{
			lblCalResult.Text = calculatorHTTPClient.Multiply(double.Parse(TextBox2.Text), double.Parse(TextBox3.Text)).ToString();
		}

		protected void btnDiv_Click(object sender, EventArgs e)
		{
			lblCalResult.Text = calculatorHTTPClient.Divide(double.Parse(TextBox2.Text), double.Parse(TextBox3.Text)).ToString();
		}

		protected void btnOpening_Click(object sender, EventArgs e)
		{
			GridView1.DataSource = calculatorHTTPClient.OpeningJobs();
			GridView1.DataBind();
		}

	
		protected void btnRoleSearch_Click(object sender, EventArgs e)
		{
			gvJobs.DataSource = calculatorHTTPClient.OpeningJobsByRole(txtRole.Text);
			gvJobs.DataBind();
		}

		protected void btnGMTCP_Click(object sender, EventArgs e)
		{
			spnGoodMorning.InnerText = calculatorHTTPClient.SayHello(txtName.Text);
		}

		protected void btnHDTCP_Click(object sender, EventArgs e)
		{
			spnbtnHD.InnerText = calculatorHTTPClient.TodayProgram(btnHD.Text);
		}

		protected void btnOpeningTCP_Click(object sender, EventArgs e)
		{
			GridView1.DataSource = calculatorHTTPClient.OpeningJobs();
			GridView1.DataBind();
		}

		protected void btnRoleSearchTCP_Click(object sender, EventArgs e)
		{
			gvJobs.DataSource = calculatorHTTPClient.OpeningJobsByRole(txtRole.Text);
			gvJobs.DataBind();
		}
	}
}