using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Net.Http;
namespace WebForPatient.Components
{
    public class CategoryChildViewComponent : ViewComponent
    {
        private string url = "http://http://localhost:61505/api/CategoryChilds";
        private HttpClient httpClient = new HttpClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = JsonConvert.DeserializeObject<IEnumerable<Utility.CategoryChild>>(httpClient.GetStringAsync(url).Result);
            var items = from s in model 
                        where s.CategoriesID== 202
                        select s;
            return View(items);
        }
    }
}
