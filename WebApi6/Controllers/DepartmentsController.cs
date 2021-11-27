using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;

namespace WebApi6.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly ILogger<DepartmentsController> _logger;
        private readonly ContosouniversityContext _context;
        private readonly SmtpSettings _smtpSettings;

        public DepartmentsController(ILogger<DepartmentsController> logger,
            ContosouniversityContext context,
            IOptions<SmtpSettings> smtpSettings)
        {
            this._logger = logger;
            _context = context;
            _smtpSettings = smtpSettings.Value;
        }

        [HttpGet("string")]
        [Produces("text/json")]
        public string GetString()
        {
            _logger.LogInformation("{MethodName}: SMTPHost = {SmtpHost}",
                nameof(GetString), _smtpSettings.Host);

            return "Host: " + _smtpSettings.Host;
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<Department>> GetDepartments()
        {
            return Ok(_context.Department.AsNoTracking());
        }

        [HttpGet("{id}", Name = nameof(GetDepartmentById))]
        public ActionResult<Department?> GetDepartmentById(int id)
        {
            return _context.Department.Include(p => p.Course).FirstOrDefault(p => p.DepartmentId == id);
            // return _context.Department.Find(id);
            // return context.Department.FirstOrDefault(p => p.DepartmentId == id);
            // return context.Department.Where(p => p.DepartmentId == id).FirstOrDefault();
        }

        [HttpPost("")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesDefaultResponseType]
        public ActionResult<Department> PostDepartment(Department model)
        {
            // model.Course.Add(new Course() {});
            _context.Department.Add(model);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetDepartmentById),
                new { id = model.DepartmentId }, model);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public ActionResult<Department> PutDepartment(int id, Department model)
        {
            var item = _context.Department.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            // ValueInjector
            item.Budget = model.Budget;
            item.Name = model.Name;

            // _context.Department.Update(model);
            _context.SaveChanges();

            return model;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        [Authorize(Roles = "Admin")]
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
