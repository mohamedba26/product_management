using chaabene.Models;
using Microsoft.EntityFrameworkCore;

namespace chaabene.Service.Archieve_Service
{
    public class ArchieveService:IArchieveService
    {
        private readonly DataContext _dataContext;
        public ArchieveService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool AddUpdateArchieve(Archieve archieve)
        {
            try
            {
                if (archieve.Id == 0)
                {
                    _dataContext.Archieves.Add(archieve);
                }
                else
                {
                    _dataContext.Archieves.Update(archieve);
                }
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteArchieve(int id)
        {
            try
            {
                var archieve = GetArchieveById(id);
                if (archieve == null)
                    return false;
                _dataContext.Archieves.Remove(archieve);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Archieve> GetAllArchieves()
        {
            return _dataContext.Archieves.Include(a=>a.offer).ToList();
        }

        public Archieve GetArchieveById(int id)
        {
            return _dataContext.Archieves.Find(id);
        }

    }
}
