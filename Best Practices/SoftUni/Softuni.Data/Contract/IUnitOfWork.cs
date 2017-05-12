using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softuni.Data.Contract
{
    interface IUnitOfWork 
    {
        void Save();
    }
}
