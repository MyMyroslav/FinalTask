using System;
namespace FinalProject
{
    public static class CinemaFactory 
    {
        static CinemaFactory()
        {

        }

        public static Cinema CreateCinema(string name,Film[] films, Hall[] halls, Ticket[] tickets)
        {

            FillTheFilmScreenings(ref films, halls[0], FillSeatPlace_1());

            return new Cinema(name, 1000, films, halls, tickets) ;
        }
        public static Cinema CreateCinema_2(string name, Film[] films, Hall[] halls, Ticket[] tickets)
        {
            FillTheFilmScreenings_2(ref films, halls[0], FillSeatPlace_2());

            return new Cinema(name, 1000, films, halls, tickets);
        }

        public static NormalSeat[] FillSeat_1()
        {
            NormalSeat[] seats = new NormalSeat[10];
            for (int i = 0; i < 10; i++)
            {
                seats[i] = new NormalSeat() { Number = i+1 };
            }
            return seats;
        }
        public static Hall[] FillHall_1()
        {
            Hall[] hall1 = new Hall[1] { new Hall(1, 10, FillSeat_1(), 90)};
            return hall1;
        }
        
        public static SeatPlace[] FillSeatPlace_1()
        {
            SeatPlace[] seatPlaces1 = new SeatPlace[10];
            seatPlaces1[0] = new SeatPlace() { Busy = true };
            seatPlaces1[1] = new SeatPlace() { Busy = false };
            seatPlaces1[2] = new SeatPlace() { Busy = false };
            seatPlaces1[3] = new SeatPlace() { Busy = false };
            seatPlaces1[4] = new SeatPlace() { Busy = true };
            seatPlaces1[5] = new SeatPlace() { Busy = true };
            seatPlaces1[6] = new SeatPlace() { Busy = false };
            seatPlaces1[7] = new SeatPlace() { Busy = true };
            seatPlaces1[8] = new SeatPlace() { Busy = false };
            seatPlaces1[9] = new SeatPlace() { Busy = true };
            return seatPlaces1;
        }

        public static VipSeat[] FillSeat_2()
        {
            VipSeat[] seats = new VipSeat[12];
            for (int i = 0; i < 12; i++)
            {
                seats[i] = new VipSeat() { Number = i + 1 };
            }
            return seats;
        }
        public static Hall[] FillHall_2()
        {
            Hall[] hall2 = new Hall[1] { new Hall(2, 12, FillSeat_2(), 120) };
            return hall2;
        }

        public static SeatPlace[] FillSeatPlace_2()
        {
            SeatPlace[] seatPlaces2 = new SeatPlace[12];
            seatPlaces2[0] = new SeatPlace() { Busy = true };
            seatPlaces2[1] = new SeatPlace() { Busy = false };
            seatPlaces2[2] = new SeatPlace() { Busy = false };
            seatPlaces2[3] = new SeatPlace() { Busy = false };
            seatPlaces2[4] = new SeatPlace() { Busy = true };
            seatPlaces2[5] = new SeatPlace() { Busy = true };
            seatPlaces2[6] = new SeatPlace() { Busy = false };
            seatPlaces2[7] = new SeatPlace() { Busy = true };
            seatPlaces2[8] = new SeatPlace() { Busy = false };
            seatPlaces2[9] = new SeatPlace() { Busy = true };
            seatPlaces2[10] = new SeatPlace() { Busy = false };
            seatPlaces2[11] = new SeatPlace() { Busy = true };
            return seatPlaces2;
        }

        public static Film[] FillTheFilms()
        {
            Film[] films = new Film[2] { new Film(1, "Titanic",14,100, new DateTime(2021, 2, 20, 18, 30, 25), new DateTime(2021, 9, 12, 18, 30, 25), "American disaster film of 1997, directed by James Cameron, which uses the sinking of the legendary Titanic",null),
            new Film(2, "Avatar",16,70, new DateTime(2021, 2, 10, 19, 30, 25), new DateTime(2021, 10, 22, 20, 30, 25), "Is a 2009 American sci-fi film written and directed by James Cameron, starring Sam Worthington and Zoe Saldana.",null) };
            return films;
        }
        public static Film[] FillTheFilms_2()
        {
            Film[] films = new Film[2] { new Film(1, "Bobik",14,100, new DateTime(2021, 2, 20, 18, 30, 25), new DateTime(2021, 9, 12, 18, 30, 25), "American disaster film of 1997, directed by James Cameron, which uses the sinking of the legendary Titanic",null),
            new Film(2, "Avatar",16,70, new DateTime(2021, 2, 10, 19, 30, 25), new DateTime(2021, 10, 22, 20, 30, 25), "Is a 2009 American sci-fi film written and directed by James Cameron, starring Sam Worthington and Zoe Saldana.",null) };
            return films;
        }
        public static void FillTheFilmScreenings(ref Film[] films, Hall hall1, SeatPlace[] seatPlaces1)
        {

            for(int i = 0; i < films.Length; i++) 
            { 
                films[i].FilmScreenings = new FilmScreening[1] { new FilmScreening(i+1, films[i], hall1, seatPlaces1, new DateTime(2021, 2, 25+i, 18, 30, 00)), };
            }
        }
        public static void FillTheFilmScreenings_2(ref Film[] films, Hall hall2, SeatPlace[] seatPlaces2)
        {

            for (int i = 0; i < films.Length; i++)
            {
                films[i].FilmScreenings = new FilmScreening[1] { new FilmScreening(i + 1, films[i], hall2, seatPlaces2, new DateTime(2021, 2, 25 + i, 18, 30, 00)), };

            }
        }

        public static Viewer FillViewer_1(Viewer viewer1)
        {
            viewer1.Age = 18;
            viewer1.FirstName = "Myroslav";
            viewer1.LastName = "Havrushko";
            return viewer1;
        }

        public static Ticket  FillTicket_1(Ticket ticket1, FilmScreening[] filmScreenings, Seat[] seats, Viewer viewer1)
        {
            ticket1.Number = 224456789;
            ticket1.FilmScreening = filmScreenings[0];
            ticket1.Seat = seats[2];
            ticket1.Price = 90;
            ticket1.Viewer = viewer1;
            return ticket1;
        }
    }
}

