using POWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace POWebAPI.DAL
{
	public class DBPurchase
	{
		public List<POMasterFullViewModel> GetAllCategory()
		{
			SqlConnection con = DBConnection.Connection;

			SqlCommand com = new SqlCommand("POSelect", con);
			com.CommandType = System.Data.CommandType.StoredProcedure;
			SqlDataAdapter da = new SqlDataAdapter(com);
			DataTable dt = new DataTable();
			con.Open();
			da.Fill(dt);
			con.Close();
			List<POMasterFullViewModel> lstPOs = new List<POMasterFullViewModel>();
			if (dt.Rows.Count > 0)
			{
				POMasterFullViewModel poM = null;

				foreach (DataRow dr in dt.Rows)
				{
					poM = new Models.POMasterFullViewModel();
					poM.PODate = Convert.ToDateTime(dr["PODATE"]);
					poM.PONO = Convert.ToUInt16(dr["PONO"]);
					poM.supplier.SUPNO = Convert.ToUInt16(dr["SUPLNO"].ToString());
					poM.supplier.SUPLName = dr["SUPLNAME"].ToString();
					poM.supplier.SUPLAddress = dr["SUPLADDR"].ToString();
					lstPOs.Add(poM);


				}
				ITEMViewModel item = null;
				SupplierViewModel sup = null;
				PODetailsViewModel pod = null;
				foreach (DataRow dr in dt.Rows)
				{
					var poNum = Convert.ToUInt16(dr["PONO"]);
					var pom = lstPOs.Where(x => x.PONO == poNum).FirstOrDefault();
					PODetailsViewModel detM = new Models.PODetailsViewModel();
					detM.PONO = poNum;
					detM.QTY = Convert.ToUInt16(dr["QTY"]);
					detM.Item = new ITEMViewModel();
					detM.Item.ITCode = dr["ITCode"].ToString();
					detM.Item.ITDesc = dr["ITDESC"].ToString();
					detM.Item.ITRate = Convert.ToDouble(dr["ITRATE"]);
					pom.PODetails.Add(detM);
				}
			}
			return lstPOs;

		}	

	}
}
	