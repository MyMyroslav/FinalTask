using System;
namespace FinalProject
{
    public class Hall : IShortInfo
    {
        public int Number { get; set; }
        public int SeatsNumber { get; set; }
        public Seat[] Seats { get; set; }
        public decimal Price { get; set; }

        public Hall()
        {
        }

        public Hall(int number, int seatsNumber, Seat[] seats, decimal price)
        {
            this.Number = number;
            this.SeatsNumber = seatsNumber;
            this.Price = price;
            this.Seats = seats;
        }
        public override string ToString()
        {
            string name = null;
            if (Number == 1)
            {
                name = "NormalHall";
            }
            else
            {
                name = "VipHall";
            }
            return $"Number of hall: {Number}, Name:{name}, Count of places: {SeatsNumber}, Price: {Price}";
        }

        public string ToShortString()
        {
            return $"Hall# {Number}, where are {SeatsNumber} places.";
        }
    }
}
