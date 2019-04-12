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
using System.Threading;

namespace MainApp.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Common()
        {

            Thread.Sleep(1000);

            dynamic result = new ExpandoObject();

            result.success = true;
            result.message = "";

            result.data = new ExpandoObject();

            result.success = true;
            result.message = "";

            result.data = new Manager
            {
                Id = 1,
                Code = "Manager1",
                Name = "Иванов Менеджеров"
            };

            return Json(result);
        }

        public JsonResult Orders()
        {
            var jss = new JsonSerializer();

            var OrdersList = new List<Order>();

            Thread.Sleep(2000);

            OrdersList.Add(new Order {
                Key = 1,
                Number = 1,
                ContractNumber = "8/1203-P",
                Client = new Client { Id = 1, Name = "Иванов Иван Петрович", Agent = "ООО \"Рога и Копыто\"" },
                Manager = new Manager { Id = 1, Name = "Иван Менеджеров" },
                State = new OrderState { Id = 18, Name = "Оплачен" },
                Source = new OrderSource { Id = 4, Name = "Чужой архив" },
                CreateDate = "2018-12-12",
                CompleteDate = "2018-12-21"
            });

            OrdersList.Add(new Order
            {
                Key = 2,
                Number = 2,
                ContractNumber = "1/22203-D",
                Client = new Client { Id = 1, Name = "Петров Василий Викторович", Agent = "ООО \"Ведро и Корыто\"" },
                Manager = new Manager { Id = 1, Name = "Иван Менеджеров" },
                State = new OrderState { Id = 15, Name = "Оплачен" },
                Source = new OrderSource { Id = 4, Name = "Чужой архив" },
                CreateDate = "2018-12-12",
                CompleteDate = "2018-12-21"
            });

            OrdersList.Add(new Order
            {
                Key = 3,
                Number = 3,
                ContractNumber = "7/12303-D",
                Client = new Client { Id = 1, Name = "Пейсатенко Пархат Мацович", Agent = "ООО \"Израиль и Ко\"" },
                Manager = new Manager { Id = 1, Name = "Иван Менеджеров" },
                State = new OrderState { Id = 7, Name = "Оплачен" },
                Source = new OrderSource { Id = 1, Name = "Своя съемка" },
                CreateDate = "2018-12-12",
                CompleteDate = "2018-12-21"
            });

            OrdersList.Add(new Order
            {
                Key = 4,
                Number = 4,
                ContractNumber = "7/12303-C",
                Client = new Client { Id = 1, Name = "Аристотелев Евпсихий Африканович", Agent = "ООО \"Просто компания\"" },
                Manager = new Manager { Id = 1, Name = "Иван Менеджеров" },
                State = new OrderState { Id = 9, Name = "Оплачен" },
                Source = new OrderSource { Id = 2, Name = "Чужая съемка" },
                CreateDate = "2018-12-12",
                CompleteDate = "2018-12-21"
            });

            var serializedString = JsonConvert.SerializeObject(OrdersList);

            dynamic result = new ExpandoObject();

            result.success = true;
            result.message = "";

            result.data = new ExpandoObject();

            result.data.collection = OrdersList;

            result.data.paging = new Paging
            {
                Page = 3, Pages = 10, Count = 100
            };

            result.data.filter = new ExpandoObject();

            result.data.filter.searchString = "";
            result.data.filter.onlyMy = false;
            result.data.filter.onlyActive = false;

            result.data.order = new ExpandoObject();

            result.data.order.field = "contractNumber";
            result.data.order.mode = "asc";

            return Json(result);
        }

        /*public IActionResult Index()
        {
            return View();
        }*/

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
