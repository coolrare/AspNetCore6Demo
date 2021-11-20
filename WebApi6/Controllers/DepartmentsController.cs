using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi6.Models;

namespace WebApi6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly ILogger<DepartmentsController> _logger;
        private readonly ContosouniversityContext _context;

        public DepartmentsController(ILogger<DepartmentsController> logger, ContosouniversityContext context)
        {
            this._logger = logger;
            this._context = context;
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<Department>> GetDepartments()
        {
            return _context.Department;
        }

        [HttpGet("{id}")]
        public ActionResult<Department?> GetDepartmentById(int id)
        {
            return _context.Department.Find(id);
            // return context.Department.FirstOrDefault(p => p.DepartmentId == id);
            // return context.Department.Where(p => p.DepartmentId == id).FirstOrDefault();
        }

        [HttpPost("")]
        public ActionResult<Department> PostDepartment(Department model)
        {
            // model.Course.Add(new Course() {});
            _context.Department.Add(model);
            _context.SaveChanges();

            return model;
        }

        [HttpPut("{id}")]
        public ActionResult<Department> PutDepartment(int id, Department model)
        {
            var item = _context.Department.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            item.Budget = model.Budget;
            item.Name = model.Name;
            // _context.Department.Update(model);
            _context.SaveChanges();

            return model;
        }

        [HttpDelete("{id}")]
        public ActionResult<Department> DeleteDepartmentById(int id)
        {
            var item = _context.Department.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            _context.Department.Remove(item);
            _context.SaveChanges();
            return item;
        }
    }
}