using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;
public class CountryRepository : GenericRepository<Country>, ICountry
{
    public CountryRepository(CampusContext context) : base(context)
    {
    }
}
