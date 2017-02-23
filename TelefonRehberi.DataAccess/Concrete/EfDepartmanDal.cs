using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Core.EfRepository;
using TelefonRehberi.DataAccess.Abstracts;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.DataAccess.Concrete
{
    public class EfDepartmanDal : EfRepositoryBase<Departman, TelefonDBContext>,IDepartmanDal
    {
    }
}
