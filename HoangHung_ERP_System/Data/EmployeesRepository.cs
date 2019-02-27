using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HoangHung_ERP_System.Data
{
    public class EmployeesRepository
    {

        public IEnumerable<SelectListItem> GetEmployees()
        {
            using (var context = new ApplicationDbContext())
            {
                List<SelectListItem> employees = context.Employees.AsNoTracking()
                    .OrderBy(n => n.EmployeeName)
                        .Select(n =>
                        new SelectListItem
                        {
                            Value = n.EmployeeName,
                            Text = n.EmployeeName
                        }).ToList();
                var employeetip = new SelectListItem()
                {
                    Value = null,
                    Text = "--- Chọn cán bộ tuyển dụng ---"
                };
                employees.Insert(0, employeetip);

                return new SelectList(employees, "Value", "Text");
            }
        }

    }
}