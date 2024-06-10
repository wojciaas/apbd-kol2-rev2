using apbd_kol2ef_rev2.Entities;

namespace apbd_kol2ef_rev2.Repositories
{
    public interface IMuzykRepository
    {
        public Task<Muzyk?> GetMuzykByIdAsync(int id);
    }
}