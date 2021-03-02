using System;
namespace FinalProject
{
    public class NormalSeat : Seat, IShortInfo
    {
        public decimal Price { get; set; }
        public NormalSeat()
        {
        }
        public NormalSeat(decimal price)
        {
            this.Price = price;
        }

        public string ToShortString()
        {
            return $"Price : {Price}" ;
        }

        public override string ToString()
        {
            return $"Seat number: {Number}, price : {Price}";
        }
    }
}
