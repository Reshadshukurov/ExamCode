using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamCode.Models
{
    public class Service:BaseEntity
    {
        public string Icon { get; set; }
        public string Subtitle { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }
        
    }
}
