using System;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IceSmoothie.Infrastructrue.Utilities
{
    public class EmailSender
    {
        public static async Task SendEmailAsynce(string from, string to, string subject, string message)
        {
			try
			{
                var smtpClient = new SmtpClient
                {
                    Host = "110,110,110,110",       // SMTP IP 입력
                    Port = 12345 ,                  // SMTP 포트 입력
                    EnableSsl = false,              // ssl 인증서 사용안함,
                    UseDefaultCredentials  =  true, // 기본 크레덴셜 사용
                };

                using (var mailMessage = new MailMessage(from, to) 
                { Subject = subject, Body = message, IsBodyHtml = true, BodyEncoding = Encoding.UTF8 })
                {
                    await smtpClient.SendMailAsync(mailMessage);
                }

			}
			catch (Exception ex)
			{
                var test = ex.Message;
                throw;
			}
            finally
            {
                await Task.CompletedTask;
            }
        }
    }
}
