﻿using ServicioInyeccionDependencia.Services;

namespace ServicioInyeccionDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Use SmsService instead of EmailService
            var customerService = new CustomerService();
            var communicationService = new CommunicationService();

            var customers = customerService.GetCustomers();
            var message = "¡Hola! Su pedido ya está disponible para recoger";
            foreach (var customer in customers)
            {
                communicationService.SendMessage(customer.Email, message);
            }
        }
    }
}