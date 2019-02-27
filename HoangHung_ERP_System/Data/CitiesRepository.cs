using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HoangHung_ERP_System.Data
{
    public class CitiesRepository
    {

        public IEnumerable<SelectListItem> GetCities()
        {
            using (var context = new ApplicationDbContext())
            {
                List<SelectListItem> cities = context.Cities.AsNoTracking()
                    .OrderBy(n => n.CityName)
                        .Select(n =>
                        new SelectListItem
                        {
                            Value = n.CityName,
                            Text = n.CityName
                        }).ToList();
                var citytip = new SelectListItem()
                {
                    Value = null,
                    Text = "--- Chọn tỉnh TP ---"
                };
                cities.Insert(0, citytip);
                return new SelectList(cities, "Value", "Text");
            }
        }
    }
}