using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService1
{
    [DataContract]
    public class Customers
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Fname { get; set; }
        [DataMember]
        public string Lname { get; set; }
        [DataMember]
        public string CityC { get; set; }
        [DataMember]
        public string CountryC { get; set; }
        [DataMember]
        public string PhoneC { get; set; }
    }
}