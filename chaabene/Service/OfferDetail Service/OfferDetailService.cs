using chaabene.Models;
using Microsoft.EntityFrameworkCore;

namespace chaabene.Service.OfferDetail_Service
{
    public class OfferDetailService : IOfferDetailService
    {
        private readonly DataContext _dataContext;
        public OfferDetailService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool AddUpdateOfferDetail(OfferDetail offerDetail)
        {
            try
            {
                if (offerDetail.Id == 0)
                {
                    _dataContext.OfferDetails.Add(offerDetail);
                }
                else
                {
                    _dataContext.OfferDetails.Update(offerDetail);
                }
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteOfferDetail(int id)
        {
            try
            {
                var offerDetail = GetOfferDetailById(id);
                if (offerDetail == null)
                    return false;
                _dataContext.OfferDetails.Remove(offerDetail);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<OfferDetail> GetAllOfferDetails()
        {
            return _dataContext.OfferDetails.Include(od => od.product).ToList();
        }

        public OfferDetail GetOfferDetailById(int id)
        {
            return _dataContext.OfferDetails.Find(id);
        }
    }
}
