using System;
namespace FinalProject
{
    public abstract class Seat
    {
        public int Number { get; set; }

        public Seat()
        {
        }

        public Seat(int number)
        {
            this.Number = number;
        }
    }
}
