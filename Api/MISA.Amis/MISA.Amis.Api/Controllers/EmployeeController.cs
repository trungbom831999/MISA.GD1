using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interfaces;
using MISA.CukCuk.Api.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Amis.Api.Controllers
{
    /// <summary>
    /// Api cho đối tượng Nhân viên
    /// </summary>
    public class EmployeeController : BaseEntityController<Employee>
    {
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService) : base(employeeService)
        {
            _employeeService = employeeService;
        }
    }
}
