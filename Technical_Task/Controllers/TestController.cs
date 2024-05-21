using Microsoft.AspNetCore.Mvc;
using Technical_Task.Context;
using Technical_Task.Models;
using Technical_Task.ViewModels;

namespace Technical_Task.Controllers
{
    public class TestController : Controller
    {
        private readonly ApplicationContext _applicationContext;
        public TestController(ApplicationContext applicationContext)
        {
            this._applicationContext = applicationContext;     
        }
        public IActionResult Index()
        {
            var step1List=_applicationContext.Step1s.ToList();
            var step2List=_applicationContext.Step2s.ToList();
            var stepViewModel = new Step1_2ViewModel()
            {
                Step1List = step1List,
                Step2List = step2List
            };
            
            return View(stepViewModel);
        }
        [HttpPost]
        public IActionResult PostStep1(Step1 step1)
        {
            var kdld=step1.Step1Value.ToString();
            return RedirectToAction("Index");
        }
    }
}
