using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace AccessModifiers
{
    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
            ModifiedDataAccess data = new ModifiedDataAccess();

            data.GetUnsecureConnectionInfo();
        }
    }
}
