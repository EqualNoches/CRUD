using MailKit.Net.Smtp;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CRUD.Data
{
    public class Clients
    {
        public string Id => idGenerator();

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Nationality { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public Clients(string name, string lastName, string gender, string birthday, string nationality, string phoneNumber, string emailAddress)
        {
            Name = name;
            LastName = lastName;
            Gender = gender;
            Birthday = birthday;
            Nationality = nationality;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
        }

        private string idGenerator()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max).ToString();
        }

        public async void SendEmail(string recieverName,string recieverMail)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("CRUD Application", "edwarddiaz@kcs.edu.do"));
            email.To.Add(new MailboxAddress(recieverName, recieverMail));

            email.Subject = "MAMI SOY PROGRAMADOR";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = "<b>ACABO DE HACER UN PROGRAMA Y PUEDO ENVIAR CORREOS DE CONFIRMACIÓN</b>" +
                       "<h1> Es Edward </h1>"
            };
            using var smtp = new SmtpClient();
            await smtp.ConnectAsync("smtp.gmail.com", 465, true);

            // Note: only needed if the SMTP server requires authentication
            await smtp.AuthenticateAsync("edwarddiaz@kcs.edu.do", "ujdfqekpigceszkj");

            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);

            MessageBox.Show(@"Se ha enviado un correo de confirmación a su correo electronico especificado.",
                @"Confirmacion de correo electronico.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public async void SendUpdatedEmail(string recieverName,string recieverMail)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("CRUD Application", "edwarddiaz@kcs.edu.do"));
            email.To.Add(new MailboxAddress(recieverName, recieverMail));

            email.Subject = "MAMI SOY PROGRAMADOR";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = "<b>Su correo electronico ha sido modificado en la aplicación crud </b>" +
                       "<h1> Es Edward </h1>"
            };
            using var smtp = new SmtpClient();
            await smtp.ConnectAsync("smtp.gmail.com", 465, true);

            // Note: only needed if the SMTP server requires authentication
            await smtp.AuthenticateAsync("edwarddiaz@kcs.edu.do", "ujdfqekpigceszkj");

            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);

            MessageBox.Show(@"Se ha enviado un correo de confirmación a su correo electronico especificado.",
                @"Confirmacion de correo electronico.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
