using System;
namespace FinalProject
{
    public class SeatPlace : Seat, IShortInfo
    {
        public bool Busy { get; set; }
        public SeatPlace()
        {
        }
        public SeatPlace(bool busy)
        {
            this.Busy = busy;
        }
        public override string ToString()
        {
            return $"This seat is busy: {Busy}";
            
        }
        public string ToShortString()
        {
            return $"Busy: {Busy}";
        }
    }
}
