using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeCRUDApp.Models;

namespace EmployeeCRUDApp.Data
{
    public class EmployeeContext :DbContext
    {
        public EmployeeContext(DbContextOptions <EmployeeContext> options) :base (options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
