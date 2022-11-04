using Human.EntityFrameworkCore;
using Species.Organisms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;

namespace Human.Humanity
{
    public class EfCoreHumanRepository : EfCoreOrganismRepository<Human, HumanDbContext>, IHumanRepository
    {
        public EfCoreHumanRepository(IDbContextProvider<HumanDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
