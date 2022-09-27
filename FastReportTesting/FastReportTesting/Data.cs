namespace FastReportTesting
{
    public class Data
    {
        private String[] Names =
       {
            "Catherine Landry","Gregory Santiago","David Stevenson","Ricky Deleon","Jennifer Aguilar","Dawn Mccoy","Robert Hunt","Joshua Howard","Jennifer Torres","Kristen Ross"
        };

        private String[] Emails =
        {
            "vilyrova428@stinkypoopoo.com","wanori8590@lurenwu.com","wanori8590@lurenwu.com"
        };


        private String[] Occupations =
        {
            "Chief Mobility Producer","Photographer","Actor", "Respiratory Therapist", "Janitor", "Musician",
        };

        private string[] Descriptions =
        {
            "Educated at Eton College and at St. John’s College, Oxford, the young Cambridge went into residence at Lincoln’s Inn in 1737."
        };

        private string[] Gender =
        {
            "Male", "Female"
        };

        private string[] Image = 
        {
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRxkpd0CkaqbEEpzHuTQSU_-ot1hlOcUl1IS50rMgZUcFvg4iO6jPYUPWYA6a5f4Va4_2c&usqp=CAU",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTCkBO27aYnhrL4HWaAUMYBLPwafjYMIAF71knmI9izvzB_2ZRQCg3LYSz1Ia7f86IJdtw&usqp=CAU",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQwDA726NqqwEDIWAhOabOBXZWnDnTaeGyNCQ8lJVba6Fra3U6WE6O4h249fUXSVBHPb0A&usqp=CAU"
        };

        private Random random = new Random();

        public List<Person> GetPersons(int count) 
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                Person person = new Person();
                person.Id = i + 1;
                string[] name = Names[random.Next(Names.Length - 1)].Split(' ');
                person.First_name = name[0];
                person.Last_name = name[1];
                person.Age = random.Next(20, 80);
                person.Img = Image[random.Next(Image.Length - 1)];
                person.Email = Emails[random.Next(Emails.Length - 1)];
                person.Gender = Gender[random.Next(Gender.Length - 1)];
                person.Occupation = Occupations[random.Next(Occupations.Length - 1)];
                person.Description = Descriptions[random.Next(Descriptions.Length - 1)];
                persons.Add(person);
            }
            return persons;
        }
    }
}
