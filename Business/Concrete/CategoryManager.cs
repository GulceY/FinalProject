using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IDataResult<List<Category>> GetAll()
        {

            return new SuccessDataResult<List<Category>>(_categotyDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categotyDal.Get(c => c.CategoryId == categoryId));
        }
    }
}
