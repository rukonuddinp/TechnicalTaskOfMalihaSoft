using Microsoft.AspNetCore.Mvc;
using Technical_Task.Context;
using Technical_Task.Models;
using Technical_Task.ViewModels;

namespace Technical_Task.Controllers
{
    public class StepsController : Controller
    {
        private readonly ApplicationContext _db;
        public StepsController(ApplicationContext db)
        {
            this._db = db;
        }
        public IActionResult Index()
        {
            var step1List=_db.Step1s.ToList();
            var step2List=_db.Step2s.ToList();  

            var stepsData = new Step1_2ViewModel()
            {
                Step1List = step1List,
                Step2List = step2List
            };
            return View(stepsData);
        }
        [HttpPost]
        public IActionResult AddStep1Row()
        {
            var model = new Step1
            {
                IsChecked = false,
                Index = _db.Step1s.Count() + 1 // Calculate the new index
            };
            _db.Step1s.Add(model);
            _db.SaveChanges();
            return Json(new { success = true, message = "Row added successfully" });
        }

        [HttpPost]
        public IActionResult AddStep2Row()
        {
            var model = new Step2
            {
                IsChecked = false,
                Index = _db.Step2s.Count() + 1 // Calculate the new index
            };
            _db.Step2s.Add(model);
            _db.SaveChanges();
            return Json(new { success = true, message = "Row added successfully" });
        }

        [HttpPost]
        public IActionResult UpdateRow([FromBody] UpdateModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Type == "Step1")
                {
                    var step1Item = _db.Step1s.FirstOrDefault(x => x.Step1Id == model.Id);
                    if (step1Item != null)
                    {
                        step1Item.Step1Value = int.Parse(model.Value);
                    }
                }
                else if (model.Type == "Step2")
                {
                    var step2Item = _db.Step2s.FirstOrDefault(x => x.Step2Id == model.Id);
                    if (step2Item != null)
                    {
                        step2Item.Step2Value = int.Parse(model.Value);
                    }
                }
                else if (model.Type == "Step1Checkbox")
                {
                    var step1Item = _db.Step1s.FirstOrDefault(x => x.Step1Id == model.Id);
                    if (step1Item != null)
                    {
                        step1Item.IsChecked = model.BoolValue;
                    }
                }
                else if (model.Type == "Step2Checkbox")
                {
                    var step2Item = _db.Step2s.FirstOrDefault(x => x.Step2Id == model.Id);
                    if (step2Item != null)
                    {
                        step2Item.IsChecked = model.BoolValue;
                    }
                }

                _db.SaveChanges();
                return Json(new { success = true, message = "Data updated successfully" });
            }
            return Json(new { success = false, message = "Invalid data" });
        }

        

    }
}
