using Microsoft.AspNetCore.Mvc;
using to_do_list_app.Models;

namespace to_do_list_app.Controllers
{
    public class ToDoListController : Controller
    {
        public static List<ToDoListModel> ToDoItems = new List<ToDoListModel>();

        public IActionResult Index()
        {
            return View(ToDoItems);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ToDoListModel item)
        {
            Guid id = Guid.NewGuid();
            item.Id = id;

            ToDoItems.Add(item);
            return RedirectToAction("Index");
        }
        
    }
}
