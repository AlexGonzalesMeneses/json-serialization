using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Module2
{
    class Program
    {
        private static string path = @"C:\Json Sample\Contacts.json";
        static void Main(string[] args)
        {
            // var contacts = GetContacts();
            // SerializeJsonFile(contacts);

            var contacts = GetContactsJsonFromFile();
            DeserializeJsonFile(contacts);
        }

        public static void SerializeJsonFile(List<Contact> contacts)
        {
            var json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            File.WriteAllText(path, json);    
        }
        public static List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>()
            {
                new Contact()
                {
                    Name = "John",
                    Birthday = new DateTime(1988, 1, 1),
                    Address = new Address()
                    {
                        Street = "123 Main St",
                        Number = 123,
                        City = new City()
                        {
                            Name = "Anytown",
                            Country = new Country()
                            {
                                Name = "USA",
                                Code = "US"
                            }
                        }
                    },
                    Phones = new List<Phone>()
                    {
                        new Phone()
                        {
                            Number = "123-456-7890",
                            Name = "Home",
                        },
                        new Phone()
                        {
                            Number = "098-765-4321",
                            Name = "Work",
                        }
                    }
                },
                new Contact()
                {
                    Name = "Mary",
                    Birthday = new DateTime(1990, 1, 1),
                    Address = new Address()
                    {
                        Street = "456 Main St",
                        Number = 456,
                        City = new City()
                        {
                            Name = "Anytown",
                            Country = new Country()
                            {
                                Name = "USA",
                                Code = "US"
                            }
                        }
                    },
                    Phones = new List<Phone>()
                    {
                        new Phone()
                        {
                            Number = "098-765-4321",
                            Name = "Work",
                        }
                    }
                },
                new Contact()
                {
                    Name = "Bob",
                    Birthday = new DateTime(1980, 11, 1),
                    Address = new Address()
                    {
                        Street = "789 Main St",
                        Number = 789,
                        City = new City()
                        {
                            Name = "Anytown",
                            Country = new Country()
                            {
                                Name = "USA",
                                Code = "US"
                            }
                        }
                    },
                    Phones = new List<Phone>()
                    {
                        new Phone()
                        {
                            Number = "098-765-4321",
                            Name = "Mom",
                        }
                    }
                }
            };
            
            return contacts;
        }
        
        public static string GetContactsJsonFromFile()
        {
            string contactsJson = string.Empty;
            using (StreamReader reader = new StreamReader(path))
            {
                contactsJson = reader.ReadToEnd();
            }
            return contactsJson;
        }

        public static void DeserializeJsonFile(string contactsJson)
        {
            var contacts = JsonConvert.DeserializeObject<List<Contact>>(contactsJson);
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.Name);
            }
        }
    }
}
