using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firstproject.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Make Make { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Make")]
        public int MakeId { get; set; }
    }
}
