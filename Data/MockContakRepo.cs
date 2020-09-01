using System.Collections.Generic;
using Contak.Models;

namespace Contak.Data
{
    public class MockContakRepo : IContakRepo
    {
        public void CreateContact(Contact contact)
        {
            
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            var contacts = new List<Contact>
            {
                new Contact{
                    Id = 0,
                    Name = "Zhansan",
                    FamilyName = "Zhang",
                    Address = "Xixi",
                    Email = "zhangsan@163.com",
                    Phone = "1220003333",
                    Description = "Family"
                },
                new Contact{
                    Id = 1,
                    Name = "Lisi",
                    FamilyName = "Li",
                    Address = "Xixi",
                    Email = "lisi@163.com",
                    Phone = "1220003332",
                    Description = "Family"
                },
                new Contact{
                    Id = 2,
                    Name = "Wangwu",
                    FamilyName = "Wang",
                    Address = "Xixi",
                    Email = "wangwu@163.com",
                    Phone = "1220003331",
                    Description = "Family"
                },
            };

            return contacts;
        }

        public Contact GetContactById(int id)
        {
            return new Contact{
                Id = 0,
                Name = "Zhansan",
                FamilyName = "Zhang",
                Address = "Xixi",
                Email = "zhangsan@163.com",
                Phone = "1220003333",
                Description = "Family"
            };
        }

        public bool SaveChanges()
        {
            return false;
        }

        public void UpdateContact(Contact contact)
        {
            //Nothing
        }
    }
}