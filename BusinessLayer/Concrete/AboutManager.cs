using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal; //Dependency Injection: Gelen entity'yi karşılamak.
                             //Gelen entity'ye ait repolara ulaşmak için kullanılır. Bunun için ctor metoda ihtiyaç var.
        public AboutManager(IAboutDal aboutDal)
        {

            _aboutDal = aboutDal;

        }
        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
