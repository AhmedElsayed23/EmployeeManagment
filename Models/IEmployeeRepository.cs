﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int ID);
        
        IEnumerable<Employee> GetEmployees();
        
        Employee Add(Employee employee);
        
        Employee Update(Employee employeeChanges);
        
        Employee Delete(int ID);
    }
}
