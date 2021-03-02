using System;
namespace FinalProject
{
    public class Viewer : IShortInfo
    {
        public sbyte  Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Viewer()
        {
        }

        public Viewer(sbyte age, string firstName, string lastName)
        {
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return $"Age of viewer: {Age}, Name: {FirstName}, Surname: {LastName}";
        }
        public string ToShortString()
        {
            return $"Name: {FirstName}";
        }
    }
}
