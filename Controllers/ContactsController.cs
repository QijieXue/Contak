using System.Collections.Generic;
using AutoMapper;
using Contak.Data;
using Contak.Dtos;
using Contak.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contak.Controllers
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContakRepo _repository;
        private readonly IMapper _mapper;

        public ContactsController(IContakRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //GET api/contacts
        [HttpGet]
        public ActionResult<IEnumerable<ContactReadDto>> GetAllContacts()
        {
            var contactItems = _repository.GetAllContacts();

            return Ok(_mapper.Map<IEnumerable<ContactReadDto>>(contactItems));
        }

        //GET api/contacts/{id}
        [HttpGet("{id}")]
        public ActionResult <ContactReadDto> GetContactById(int id)
        {
            var contactItem = _repository.GetContactById(id);
            if(contactItem != null)
            {
                return Ok(_mapper.Map<ContactReadDto>(contactItem));
            }
            return NotFound();            
        }
    }
}