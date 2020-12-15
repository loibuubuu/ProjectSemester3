using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Newtonsoft.Json;
using System.Net.Http;

namespace WebForPatient.Components
{
    public class MedicinesViewComponent : ViewComponent
    {
        private string url = "http://http://localhost:61505/api/Medicines";
        private HttpClient httpClient = new HttpClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = JsonConvert.DeserializeObject<IEnumerable<Utility.Medicines>>(httpClient.GetStringAsync(url).Result);
           
            return View(model);
        }
    }
}
