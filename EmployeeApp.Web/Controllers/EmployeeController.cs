using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmployeeApp.Web.Models;
using Microsoft.EntityFrameworkCore;
namespace EmployeeApp.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDBContext _db;
        public EmployeeController(EmployeeDBContext db)
        {
            _db= db;
        }
        public IActionResult Index()
        {
            var EmployeeList = _db.Employee.ToList();
            return View(EmployeeList);
        }

        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(EmployeeModel _empModel){
            if(ModelState.IsValid){
                _db.Add(_empModel);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(_empModel);
        }

        
        public async Task<IActionResult> Edit(int? id){
            if(id == null){
               return  RedirectToAction("index");
            }

            var _empModel = await _db.Employee.FirstOrDefaultAsync(x =>x.EmpId==id);               
            return View(_empModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeModel _empModel){
            if(ModelState.IsValid){
                _db.Update(_empModel);
                await _db.SaveChangesAsync();
                return  RedirectToAction("index");
            }
            return View(_empModel);
        }

        public async Task<IActionResult> Details(int? id){
            if(id == null){
               return  RedirectToAction("index");
            }

            var _empModel = await _db.Employee.FirstOrDefaultAsync(x =>x.EmpId==id);               
            return View(_empModel);
        }

        public async Task<IActionResult> Delete(int? id){
            if(id == null){
               return  RedirectToAction("index");
            }

            var _empModel = await _db.Employee.FirstOrDefaultAsync(x =>x.EmpId==id);               
            return View(_empModel);
        }

         [HttpPost]
        public async Task<IActionResult> Delete(int id){
            var _empModel = await _db.Employee.FirstOrDefaultAsync(x =>x.EmpId==id);     
            _db.Employee.Remove(_empModel);
            await _db.SaveChangesAsync();
            return  RedirectToAction("index");            
        }
    }
}