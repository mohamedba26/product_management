using chaabene.Models;

namespace chaabene.Service.Archieve_Service
{
    public interface IArchieveService
    {
        bool AddUpdateArchieve(Archieve archieve);
        bool DeleteArchieve(int id);
        Archieve GetArchieveById(int id);
        List<Archieve> GetAllArchieves();

    }
}
