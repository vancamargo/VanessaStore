using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Shared.Commands
{
    public interface ICommand
    {
        bool Valid();
    }
}
