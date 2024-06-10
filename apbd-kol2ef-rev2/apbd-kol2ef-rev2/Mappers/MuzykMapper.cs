using apbd_kol2ef_rev2.DTOs;
using apbd_kol2ef_rev2.Entities;

namespace apbd_kol2ef_rev2.Mappers
{
    public static class MuzykMapper
    {
        public static MuzykResponseDto MapToResponseModel(this Muzyk muzyk)
        {
            return new MuzykResponseDto(
                IdMuzyk:muzyk.IdMuzyk,
                Imie:muzyk.Imie,
                Nazwisko:muzyk.Nazwisko,
                Pseudonim:muzyk.Pseudonim,
                Utwory:muzyk.WykonawcyUtwory.Select(wu => wu.UtworNavigation.MapToResponseModel()).ToList()
            );
        }
    }
}