using AuthenticateAPI.Model;

namespace AuthenticateAPI.Interfaces
{
    public interface IEmployeService
    {
        public List<Employe> GetEmployeeDetails();
        public Employe GetEmployeeDetails(int id);
        public Employe AddEmployee(Employe employe);
        public Employe UpdateEmployee(Employe employe);
        public bool DeleteEmployee(int id);


    }
}
