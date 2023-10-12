using bwaAvernus.Shared._1._Master;
using bwaCrixalis.Client._1._Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bwaAvernus._1._Master
{
    public class uimT3Rute : T3Rute
    {
        public Guid? IdCustomer => T2AlamatCustomer.IdCustomer;
        public uimT1CustomerInstansi? T1CustomerInstansi { get; set; }

    }
}
