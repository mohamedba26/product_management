using chaabene.Models;
using Microsoft.EntityFrameworkCore;

namespace chaabene.Service.Offer_Service
{
	public class OfferService:IOfferService
	{
		private readonly DataContext _dataContext;
		public OfferService(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public bool AddUpdateOffer(Offer offer)
		{
			try
			{
				if (offer.Id == 0)
				{
					_dataContext.Offers.Add(offer);
				}
				else
				{
					_dataContext.Offers.Update(offer);
				}
				_dataContext.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public bool DeleteOffer(int id)
		{
			try
			{
				var offer = GetOfferById(id);
				if (offer == null)
					return false;
				_dataContext.Offers.Remove(offer);
				_dataContext.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public List<Offer> GetAllOffers()
		{
			return _dataContext.Offers.Include(offer => offer.offerDetail).ThenInclude(offerDetail => offerDetail.product).ToList();
		}

		public Offer GetOfferById(int id)
		{
			return _dataContext.Offers.Find(id);
		}
	}
}
