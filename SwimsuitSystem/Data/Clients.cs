namespace CRUD.Data
{
    public class Clients
    {
        public string Id
        {
            get { return idGenerator(); }
            set {; }
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Nationality { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public Clients(string id, string name, string lastName, string gender, string birthday, string nationality, string phoneNumber, string emailAddress)
        {
            Id = id;
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
    }
}
