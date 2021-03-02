using System;

namespace FinalProject
{
    class MainClass
    {
        static Cinema cinema1;
        static Cinema cinema2;
        public static void Main(string[] args)
        {
             cinema1 = CinemaFactory.CreateCinema("Multiplex_One", CinemaFactory.FillTheFilms(), CinemaFactory.FillHall_1(), new Ticket[10]);
             cinema2 = CinemaFactory.CreateCinema_2("Multiplex_Two", CinemaFactory.FillTheFilms_2(), CinemaFactory.FillHall_2(), new Ticket[12]);

            Show_MailMenu(cinema1,cinema2);
        
        }
        public static void Show_MailMenu(Cinema cinema1,Cinema cinema2)
        {
            Console.Clear();
            Console.WriteLine("--------------Cinema--------------");
            Console.WriteLine("-----=|Main Menu|=-----");
            Console.WriteLine("Choose a cinema:");
            Console.WriteLine($"1. {cinema1}");
            Console.WriteLine($"2. {cinema2}");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Show_Films(cinema1);
                        break;
                    case 2:
                        Show_Films(cinema2);
                        break;
                    default:
                        Console.WriteLine("Wrong choice! Press any key");
                        Console.ReadLine();
                        Show_MailMenu(cinema1, cinema2);
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Invalid entry, please try again! Press any key");
                Console.ReadKey();
                Show_MailMenu(cinema1, cinema2);
            }
        }
        public static void Buy_Ticket_menu(Cinema cinema, int filmId, int screeningId, int seatId)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Enter your ticket purchase information:\n");
            try
            {
                Console.Write("Enter first name:");
                string firstName = Console.ReadLine();
                Console.Write("Enter last name:");
                string lastName = Console.ReadLine();
                Console.Write("Enter age:");
                int age = Convert.ToInt32(Console.ReadLine());
                Viewer viewer = new Viewer((sbyte)age, firstName, lastName);
                cinema.BuyTicket(filmId, screeningId, seatId, cinema.GetFilmScreeningPrice(filmId, screeningId, seatId), viewer);
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("Press any button to exit to the menu");
                Console.ReadKey();
            }
           catch 
            {
                Console.WriteLine("Invalid entry, please try again! Press any key");
                Console.ReadKey();
                Buy_Ticket_menu(cinema, filmId, screeningId, seatId);
                return;
            }
            Show_MailMenu(cinema1,cinema2);
        } 
        public static void Show_Seat(Cinema cinema, int NumberFilm, int NumerScreenings)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Select a seat:");
            int i = 1;
            try
            {
                foreach (SeatPlace seat in cinema.Films[NumberFilm].FilmScreenings[NumerScreenings].SeatPlaces)
                {
                    Console.WriteLine($"#{i++}" + " " + seat.ToString());
                }
                Console.WriteLine("------------------------------------------------------------------");
                int choice = Convert.ToInt32(Console.ReadLine()) - 1;
                if (choice >= 10  || choice < 0)
                {
                    Console.WriteLine("Invalid entry, please try again! Press any key");
                    Console.ReadKey();
                    Show_Seat(cinema, NumberFilm, NumerScreenings);
                    throw new Exception("Invalid entry");
                }
                else
                    Buy_Ticket_menu(cinema, NumberFilm, NumerScreenings, choice);
            }
            catch
            {
                 Console.WriteLine("Invalid entry, please try again! Press any key");
                 Console.ReadKey();
                Show_Seat(cinema, NumberFilm, NumerScreenings);
            }
        }
        public static void Show_Films(Cinema cinema)
        {
            Console.Clear();
            Console.WriteLine("Choose a movie:");
            Console.WriteLine("------------------------------------------------------------------");
            try
            {
                foreach (Film film in cinema.GetFilms())
                {
                    Console.WriteLine(film.ToString());
                    //Console.WriteLine(film.ToShortString());
                }
                int choice = Convert.ToInt32(Console.ReadLine()) - 1;
                if (choice > cinema.GetFilms().Length - 1 || choice < 0)
                {
                    Console.WriteLine("Invalid entry, please try again! Press any key");
                    Console.ReadKey();
                    Show_Films(cinema);
                    return;
                }
                Console.WriteLine("------------------------------------------------------------------");
                Show_FilmScreening(cinema, choice);
            }
            catch
            {
                Console.WriteLine("Invalid entry, please try again! Press any key");
                Console.ReadKey();
                Show_Films(cinema);
            }
        }
        public static void Show_FilmScreening(Cinema cinema,int numFilm)
        {
            Console.Clear();
            Console.WriteLine("Select movie screening:");
            Console.WriteLine("------------------------------------------------------------------");
            try
            {
                int i = 1;
                Hall[] hall1 = CinemaFactory.FillHall_1();
                Hall[] hall2 = CinemaFactory.FillHall_2();
                foreach (FilmScreening filmScreening in cinema.Films[numFilm].FilmScreenings)
                {
                    Console.WriteLine("Type of halls: \n");
                    Console.WriteLine($"{hall1[0].ToString()}\n{hall2[0].ToString()}\n");
                    //Console.WriteLine($"{hall1[0].ToShortString()}\n {hall2[0].ToShortString()}");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine($"№{i++}:" + " " + filmScreening.ToString());
                    //Console.WriteLine(filmScreening.ToShortString());
                }
                int choice = Convert.ToInt32(Console.ReadLine()) - 1;
                if (choice > cinema.Films[numFilm].FilmScreenings.Length - 1 || choice < 0)
                {
                    Console.WriteLine("Invalid entry, please try again! Press any key");
                    Console.ReadKey();
                    Show_FilmScreening(cinema, numFilm);
                    return;
                }
                Console.WriteLine("------------------------------------------------------------------");
                Show_Seat(cinema, numFilm, choice);
            }
            catch
            {
                Console.WriteLine("Invalid entry, please try again! Press any key");
                Console.ReadKey();
                Show_FilmScreening(cinema, numFilm);
            }
            
        }
    }
}
