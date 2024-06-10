using apbd_kol2ef_rev2.Context;
using apbd_kol2ef_rev2.Entities;
using Microsoft.EntityFrameworkCore;

namespace apbd_kol2ef_rev2.Repositories;

public class MuzykRepository : IMuzykRepository
{
    private readonly MusicLabelsDbContext _dbContext;

    public MuzykRepository(MusicLabelsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Muzyk?> GetMuzykByIdAsync(int id)
    {
        return await _dbContext.Muzycy
            .Include(m => m.WykonawcyUtwory)
            .ThenInclude(wu => wu.UtworNavigation)
            .FirstOrDefaultAsync(m => m.IdMuzyk == id);
    }
}