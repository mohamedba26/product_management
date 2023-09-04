using chaabene.Models;

namespace chaabene.Service.OfferDetail_Service
{
    public interface IOfferDetailService
    {
        bool AddUpdateOfferDetail(OfferDetail offerDetail);
        bool DeleteOfferDetail(int id);
        OfferDetail GetOfferDetailById(int id);
        List<OfferDetail> GetAllOfferDetails();
    }
}
