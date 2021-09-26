using System.Net.Mail;

namespace ByteBank.Forum.App_Start.Identity
{
    internal class MailAdress : MailAddress
    {
        public MailAdress(string address) : base(address)
        {
        }
    }
}