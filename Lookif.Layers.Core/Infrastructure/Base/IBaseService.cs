﻿using Lookif.Layers.Core.MainCore.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks; 
namespace Lookif.Layers.Core.Infrastructure.Base
{
    public interface IBaseService<T, J>
        where T : class, IEntity<J>
    {
        #region ... Add ...
        Task<T> AddAsync(T t, CancellationToken cancellationToken, bool save = true);
        T Add(T t, bool save = true);
        Task<IEnumerable<T>> AddRangeAsync(List<T> t, CancellationToken cancellationToken, bool save = true);
        #endregion

        #region ... Update ...
        Task<T> UpdateAsync(T t, CancellationToken cancellationToken, bool save = true);
        Task<T> UpdateViaIdAsync(J t, CancellationToken cancellationToken, bool save = true);
        #endregion

        #region ... Delete ...
        Task<T> DeleteAsync(T t, CancellationToken cancellationToken, bool save = true);

        #endregion

        #region ... Projection ...
        IQueryable<T> GetAll();
        Task<List<T>> GetAll(CancellationToken cancellationToken);
        Task<T> GetByIdAsync(J id, CancellationToken cancellationToken);
        Task<List<T>> GetAllByCondition(Expression<Func<T, bool>> condition, CancellationToken cancellationToken);
        IQueryable<T> QueryByCondition(Expression<Func<T, bool>> condition);
        Task<T> ExistAny(Expression<Func<T, bool>> condition, CancellationToken cancellationToken);
        #endregion
    }
}
