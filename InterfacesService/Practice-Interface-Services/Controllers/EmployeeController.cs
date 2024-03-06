using Practice_Interface_Services.Services;
using Practice_Interface_Services.Services.Interfaces;
using Practice_Interface_Services.Helpers.Responses;
using Practice_Interface_Services.Models;



namespace Practice_Interface_Services.Controllers
{
    public class EmployeeController : Employee
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController()
        {
            _employeeService = new Services.EmployeeService();
        }
        public void GetAll()
        {
            var employees = _employeeService.GetAll();
            foreach (var employee in employees)
            {
                string result = $"{employee.Name} {employee.Surname} {employee.Addres} {employee.Email} " +
                    $"{employee.Age} {employee.Birthday.ToString("dddd, dd-MMMM-yyyy")}";
                Console.WriteLine(result);
            }

        }

        public void GetById()
        {
            int? id = null;
            var response = _employeeService.GetById(_employeeService.GetAll(),id);
            if (response.ErrorMessage is null)
            {
                string result = $"{response.Employee.Name} {response.Employee.Surname} {response.Employee.Addres} {response.Employee.Email} " +
                    $"{response.Employee.Age} {response.Employee.Birthday.ToString("dddd, dd-MMMM-yyyy")}";
                Console.WriteLine(result);
            }
            else 
            {
                Console.WriteLine(response.ErrorMessage);
            }

        }
    }

}
