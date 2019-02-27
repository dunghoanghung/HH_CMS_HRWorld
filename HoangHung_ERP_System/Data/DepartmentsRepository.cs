using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HoangHung_ERP_System.Data
{
    public class DepartmentsRepository
    {

        public IEnumerable<SelectListItem> GetDepartments()
        {
            using (var context = new ApplicationDbContext())
            {
                List<SelectListItem> departments = context.Departments.AsNoTracking()
                    .OrderBy(n => n.DepartmentName)
                        .Select(n =>
                        new SelectListItem
                        {
                            Value = n.DepartmentName,
                            Text = n.DepartmentName
                        }).ToList();
                var departmenttip = new SelectListItem()
                {
                    Value = null,
                    Text = "--- Chọn phòng ban ---"
                };
                departments.Insert(0, departmenttip);

                return new SelectList(departments, "Value", "Text");
            }
        }
    }
}