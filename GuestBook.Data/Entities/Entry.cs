using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace GuestBook.Data.Entities
{
    public class Entry
    {
        public Entry()
        {
            EntryDate = DateTime.Now;
        }

        public int EntryId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string EntryTitle { get; set; }
        public string EntryMessage { get; set; }
        public DateTime EntryDate { get; set; }


    }
}
