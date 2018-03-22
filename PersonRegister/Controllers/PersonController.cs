﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PersonRegister.Domain.Entities;
using PersonRegister.Domain.Repositories;

namespace PersonRegister.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        [Route("person")]
        public IEnumerable<Person> Get([FromServices]IPersonRepository repository, string search, int pageSize = 10)
        {
            return repository.Get(search, pageSize);
        }

        [HttpGet]
        [Route("person/{id}")]
        public Person Get(int id, [FromServices]IPersonRepository repository)
        {
            try
            {
                return repository.Get(id);  
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("person")]
        public void Post([FromBody]Person model, [FromServices]IPersonRepository repository)
        {
            try
            {
                repository.Insert(model);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [HttpPut]
        [Route("person")]
        public void Put([FromBody]Person model, [FromServices]IPersonRepository repository)
        {
            try
            {
                repository.Update(model);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        [HttpDelete]
        [Route("person/{id}")]
        public void Delete(int id, [FromServices]IPersonRepository repository)
        {
            try
            {
                repository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}