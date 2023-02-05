using Business.Abstract.Interfaces;
using Business.Constans;
using Businesss.Abstract.Interfaces;
using Entitiess.Abstract.Base;
using Model.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Businesss.Abstract.Base
{
    public class BaseHareketBll<T, TContext> : IBaseBll , IBaseHareketGenelBll where T : BaseHareketEntity where TContext : DbContext
    {
        private IUnitOfWork<T> _uow;

        public IQueryable<TResult> List<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Select(filter, selector);

        }

        public bool Insert(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            _uow.Rep.Insert(entities.EntityListConvert<T>());
            return _uow.save();
        }

        public bool Update(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            _uow.Rep.Update(entities.EntityListConvert<T>());
            return _uow.save();
        }

        public bool Delete(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);

            _uow.Rep.Delete(entities.EntityListConvert<T>());
            return _uow.save();
        }

        public void Dispose()
        {
            _uow?.Dispose();
        }
    }
}

