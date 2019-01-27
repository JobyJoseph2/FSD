using POWebAPI.DAL;
using POWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace POWebAPI.Controllers
{
    public class PurchaseOrderController : ApiController
    {
		public IHttpActionResult GetAllPurchaseOrders()
		{
			List<POMasterFullViewModel> viewModel = new DBPurchase().GetAllCategory();
			if (viewModel.Count == 0)
			{
				return NotFound();
			}

			return Ok(viewModel);
		}

		public IHttpActionResult PostNewItem(ITEMViewModel item	)
		{
			if (!ModelState.IsValid)
				return BadRequest("Invalid data.");
			PODbEntities podb = new POWebAPI.PODbEntities();

			using (var ctx = new PODbEntities())
			{
				ctx.ITEMs.Add(new ITEM()
				{
					ITCODE = item.ITCode,
					ITDESC = item.ITDesc,
					ITRATE = Convert.ToDecimal(item.ITRate.ToString())
				});



				ctx.SaveChanges();
			}

			return Ok();
		}

		public IHttpActionResult PutUpdateQuantity(int PONO, string ITCode, int quantity)
		{

			using (var ctx = new PODbEntities())
			{
				var existingPODetail = ctx.PODETAILs.Where(s => s.PONO == PONO.ToString() && s.ITCODE == ITCode)
														.FirstOrDefault<PODETAIL>();

				if (existingPODetail != null)
				{
					existingPODetail.QTY = quantity;

					ctx.SaveChanges();
				}
				else
				{
					return NotFound();
				}
			}

			return Ok();
		}

		public IHttpActionResult Delete(int PONO)
		{
			if (PONO <= 0)
				return BadRequest("Not a valid Purchase order id");

			using (var ctx = new PODbEntities())
			{
				var existingPODetail = ctx.PODETAILs.Where(s => s.PONO == PONO.ToString()).Select(x => x);
				var existingPOMaster = ctx.POMASTERs.Where(s => s.PONO == PONO.ToString()).Select(x => x);

				foreach (var item in existingPODetail)
				{
					ctx.Entry(item).State = System.Data.Entity.EntityState.Deleted;
				}
				foreach (var item in existingPOMaster)
				{
					ctx.Entry(item).State = System.Data.Entity.EntityState.Deleted;
				}


				ctx.SaveChanges();
			}

			return Ok();
		}




	}
	}

