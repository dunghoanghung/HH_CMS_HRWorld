using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HoangHung_ERP_System.Data
{
    public class CompaniesRepository
    {

        public IEnumerable<SelectListItem> GetCompanies()
        {
            using (var context = new ApplicationDbContext())
            {
                List<SelectListItem> companies = context.Companies.AsNoTracking()
                    .OrderBy(n => n.CompanyName)
                        .Select(n =>
                        new SelectListItem
                        {
                            Value = n.CompanyId.ToString(),
                            Text = n.CompanyName
                        }).ToList();
                var companytip = new SelectListItem()
                {
                    Value = null,
                    Text = "--- Chọn công ty ---"
                };
                companies.Insert(0, companytip);
                return new SelectList(companies, "Value", "Text");
            }
        }
    }
}