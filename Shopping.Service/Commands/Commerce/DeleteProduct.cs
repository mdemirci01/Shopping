﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Delete, "Ürün silindi.")]
    public class DeleteProduct : Command
    {
        public string Id { get; set; }
    }
}
