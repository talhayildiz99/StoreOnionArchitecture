using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOnionArc.Application.Features.CQRS.Commands.ProductCommands
{
    public class RemoveProductCommand
    {
            public int Id { get; set; }

            public RemoveProductCommand(int ıd)
            {
                Id = ıd;
            }
    }
}
