﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Utility;

using Newtonsoft.Json;
using System.Net.Http;
namespace WebForPatient.Components
{
    public class HealthInformationsViewComponent : ViewComponent
    {
        private string url = "http://http://localhost:61505/api/HealthInformations";
        private HttpClient httpClient = new HttpClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = JsonConvert.DeserializeObject<IEnumerable<Utility.HealthInformations>>(httpClient.GetStringAsync(url).Result);
          
            return View(model);
        }
    }
}
