using apbd_kol2ef_rev2.Entities;
using apbd_kol2ef_rev2.Exceptions;
using apbd_kol2ef_rev2.Repositories;

namespace apbd_kol2ef_rev2.Services
{
    public class MuzykService : IMuzykService
    {
        private readonly IMuzykRepository _muzykRepository;

        public MuzykService(IMuzykRepository muzykRepository)
        {
            _muzykRepository = muzykRepository;
        }

        public async Task<Muzyk> GetMuzykByIdAsync(int id)
        {
            Muzyk? muzyk = await _muzykRepository.GetMuzykByIdAsync(id);
            EnsureMuzykExist(muzyk, id);
            return muzyk!;
        }

        public void EnsureMuzykExist(Muzyk? muzyk, int id)
        {
            if (muzyk == null)
            {
                throw new DomainException($"Muzyk with id={id} does not exists");
            }
        }
    }
}