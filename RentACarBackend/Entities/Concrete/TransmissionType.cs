using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TransmissionType:IEntity
    {
        public int TransmissionTypeId { get; set; }
        public string TransmissionTypeName { get; set; }
    }
}
