using System;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
using PriceCheck_Omni.Models;
using System.Threading.Tasks;

namespace PriceCheck_Omni.Controllers
{
    public class ProductController : Controller
    {
        Uri baseAddress = new Uri("http://st.omniaccounts.co.za:55683");
        HttpClient client;

        public ProductController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> ProductDetails(string barcode)
        {
            string URL = $"http://st.omniaccounts.co.za:55683/Report/Stock%20Export?CompanyName=SA%20Example%20Company%20[Demo]&UserName=Guest&password=Dev2021&IBarCode={barcode}";
            HttpResponseMessage response = await client.GetAsync(URL);

            if (response.IsSuccessStatusCode)
            {
                string data =  await response.Content.ReadAsStringAsync();
                StockPort modellist = JsonConvert.DeserializeObject<StockPort>(data);
                return View(modellist);
            }
            return View();
        }
    }
}