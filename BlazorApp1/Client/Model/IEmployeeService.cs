namespace BlazorApp1.Client.Model
{
    public interface IEmployeeService
    {
        public  List<Employee> GetAll();
        public Employee GetById(string id);
        public Employee GetByName(string name);
         
        public void DeleteById(string id);
        public void UpdateEmployee(Employee employee);
        public void AddEmployee (Employee employee);


    }
}
