using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MQT.API.Models
{
    public class Product
    {
    
        public int Id { get; set; }
        public string name { get; set; }

        public string region   { get; set;}
        public string? Description { get; set; }
        public string Category  {get; set;}


        public string ReasonForBoycott { get; set; }
        public string? [] Alternatives { get; set; }
        public ContactInformation? contactInformation { get; set; }
        



    }
}