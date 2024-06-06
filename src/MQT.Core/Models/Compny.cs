using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQT.API.Models
{
    public class Compny
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? extraInfo { get; set; }
        public string? ReasonForBoycott { get; set; }

        public string region { get; set; }
        public bool IsActive { get; set; } = true;
        
        public ContactInformation contactInformation { get; set; }  
        
    }
}