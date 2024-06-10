using apbd_kol2ef_rev2.Entities;

namespace apbd_kol2ef_rev2.Services
{
    public interface IMuzykService
    {
        public Task<Muzyk> GetMuzykByIdAsync(int id);
    }
}