using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HoangHung_ERP_System.Data
{
    public class JobmanagersRepository
    {
        public IEnumerable<SelectListItem> GetJobmanagers()
        {
            using (var context = new ApplicationDbContext())
            {
                List<SelectListItem> jobmanagers = context.Jobmanagers.AsNoTracking()
                    .OrderBy(n => n.JobmanageName)
                        .Select(n =>
                        new SelectListItem
                        {
                            Value = n.JobmanageName,
                            Text = n.JobmanageName
                        }).ToList();
                var addblank = new SelectListItem()
                {
                    Value = null,
                    Text = "--- Chọn cán bộ tuyển dụng ---"
                };
                jobmanagers.Insert(0, addblank );

                return new SelectList(jobmanagers, "Value", "Text");
            }
        }
    }
}