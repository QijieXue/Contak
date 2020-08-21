using System.Collections.Generic;
using Contak.Data;
using Contak.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contak.Controllers
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContakRepo _repository;

        public ContactsController(IContakRepo repository)
        {
            _repository = repository;
        }
        //GET api/contacts
        [HttpGet]
        public ActionResult<IEnumerable<Contact>> GetAllContacts()
        {
            var contactItems = _repository.GetAllContacts();

            return Ok(contactItems);
        }

        //GET api/contacts/{id}
        [HttpGet("{id}")]
        public ActionResult <Contact> GetContactById(int id)
        {
            var contactItem = _repository.GetContactById(id);
            return Ok(contactItem);
        }
    }
}