using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Calculator
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	public class Calculator : ICalculator
	{
		List<Jobs> lstJobs = new List<Jobs>();
		public Calculator()
		{
			lstJobs.Add(new Jobs { Name = "A", Role = "Manager" });
			lstJobs.Add(new Jobs { Name = "B", Role = "Employee" });
			lstJobs.Add(new Jobs { Name = "C", Role = "Employee" });
			lstJobs.Add(new Jobs { Name = "D", Role = "Employee" });
			lstJobs.Add(new Jobs { Name = "F", Role = "Manager" });
		}
		public double Add(double n1, double n2)
		{
			return n1 + n2;
		}

		public double Divide(double n1, double n2)
		{
			return n1 / n2;
		}

		public double Multiply(double n1, double n2)
		{
			return n1 * n2;
		}

		public IEnumerable<Jobs> OpeningJobs()
		{
			return lstJobs;
		}

		public IEnumerable<Jobs> OpeningJobsByRole(string role)
		{
			var jobsByRole = from p in lstJobs
							 where p.Role == role
							 select p;
			return jobsByRole;
		}

		public string SayHello(string name)
		{
			if (DateTime.Now.Hour < 12)
			{
				return "Good Morning " + name;
			}
			else if (DateTime.Now.Hour < 17)
			{
				return "Good Afternoon " + name;
			}
			else
			{
				return "Good Evening " + name;
			}

		}

		public double Subtract(double n1, double n2)
		{
			return n1 * n2;
		}

		public string TodayProgram(string name)
		{
			return name + " Enjoy Working day";
		}
	}

}

