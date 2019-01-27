using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Calculator
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface ICalculator
	{
		[OperationContract]
		string TodayProgram(string name);

		[OperationContract]
		IEnumerable<Jobs> OpeningJobs();

		[OperationContract]
		IEnumerable<Jobs> OpeningJobsByRole(string role);

		[OperationContract]
		double Add(double n1, double n2);

		[OperationContract]
		double Subtract(double n1, double n2);

		[OperationContract]
		double Multiply(double n1, double n2);

		[OperationContract]
		double Divide(double n1, double n2);

		[OperationContract]
		string SayHello(string name);
	}


	// Use a data contract as illustrated in the sample below to add composite types to service operations.
	[DataContract]
	public class Jobs
	{
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public string Role { get; set; }

	}
}
