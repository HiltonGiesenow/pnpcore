﻿using PnP.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PnP.Core.Model
{
    /// <summary>
    /// Defines the very basic interface for every collection of Domain Model objects
    /// </summary>
    /// <typeparam name="TModel">The actual type of the Domain Model objects</typeparam>
    public interface IDataModelCollection<TModel> : IEnumerable<TModel>, IDataModelParent, IDataModelWithContext, IRequestableCollection
    {
       
    }
}
