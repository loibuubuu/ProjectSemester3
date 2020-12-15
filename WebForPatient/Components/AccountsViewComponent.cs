using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Utility;


namespace WebForPatient.Components
{
    public class AccountsViewComponent : ViewComponent
    {
        private string url = "http://http://localhost:61505/api/Accounts";
        private HttpClient httpClient = new HttpClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
             var model = JsonConvert.DeserializeObject<IEnumerable<Utility.Accounts>>(httpClient.GetStringAsync(url).Result);
            var items = from s in model
                        select s;
            items = items.Where(a => a.Role.ToString().Equals("Doctor"));
            return View(items);
        }

    }
}
