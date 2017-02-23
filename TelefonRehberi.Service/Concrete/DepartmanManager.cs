using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.DataAccess.Abstracts;
using TelefonRehberi.Entities.Concrete;
using TelefonRehberi.Service.Abstracts;

namespace TelefonRehberi.Service.Concrete
{
    public class DepartmanManager : IDepartmanService
    {
        private IDepartmanDal _departmanDal;
        public DepartmanManager(IDepartmanDal departmanDal)
        {
            _departmanDal = departmanDal;
        }

        public void Add(Departman departman)
        {
            _departmanDal.Add(departman);
        }

        public void Delete(int departmanId)
        {
            _departmanDal.Delete(new Departman { Id = departmanId });
        }

        public List<Departman> GetAll()
        {
            return _departmanDal.GetList();
        }

        public List<Departman> GetByDepartman(int departmanId)
        {
            return _departmanDal.GetList(x => x.Id == departmanId);
        }

        public Departman GetById(int departmanId)
        {
            return _departmanDal.Get(x => x.Id == departmanId);
        }

        public void Update(Departman departman)
        {
            _departmanDal.Update(departman);
        }
    }
}
