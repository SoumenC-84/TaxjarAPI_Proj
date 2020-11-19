using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Taxjar;

namespace TaxAPI
{
    public class TaxJarCommon
    {
        public TaxjarApi client;
        public TaxJarCommon()
        {
            client = APIClient.Client;
        }

        public Taxjar.RateResponseAttributes GetTaxReateForaLocation()
        {
            Taxjar.RateResponseAttributes obj = client.RatesForLocation("92093", new { city = "Santa Monica", state = "CA", country = "US" });
            return obj;
        }
        public void CalculateTaxRate()
        {

            //client = APIClient.Client;
            var tax = client.TaxForOrder(new
            {

                from_country = "US",
                from_zip = "92093",
                from_state = "CA",
                from_city = "La Jolla",
                from_street = "9500 Gilman Drive",
                to_country = "US",
                to_zip = "90002",
                to_state = "CA",
                to_city = "Los Angeles",
                to_street = "1335 E 103rd St",
                amount = 15,
                shipping = 1.5,
                nexus_addresses = new[] {
            new {
              id = "Main Location",
              country = "US",
              zip = "92093",
              state = "CA",
              city = "La Jolla",
              street = "9500 Gilman Drive",
            }
          },
                line_items = new[] {
            new {
              id = "1",
              quantity = 1,
              product_tax_code = "20010",
              unit_price = 15,
              discount = 0
            }
          }
            });

            decimal taxCollect = tax.AmountToCollect;
            decimal taxRate = tax.Rate;
        }
    }
}