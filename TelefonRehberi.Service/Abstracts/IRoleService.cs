using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.Service.Abstracts
{
    public interface IRoleService
    {
        List<Role> GetAll();

        List<Role> GetByRole(int roleId);

        void Add(Role role);

        void Update(Role role);

        void Delete(int roleId);

        Role GetById(int roleId);

    }
}
