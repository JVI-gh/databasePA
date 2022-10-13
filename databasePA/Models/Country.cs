using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace databasePA.Models
{
    public class Country
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }

    }

}
