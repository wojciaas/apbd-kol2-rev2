using apbd_kol2ef_rev2.DTOs;
using apbd_kol2ef_rev2.Entities;

namespace apbd_kol2ef_rev2.Mappers
{
    public static class UtworMapper
    {
        public static UtworResponseDto MapToResponseModel(this Utwor utwor)
        {
            return new UtworResponseDto(
                IdUtwor:utwor.IdUtwor,
                NazwaUtworu:utwor.NazwaUtworu,
                CzasTrwania:utwor.CzasTrwania
                );
        }
    }
}