using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQT.API.Models
{
    public class Star
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string region { get; set; }
        
        public ContactInformation contactInformation { get; set; }  
        
    }
}