using Application.Repository;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly CampusContext _context;
        private CityRepository _Cities;
        private CountryRepository _Countries;
        private CustomerRepository _Customers;
        private PersonTypeRepository _PersonTypes;
        private StateRepository _States;

        public UnitOfWork(CampusContext context)
        {
            _context = context;
        }
        public ICity Cities
        {
            get
            {
                if(_Cities == null) _Cities = new CityRepository(_context);
                return _Cities;
            }
        }
        public ICountry Countries
        {
            get
            {
                if(_Countries == null) _Countries = new CountryRepository(_context);
                return _Countries;
            }
        }
        public ICustomer Customers
        {
            get
            {
                if(_Customers == null) _Customers = new CustomerRepository(_context);
                return _Customers;
            }
        }
        public IPersonType PersonTypes
        {
            get
            {
                if(_PersonTypes == null) _PersonTypes = new PersonTypeRepository(_context);
                return _PersonTypes;
            }
        }
        public IState States
        {
            get
            {
                if(_States == null) _States = new StateRepository(_context);
                return _States;
            }
        }
        
        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}