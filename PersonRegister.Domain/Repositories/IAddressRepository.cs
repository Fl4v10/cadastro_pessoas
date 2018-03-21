﻿using PersonRegister.Domain.Entities;
using System.Collections.Generic;

namespace PersonRegister.Domain.Repositories
{
    public interface IAddressRepository
    {
        ICollection<Address> Get();
        Address Get(int id);
        int Insert(Address address);
        Address Update(Address address);
        int Delete(int id);
    }
}
