using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categotyDal;

        public CategoryManager(ICategoryDal categotyDal)
        {
            _categotyDal = categotyDal;
        }

        public List<Category> GetAll()
        {
            return _categotyDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _categotyDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
