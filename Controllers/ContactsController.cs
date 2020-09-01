using System;
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
        [HttpGet("{id}", Name="GetContactById")]
        public ActionResult <ContactReadDto> GetContactById(int id)
        {
            var contactItem = _repository.GetContactById(id);
            if(contactItem != null)
            {
                return Ok(_mapper.Map<ContactReadDto>(contactItem));
            }
            return NotFound();            
        }

        //POST api/contacts
        [HttpPost]
        public ActionResult <ContactReadDto> CreateContact(ContactCreateDto contactCreateDto)
        {
            var contactModel = _mapper.Map<Contact>(contactCreateDto);
            _repository.CreateContact(contactModel);
            _repository.SaveChanges();

            return CreatedAtRoute(nameof(GetContactById), new {Id = contactModel.Id}, _mapper.Map<ContactReadDto>(contactModel));
        }

        //PUT api/contact/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateContact(int id, ContactUpdateDto contactUpdateDto)
        {
            var contactModelFromRepo = _repository.GetContactById(id);
            if(contactModelFromRepo == null)
                return NotFound();
            _mapper.Map(contactUpdateDto, contactModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}