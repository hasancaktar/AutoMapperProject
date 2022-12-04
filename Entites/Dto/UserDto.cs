using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Dto
{
    public class UserDto
    {
        public string Name { get; set; }
        public int Status { get; set; }
        
    }
    public enum StatusCode
    {
        success = 1,
        pemding = 0,
        error = -1,

    }
}
