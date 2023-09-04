namespace chaabene.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public int offerDetailId { get; set; }
        public OfferDetail offerDetail { get; set;}
        public override string ToString()
        {
            return $"{Id} - {date.ToShortDateString()}";
        }
    }
}
