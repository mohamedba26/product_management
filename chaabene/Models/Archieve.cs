namespace chaabene.Models
{
    public class Archieve
    {
        public int Id { get; set; }
        public DateTime Archive { get; set; }
        public int offerId { get; set; }
        public Offer offer { get; set; }
    }
}
