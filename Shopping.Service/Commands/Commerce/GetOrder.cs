﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Read, "Bir sipariş getirir.")]
    public class GetOrder : Command
    {
        public string Id { get; set; }
    }
}
