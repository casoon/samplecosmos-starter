using System;
using System.Threading.Tasks;

namespace SampleCosmos.Core.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
