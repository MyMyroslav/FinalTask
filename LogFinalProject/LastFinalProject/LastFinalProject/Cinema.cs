using System;
using System.Collections.Generic;

namespace FinalProject
{
    public class Cinema
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
        public Film[] Films { get; set; }
        public Hall[] Halls { get; set; }
        public Ticket[] Tickets { get; set; }
        public Cinema()
        {
        }

        public Cinema(string name, decimal money, Film[] films, Hall[] halls, Ticket[] tickets)
        {
            this.Name = name;
            this.Money = money;
            this.Films = films;
            this.Halls = halls;
            this.Tickets = tickets;
        }
        public Film[] GetFilms()
        {
            List<Film> films_online = new List<Film>();
            for (int i = 0; i < Films.Length; i++)
            {
                if (Films[i].EndDate >= DateTime.Now)
                {
                    films_online.Add(Films[i]);
                }
            }
            return films_online.ToArray();
        }
        public FilmScreening[] GetFilmScreenings(int filmId)
        {
            List<FilmScreening> filmScreenings_online = new List<FilmScreening>();
            for (int i = 0; i < Films.Length; i++)
            {
                if (Films[filmId].FilmScreenings[i].DateTime >= Films[filmId].StartDate && Films[filmId].FilmScreenings[i].DateTime <= Films[filmId].EndDate)
                {
                    
                    for(int j = 0;j<Films[filmId].FilmScreenings.Length;j++)
                    {
                        filmScreenings_online.Add(Films[filmId].FilmScreenings[j]);
                    }
                    
                }
            }
            try
            {
                if (filmScreenings_online.Count == 0)
                    throw new NotExistException("No such film found!");
            }
            catch (NotExistException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            return filmScreenings_online.ToArray();
        }
        public FilmScreening GetFilmScreening(int filmId, int filmScreeningId)
        {
          try
          {
            
             return Films[filmId].FilmScreenings[filmScreeningId];

            
             throw new NotExistException("No such film found!");
          }
            
          catch (NotExistException e)
          {
                Console.WriteLine($"Error: {e.Message}");
          }
          return null;
        }

        public decimal GetFilmScreeningPrice(int filmId, int filmScreeningId, int seatNumber)
        {
            
            FilmScreening filmScreening = GetFilmScreening(filmId, filmScreeningId);
            try
            {
                if (filmScreening != null)
                {
                    decimal price = filmScreening.Film.Price + filmScreening.Hall.Price;
                    return price;
                }
                else
                {
                    throw new NotExistException("No such film found!");
                }   
            }
            catch(NotExistException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            
            return -1;
        }

        public Ticket BuyTicket(int filmId, int filmScreeningId, int seatNumber, decimal price, Viewer viewer)
        {
            

            FilmScreening filmScreening = GetFilmScreening(filmId, filmScreeningId);
            try
            {
                if (filmScreening != null && GetFilmScreeningPrice(filmId, filmScreeningId, seatNumber) == price)
                {
                    if(filmScreening.Film.MinAge<=viewer.Age)
                    {
                        if (filmScreening.SeatPlaces[seatNumber].Busy != true)
                        {
                            Money += price;

                            Ticket ticket = new Ticket(Tickets.Length, filmScreening, filmScreening.SeatPlaces[seatNumber], viewer, price);
                            //Повернення грошей, за 3 години до сеансу.
                            //if (filmScreening.DateTime < DateTime.Now&& DateTime.Now < filmScreening.DateTime.AddHours(-3))
                            if (filmScreening.DateTime > new DateTime(2021, 2, 25, 17, 30, 00) && new DateTime(2021, 2, 25, 17, 30, 00) > filmScreening.DateTime.AddHours(-3))
                            {
                                Money -= price;
                                Console.WriteLine($"The money {price} has been turned");
                            }
                            else
                            {
                                filmScreening.SeatPlaces[seatNumber].Busy = true;
                                Console.WriteLine("Ticket purchased successfully");
                                return ticket;
                            }
                        }
                        else
                        {
                            throw new BusySeatException("Place is taken!");
                        }
                    }
                    else
                    {
                        throw new InvalidAgeException("Your age is restricted");
                    }
                   
                }
                else
                {
                    throw new NotExistException("No such film found!");
                }

            }
            catch (ApplicationException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            
            return null;
        }
        
        public override string ToString()
        {
            return String.Format($"Cinema name: {Name}, number of films: {Films.Length}, number of halls {Halls.Length}\n");
        }
        
    }
}
