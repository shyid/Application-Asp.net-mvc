using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticket.Models
{
    public class MemberShipType
    {
        public byte Id {get;set;}
        public short SignUpfee {get;set;}
        public byte DurationInMonth {get;set;}
        public byte DisCountRate {get;set;}
    }
}