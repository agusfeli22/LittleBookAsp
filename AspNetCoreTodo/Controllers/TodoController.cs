using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers 
{
    public class TodoController : Controller 
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }
        public IActionResult Index()
        {
            var items = await _todoItemService.GetIncompleteItemsAsync();
            

        }
    }
}