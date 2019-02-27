using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using HoangHung_ERP_System.Models;
using HoangHung_ERP_System.ViewModels;

namespace HoangHung_ERP_System.Data
{
    public class HRWorldsRepository
    {
        public List<HRWorldDisplayViewModel> GetHRWorlds()
        {
            using (var context = new ApplicationDbContext())
            {
                List<HRWorld> hrworlds = new List<HRWorld>();
                hrworlds = context.HRWorlds.AsNoTracking()
                  
                    .ToList();

                if (hrworlds != null)
                {
                    List<HRWorldDisplayViewModel> hrworldsDisplay = new List<HRWorldDisplayViewModel>();
                    foreach (var x in hrworlds)
                    {
                        var hrworldDisplay = new HRWorldDisplayViewModel()
                        {
                            Id = (Int16)x.Id,

                            NameUngVien = x.NameUngVien,
                            NgaySinh = x.NgaySinh,
              
                        };
                        hrworldsDisplay.Add(hrworldDisplay);
                    }
                    return hrworldsDisplay;
                }
                return null;
            }
        }

        public HRWorldEditViewModel CreateHRWorld()
        {
            var cRepo = new CitiesRepository();

            var coRepo = new CompaniesRepository();

            var dRepo = new DepartmentsRepository();

            var eRepo = new EmployeesRepository();

            var jRepo = new JobmanagersRepository();

            var hrworld = new HRWorldEditViewModel()
            {
                Companies = coRepo.GetCompanies(),

                Cities = cRepo.GetCities(),

                Departments = dRepo.GetDepartments(),

                Employees = eRepo.GetEmployees(),

                Jobmanagers = jRepo.GetJobmanagers()
            };

            return hrworld;
        }

        public bool SaveHRWorld(HRWorldEditViewModel hrworldedit)
        {
           // if (hrworldedit != null)
            //{
                using (var context = new ApplicationDbContext())
                {

                    var hrworld = new HRWorld()
                    {
                        NameUngVien = hrworldedit.NameUngVien,
                        NgaySinh = hrworldedit.NgaySinh,
                    };
                    context.HRWorlds.Add(hrworld);
                    context.SaveChanges();
                    return true;

                }



          //  }

          //      return false;

        }
    }
}