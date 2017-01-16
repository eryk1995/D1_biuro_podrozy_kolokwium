using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_biuro_podrozy
{
    interface IData
    {
       void UstawDate(DateTime data);
       bool SprawdzDate();
    }
}
