namespace apbd_kol2ef_rev2.DTOs
{
    public record MuzykResponseDto(
        int IdMuzyk,
        string Imie,
        string Nazwisko,
        string? Pseudonim,
        ICollection<UtworResponseDto> Utwory
        );
}