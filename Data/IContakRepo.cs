using System.Collections.Generic;
using Contak.Models;

namespace Contak.Data
{
    public interface IContakRepo
    {
        IEnumerable <Contact> GetAllContacts();
        Contact GetContactById(int id);
    }
}