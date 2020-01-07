using System.Threading.Tasks;

namespace HotChocolate.ApplicationCore.Interfaces
{
    public interface IEmailSmsText
    {
        bool CompanySms(int adminId, string name, string phone, string authkey);
        Task<bool> CompanyEmail(int adminId, string name, string mail, string authkey);
    }
}
