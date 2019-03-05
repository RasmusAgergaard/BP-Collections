using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;

        public ICollection<Vendor> Retrieve()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();
                vendors.Add(new Vendor() { VendorId = 1, CompanyName = "TestCom" });
                vendors.Add(new Vendor() { VendorId = 2, CompanyName = "TestCom2" });
            }

            Console.WriteLine(vendors);

            return vendors;
        }

        public ICollection<Vendor> RetrieveAll()
        {
            var vendors = new List<Vendor>()
            {
                {new Vendor() {VendorId = 1, CompanyName = "123", Email = "test@email.dk" }},
                {new Vendor() {VendorId = 2, CompanyName = "456", Email = "test@email.dk" }},
                {new Vendor() {VendorId = 3, CompanyName = "789", Email = "test@email.dk" }},
                {new Vendor() {VendorId = 4, CompanyName = "253", Email = "test@email.dk" }},
                {new Vendor() {VendorId = 5, CompanyName = "412", Email = "test@email.dk" }},
                {new Vendor() {VendorId = 6, CompanyName = "789", Email = "test@email.dk" }},
                {new Vendor() {VendorId = 7, CompanyName = "257", Email = "test@email.dk" }},
                {new Vendor() {VendorId = 8, CompanyName = "358", Email = "test@email.dk" }},
                {new Vendor() {VendorId = 9, CompanyName = "897", Email = "test@email.dk" }},
                {new Vendor() {VendorId = 10, CompanyName = "325", Email = "test@email.dk" }}
            };

            return vendors;
        }

        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
    }
}
