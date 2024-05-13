

using ServicioInyeccionDependencia.Repositories;

namespace ServicioInyeccionDependencia.Services
{
    public class CustomerService
    {
        private CustomerRepository _repository;

        public CustomerService()
        {
            _repository = new CustomerRepository();
        }

        public List<Customers> GetCustomers()
        {
            return _repository.GetCustomers();
        }
    }
}
