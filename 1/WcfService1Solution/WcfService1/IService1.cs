using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Customers GetCustomer(int customerId);

        [OperationContract]
        List<Customers> GetAllCustomers();
        [OperationContract]
        void AddCustomer(string fname, string lname, string city, string country, string phone);
        [OperationContract]
        void DeleteCustomer(int customerId);
    }
}
