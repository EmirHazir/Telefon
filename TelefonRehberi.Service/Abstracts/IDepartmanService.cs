using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.Service.Abstracts
{
    public interface IDepartmanService
    {
        List<Departman> GetAll();

        List<Departman> GetByDepartman(int departmanId);

        void Add(Departman departman);

        void Update(Departman departman);

        void Delete(int departmanId);

        Departman GetById(int departmanId);

    }
}
