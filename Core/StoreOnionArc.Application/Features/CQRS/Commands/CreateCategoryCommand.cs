﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOnionArc.Application.Features.CQRS.Commands
{
    public class CreateCategoryCommand
    {
        public string CategoryName { get; set; }
    }
}
