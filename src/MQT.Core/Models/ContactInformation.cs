using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQT.API.Models
{
    public class ContactInformation
    {
        public string? phoneNumber  { get; set; }
        public string? emailAddress { get; set; }
        public string? websiteUrl { get; set; }

        public string? facebookAcount { get; set; }
        public string? twitterAcount { get; set; }
        public string? instagramAcount { get; set; } 
        public string? LinkedInProfile { get; set; }

    }
}