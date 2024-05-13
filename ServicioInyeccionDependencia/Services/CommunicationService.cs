

namespace ServicioInyeccionDependencia.Services
{
    public class CommunicationService
    {
        private EmailService _emailService;
        public CommunicationService()
        {
            _emailService = new EmailService();
        }

        public void SendEmail(string email, string message)
        {
            _emailService.SendEmail(email, message);
        }
    }
}
