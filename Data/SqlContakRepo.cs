using System.Collections.Generic;
using System.Linq;
using Contak.Models;

namespace Contak.Data
{
    public class SqlContakRepo : IContakRepo
    {
        private readonly ContakContext _context;

        public SqlContakRepo(ContakContext context)
        {
            _context = context;
        }

        public void CreateContact(Contact contact)
        {
            _context.Add(contact);
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _context.Contacts.ToList();
        }

        public Contact GetContactById(int id)
        {
            return _context.Contacts.FirstOrDefault(ct => ct.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateContact(Contact contact)
        {
            //Nothing
        }
    }
}