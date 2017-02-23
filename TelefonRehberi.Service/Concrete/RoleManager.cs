using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.DataAccess.Abstracts;
using TelefonRehberi.Entities.Concrete;
using TelefonRehberi.Service.Abstracts;

namespace TelefonRehberi.Service.Concrete
{
    public class RoleManager : IRoleService
    {
        private IRoleDal _roleDal;
        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void Add(Role role)
        {
            _roleDal.Add(role);
        }

        public void Delete(int roleId)
        {
            _roleDal.Delete(new Role { Id = roleId });
        }

        public List<Role> GetAll()
        {
            return _roleDal.GetList();
        }

        public Role GetById(int roleId)
        {
            return _roleDal.Get(x => x.Id == roleId);
        }

        public List<Role> GetByRole(int roleId)
        {
            return _roleDal.GetList(x => x.Id == roleId);
        }

        public void Update(Role role)
        {
            _roleDal.Update(role);
        }
    }
}
