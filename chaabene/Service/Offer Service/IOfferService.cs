using chaabene.Models;

namespace chaabene.Service.Offer_Service
{
	public interface IOfferService
	{
		bool AddUpdateOffer(Offer offer);
		bool DeleteOffer(int id);
		Offer GetOfferById(int id);
		List<Offer> GetAllOffers();
	}
}
