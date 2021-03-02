using System;
namespace FinalProject
{
    public class Film : IShortInfo
    {
        public int FilmId { get; set; }
        public string Name { get; set; }
        public int MinAge { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public FilmScreening[] FilmScreenings { get; set; }
        public Film()
        {

        }
        public Film(int filmId, string name, int minAge, decimal price, DateTime startDate, DateTime endDate, string description, FilmScreening[] filmScreenings)
        {
            this.FilmId = filmId;
            this.Name = name;
            this.MinAge = minAge;
            this.Description = description;
            this.Price = price;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.FilmScreenings = filmScreenings;
        }
        
        public override string ToString()
        {
            return $"Film ID: {FilmId}, Name: {Name}, Min Age: {MinAge}, Price: {Price}, Start Date: {StartDate}, End Date: {EndDate},\nDescription: {Description}\n";
        }

        public string ToShortString()
        {
            return $"Name: {Name}, Min Age: {MinAge}, Price: {Price}\n";
        }
    }
}
