using System;
namespace FinalProject
{
    public class VipSeat : Seat, IShortInfo
    {
        public decimal Price { get; set; }

        public VipSeat()
        {
        }

        public VipSeat(decimal price)
        {
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Seat number: {Number}, price : {Price}";
        }

        public string ToShortString()
        {
            return $"Number seat :{Number}";
        }

    }
}
