using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;
public partial class CustomerRepository : GenericRepository<Customer>, ICustomer
{
    public CustomerRepository(CampusContext context) : base(context)
    {
    }
}
