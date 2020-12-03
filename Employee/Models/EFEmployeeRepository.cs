﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public class EFEmployeeRepository :IEmployeeRepository
    {
        private EmployeeDbContext context;
        public EFEmployeeRepository(EmployeeDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Employee> Employees => context.Employees;
    }
}
