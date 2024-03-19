namespace SwimsuitSystem.Data
{
    internal class Clients
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Nationality { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public Clients (string name, string lastName, string gender, string birthday, string nationality, string phoneNumber, string emailAddress)
        {
            Name = name;
            LastName = lastName;
            Gender = gender;
            Birthday = birthday;
            Nationality = nationality;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
        }
    }
}
