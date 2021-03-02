using System;
namespace FinalProject
{
    public class FilmScreening : IShortInfo
    {
        public int FilmScreeningId { get; set; }
        public Film Film { get; set; }
        public Hall Hall { get; set; }
        public SeatPlace[] SeatPlaces { get; set; }
        public DateTime DateTime { get; set; }

        public FilmScreening()
        {
        }

        public FilmScreening(int filmScreeningId, Film film, Hall hall, SeatPlace[] seatPlaces, DateTime dateTime)
        {
            this.FilmScreeningId = filmScreeningId;
            this.Film = film;
            this.Hall = hall;
            this.SeatPlaces = seatPlaces;
            this.DateTime = dateTime;
        }
        public override string ToString()
        {
            return $"FilmScreeningId: {FilmScreeningId}, Film: {Film.Name}, Hall: {Hall.Number}, Number Places:{SeatPlaces.Length}, Date: {DateTime}";
            //return $"FilmScre {film.name}";
        }
        public string ToShortString()
        {
            return $"FilmScreeningId: {FilmScreeningId}, Date: {DateTime}";
        }
    }
}