using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Buffers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MQT.Core.Models;

namespace MQT.EF
{
    public class MqtDbContext : DbContext
    {
        public MqtDbContext( DbContextOptions <MqtDbContext> options) : base(options)
        {
              
        }
        

        
    }
}