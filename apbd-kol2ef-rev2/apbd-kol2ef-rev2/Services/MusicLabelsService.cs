using apbd_kol2ef_rev2.DTOs;
using apbd_kol2ef_rev2.Entities;
using apbd_kol2ef_rev2.Mappers;

namespace apbd_kol2ef_rev2.Services
{
    public class MusicLabelsService : IMusicLabelsService
    {
        private readonly IMuzykService _muzykService;

        public MusicLabelsService(IMuzykService muzykService)
        {
            _muzykService = muzykService;
        }

        public async Task<MuzykResponseDto> GetMuzykByIdAsync(int id)
        {
            Muzyk muzyk = await _muzykService.GetMuzykByIdAsync(id);
            return muzyk.MapToResponseModel();
        }
    }
}