using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NobelBackend.Models.Dtos
{
    public class LaureateDto
    {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string bornCountry { get; set; }


    }
}