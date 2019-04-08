using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MainApp.Models;
using Newtonsoft.Json;
using ManagersModels;
using System.Dynamic;

namespace MainApp.Controllers
{
    public class HomeController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/

        public JsonResult Orders()
        {
            var jss = new JsonSerializer();

            var OrdersList = new List<Order>();

            OrdersList.Add(new Order {
                Number = 1,
                ContractNumber = "8/1203-P",
                Client = new Client { Id = 1, Name = "Иванов Иван Петрович", Agent = "ООО \"Рога и Копыто\"" },
                State = new OrderState { Name = "Оплачен" },
                Source = new OrderSource { Name = "Чужой архив" },
                CreateDate = "2018-12-12",
                CompleteDate = "2018-12-21"
            });

            OrdersList.Add(new Order
            {
                Number = 2,
                ContractNumber = "1/22203-D",
                Client = new Client { Id = 1, Name = "Петров Василий Викторович", Agent = "ООО \"Ведро и Корыто\"" },
                State = new OrderState { Name = "Оплачен" },
                Source = new OrderSource { Name = "Чужой архив" },
                CreateDate = "2018-12-12",
                CompleteDate = "2018-12-21"
            });

            OrdersList.Add(new Order
            {
                Number = 3,
                ContractNumber = "7/12303-D",
                Client = new Client { Id = 1, Name = "Пейсатенко Пархат Мацович", Agent = "ООО \"Израиль и Ко\"" },
                State = new OrderState { Name = "Оплачен" },
                Source = new OrderSource { Name = "Своя съемка" },
                CreateDate = "2018-12-12",
                CompleteDate = "2018-12-21"
            });

            OrdersList.Add(new Order
            {
                Number = 4,
                ContractNumber = "7/12303-C",
                Client = new Client { Id = 1, Name = "Аристотелев Евпсихий Африканович", Agent = "ООО \"Просто компания\"" },
                State = new OrderState { Name = "Оплачен" },
                Source = new OrderSource { Name = "Чужая съемка" },
                CreateDate = "2018-12-12",
                CompleteDate = "2018-12-21"
            });

            var serializedString = JsonConvert.SerializeObject(OrdersList);

            dynamic result = new ExpandoObject();

            result.success = true;
            result.message = "";

            result.data = new ExpandoObject();

            result.data.collection = serializedString;

            result.data.paging = new Paging
            {
                Page = 1, Pages = 10, Count = 100
            };

            result.data.filter = new ExpandoObject();

            result.data.filter.search = "";
            result.data.filter.my = false;
            result.data.filter.active = false;

            result.data.order = new ExpandoObject();

            result.data.order.field = "contractNumber";
            result.data.order.mode = "asc";

            return Json(result);
        }

        /*public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
