using System;
using System.Threading.Tasks;
using SampleCosmos.Core.Interfaces;

namespace SampleCosmos.Infrastructure.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            // TODO: implement Emailsendung
            return Task.CompletedTask;
        }
    }
}
