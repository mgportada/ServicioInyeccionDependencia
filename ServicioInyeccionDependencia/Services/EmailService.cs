
namespace ServicioInyeccionDependencia.Services
{
    public class EmailService
    {
        public void SendMessage(string email, string message)
        {
            Console.WriteLine("Email sent to: " + email + " with message: " + message);
        }
    }
}
