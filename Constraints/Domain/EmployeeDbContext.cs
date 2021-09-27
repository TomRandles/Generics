using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Constraints.Domain
{
    public class EmployeeDb : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
