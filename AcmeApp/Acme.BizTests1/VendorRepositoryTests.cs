using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveTest()
        {
            var vendorRepository = new VendorRepository();

            var vendors = vendorRepository.RetrieveAll();

            //var vendorQuery = from v in vendors
            //                  where v.CompanyName.Contains("2")
            //                  select v;

            //var vendorQuery = vendors.Where(FilterCompanys).OrderBy(OrderCompanyByName);

            var vendorQuery = vendors.Where(v => v.CompanyName.Contains("3"))
                                     .OrderBy(v => v.CompanyName);

            vendorQuery.ToList();

            foreach (var item in vendorQuery)
            {
                Console.WriteLine(item);
            }            
        }

        //private bool FilterCompanys(Vendor v) => v.CompanyName.Contains("3");

        //private string OrderCompanyByName(Vendor v) => v.CompanyName;
    }
}