using Blazor.CMS.Editor.Application.Requests.Mail;
using System.Threading.Tasks;

namespace Blazor.CMS.Editor.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}