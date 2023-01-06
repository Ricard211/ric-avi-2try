using Microsoft.EntityFrameworkCore;
using ric_avi_iskfu19.DataModels;
using ric_avi_iskfu19.Models;
using ric_avi_iskfu19.Controller;

namespace ric_avi_iskfu19.Services;
public class HelmService{

    private readonly HelmetContext _dbContext;

    public HelmService(HelmetContext dbContext){
        _dbContext = dbContext;
    }

    public async Task <List<Helmet>> GetHelmet(){
        var helmets = await _dbContext.Helmets.ToListAsync();
        return helmets;
    }

    public async Task <Helmet> GetHelmetId(int id){
        var helmets = await _dbContext.Helmets.Where(x => x.helmetid == id).FirstOrDefaultAsync();
        return helmets;
    }

    public async Task<Helmetmaker> Create(Helmetmaker helmetmaker)
    {
        
        var helmets = new Helmet(helmetmaker);
        var helmet =await _dbContext.Helmets.AddAsync(helmets);
        await _dbContext.SaveChangesAsync();
        return helmetmaker;
    }
}