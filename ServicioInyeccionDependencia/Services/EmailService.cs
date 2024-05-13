
namespace ServicioInyeccionDependencia.Services
{
    public class EmailService
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine("Email sent to: " + email + " with message: " + message);
        }
    }
}
