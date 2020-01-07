using HotChocolate.ApplicationCore.Interfaces;
using System;
using System.Threading.Tasks;

namespace IceSmoothie.Infrastructrue.Utilities
{
    public class EmailSmsText : IEmailSmsText
    {
        public EmailSmsText()
        {

        }

        public bool CompanySms(int adminId, string name, string phone, string authkey)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CompanyEmail(int adminId, string name, string mail, string authkey)
        {
            throw new NotImplementedException();
        }
    }
}
