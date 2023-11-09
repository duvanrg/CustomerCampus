﻿using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;
public partial class PersonTypeRepository : GenericRepository<PersonType>, IPersonType
{
    public PersonTypeRepository(CampusContext context) : base(context)
    {
    }
}
