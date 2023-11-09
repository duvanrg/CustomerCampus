using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;
public partial class StateRepository : GenericRepository<State>, IState
{
    public StateRepository(CampusContext context) : base(context)
    {
    }
}
