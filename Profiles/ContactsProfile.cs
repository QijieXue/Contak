using AutoMapper;
using Contak.Dtos;
using Contak.Models;

namespace Contak.Profiles
{
    public class ContactsProfile : Profile
    {
        public ContactsProfile()
        {
            CreateMap<Contact, ContactReadDto>();
        }        
    }
}