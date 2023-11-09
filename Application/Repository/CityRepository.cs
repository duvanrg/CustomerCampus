using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;
public class CityRepository : GenericRepository<City>, ICity
{
    public CityRepository(CampusContext context) : base(context)
    {
    }
}
