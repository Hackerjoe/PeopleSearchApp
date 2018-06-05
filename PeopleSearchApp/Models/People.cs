using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleSearch.Models
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Interest { get; set; }

    }
}
