﻿using eKiwiTradeApi.Data.Entity;

namespace eKiwiTradeApi.Logic.Interface
{
    public interface ILookupRepository
    {
        Task<List<Category>> GetAllCategoryLookup();

       // Task<string> GetFieldLookup(int id);

    }
}