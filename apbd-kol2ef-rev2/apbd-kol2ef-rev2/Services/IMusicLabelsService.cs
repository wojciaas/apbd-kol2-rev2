using apbd_kol2ef_rev2.DTOs;

namespace apbd_kol2ef_rev2.Services
{
    public interface IMusicLabelsService
    {
        public Task<MuzykResponseDto> GetMuzykByIdAsync(int id);
    }
}