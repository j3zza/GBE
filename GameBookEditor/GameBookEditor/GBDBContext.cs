using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GameBookEditor
{
    class GBDBContext : DbContext 
    {

        public GBDBContext() : base("GBDBContext")
        {

        }

        public DbSet<GBStoryBlock> GBStoryBlocks { get; set; }
        public DbSet<GBStoryBlockChoice> GBStoryBlockChoices { get; set; }
    }
}
