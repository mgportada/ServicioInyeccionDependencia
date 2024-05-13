

namespace ServicioInyeccionDependencia.Services
{
    public class CommunicationService
    {
        private EmailService _emailService;
        public CommunicationService()
        {
            _emailService = new EmailService();
        }

        public void SendMessage(string email, string message)
        {
            _emailService.SendEmail(email, message);
        }
    }
}
