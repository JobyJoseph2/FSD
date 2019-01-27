using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace SelfHosting
{
	class Program
	{
		static void Main(string[] args)
		{
	
			using (ServiceHost host = new ServiceHost(typeof(Calculator.Calculator)))
			{
				
				host.Open();

				Console.WriteLine("Service Started");
				Console.WriteLine("Press <Enter> to stop the service.");
				Console.ReadLine();

				// Close the ServiceHost.
				host.Close();
			}

		}
	}
}
