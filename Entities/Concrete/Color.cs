
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Color:IEntity
    {
        public int Id { get; set; }
        public String ColorName { get; set; }
    }
}
