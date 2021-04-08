using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using projektarbete_azure.Models;

namespace projektarbete_azure.Controllers
{
    public class RichardController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var catFact = new List<Models.CatResponse>();
            var catUrl = string.Empty;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://cat-fact.herokuapp.com/facts/random?animal_type=cat&amount=10"))
                {
                    var content = await response.Content.ReadAsStringAsync();
                    catFact = JsonConvert.DeserializeObject<List<Models.CatResponse>>(content);
                }
                /*using (var response = await httpClient.GetAsync("https://aws.random.cat/meow?ref=apilist.fun"))
                {
                    var content = await response.Content.ReadAsStringAsync();
                    catUrl = JsonConvert.DeserializeObject<MyUrl>(content);
                }*/
            }
            var richardsModel = new Models.RichardsModel(catFact, "This is a joke");

            return View(richardsModel);
        }
    }
}
