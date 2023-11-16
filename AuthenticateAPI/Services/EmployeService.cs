using AuthenticateAPI.Context;
using AuthenticateAPI.Interfaces;
using AuthenticateAPI.Model;

namespace AuthenticateAPI.Services
{
    public class EmployeService : IEmployeService
    {
        private readonly JwtContext _jwtContext;
      
        public EmployeService(JwtContext jwtContext) { 
            
            _jwtContext = jwtContext;
        
        }
        public Employe AddEmployee(Employe employe)
        {
            var emp = _jwtContext.Employees.Add(employe);
            _jwtContext.SaveChanges();
            return emp.Entity;

        }

        public bool DeleteEmployee(int id)
        {
            try
            {
                var rmp = _jwtContext.Employees.SingleOrDefault(s => s.Id == id);
                if(rmp == null)
                {
                    throw new Exception("user not found");
                }
                else
                {
                    _jwtContext.Employees.Remove(rmp);
                    _jwtContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Employe> GetEmployeeDetails()
        {
            var employees = _jwtContext.Employees.ToList();
            return employees;
        }

        public Employe GetEmployeeDetails(int id)
        {
            var rmp = _jwtContext.Employees.SingleOrDefault(s => s.Id == id);
            return rmp;
        }

        public Employe UpdateEmployee(Employe employe)
        {
            var updated = _jwtContext.Employees.Update(employe);
            _jwtContext.SaveChanges();
            return updated.Entity;
        }
    }
}
