using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _iProductDal;
        public ProductManager(IProductDal iProductDal)
        {
            _iProductDal = iProductDal;
        }

        List<Car> _cars;
        public List<Car> GetAll()
        {
            return _iProductDal.GetAll();
        }
    }
}
