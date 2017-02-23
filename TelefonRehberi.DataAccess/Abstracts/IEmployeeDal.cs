using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Core.EfRepository;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.DataAccess.Abstracts
{
    public interface IEmployeeDal : IEntityRepository<Employee>
    {
    }
}
