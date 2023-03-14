namespace BlazorApp1.Client.Model
{
    public class EmployeeServices : IEmployeeService
    {
        private List<Employee> _employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            Employee employee1= new Employee();
            employee1.emp_id = employee.emp_id;
            employee1.emp_name = employee.emp_name;
            employee1.emp_project= employee.emp_project;
            employee1.emp_salary=employee.emp_salary;

           _employees.Add(employee1);
        }

        public void DeleteById(string id)
        {
            _employees.Remove(GetById(id));
        }

        public List<Employee> GetAll()
        {
            return _employees;
        }

        public Employee GetById(string id)
        {
            return _employees.FirstOrDefault(c => c.emp_id == id);
        }

        public Employee GetByName(string name)
        {
            return _employees.FirstOrDefault(c => c.emp_name == name);
        }

        public void UpdateEmployee(Employee employee)
        {
            Employee updatedEmployee= _employees.FirstOrDefault(c=>c.emp_id==employee.emp_id);

            if (updatedEmployee!=null)
            {
                updatedEmployee.emp_name = employee.emp_name;
                updatedEmployee.emp_project= employee.emp_project;
                updatedEmployee.emp_salary= employee.emp_salary;
            }
        }
    }
}
