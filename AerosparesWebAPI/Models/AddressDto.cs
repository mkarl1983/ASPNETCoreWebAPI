using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AerosparesWebAPI.Models
{
    public class AddressDto
    {
       
        public string city { get; set; }
        public string postcode { get; set; }

    }


    public class Root
    {
        public List<Result> results { get; set; }
       
    }
    public class Result
    {
        public AddressDto location { get; set; }
    }

}
