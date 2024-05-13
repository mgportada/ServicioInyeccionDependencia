using ServicioInyeccionDependencia.Services;

namespace ServicioInyeccionDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();
            var communicationService = new CommunicationService();

            var customers = customerService.GetCustomers();
            var message = "Hello, we have a new product available for you";
            foreach (var customer in customers)
            {
                communicationService.SendEmail(customer.Email, message);
            }
        }
    }
}