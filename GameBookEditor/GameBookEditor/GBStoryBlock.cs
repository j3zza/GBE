using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBookEditor
{
    class GBStoryBlock
    {
        public int Id { get; set; }
        public String Text { get; set; }
        public List<GBStoryBlockChoice> Choices { get; set; }
    }
}
