using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.EF;

namespace WcfService1
{
    
    public class Service1 : IService1
    {
        public void AddCustomer(string fname, string lname, string city, string country, string phone)
        {
            using (SMTHDB db = new SMTHDB())
            {
                Customer c = new Customer();
                c.FirstName = fname;
                c.LastName = lname;
                c.City = city;
                c.Country = country;
                c.Phone = phone;
                db.Customers.Add(c);
                db.SaveChanges();
            }
            
        }

        public void DeleteCustomer(int customerId)
        {
            using (SMTHDB db = new SMTHDB())
            {
                Customer c = db.Customers.Where(i => i.Id.Equals(customerId)).First();
                db.Customers.Remove(c);
                db.SaveChanges();
            }
        }

        public List<Customers> GetAllCustomers()
        {
            using (SMTHDB db = new SMTHDB())
            {
                return db.Customers.Select(i => new Customers
                {
                    Id = i.Id,
                    Fname = i.FirstName,
                    Lname = i.LastName,
                    CityC = i.City,
                    CountryC = i.Country,
                    PhoneC = i.Phone
                }).ToList();
            }
        }

        public Customers GetCustomer(int customerId)
        {
            using(SMTHDB db = new SMTHDB())
            {
                return db.Customers.Where(i => i.Id == customerId).Select(i => new Customers
                {
                    Id = i.Id,
                    Fname = i.FirstName,
                    Lname = i.LastName,
                    PhoneC = i.Phone
                }).FirstOrDefault();
            }
        }

    }
}
