using System;
namespace FinalProject
{
    public class Ticket : IShortInfo
    {
        public long          Number { get; set; }
        public FilmScreening FilmScreening { get; set; }
        public Seat          Seat { get; set; }
        public Viewer        Viewer { get; set; }
        public decimal       Price { get; set; }

        public Ticket()
        {
        }

        public Ticket(long number, FilmScreening filmScreening, Seat seat, Viewer viewer, decimal price)
        {
            this.Number        = number;
            this.FilmScreening = filmScreening;
            this.Seat          = seat;
            this.Viewer        = viewer;
            this.Price         = price;
        }

        public override string ToString()
        {
            return $"Number of ticket: {Number}, Film Screening: {FilmScreening.Film.Name}, Seat: {Seat} Viewer: {Viewer.FirstName}, Price: {Price}";
        }
        public string ToShortString()
        {
            return $"Number of ticket: {Number}";
        }
    }
}
