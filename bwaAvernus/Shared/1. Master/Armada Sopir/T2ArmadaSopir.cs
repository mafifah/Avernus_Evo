using bwaCrixalis.Shared._1._Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bwaAvernus.Shared._1._Master.Armada_Sopir
{
    public class T2ArmadaSopir : BaseModelMasterDetil
    {
        [Key]
        [PrimaryKey]
        [Column(Order = 0)]
        public Guid IdArmadaSopir { get; set; }
        public Guid? IdArmada { get; set; }
        public Guid? IdKaryawan_Sopir { get; set; }
        public bool? IsDefault { get; set; }
        //public Guid? IdOperator { get; set; }
        //public string? Synchronise { get; set; }
        [ForeignKey("IdArmada")]
        public T1Armada? T1Armada { get; set; }

        [ForeignKey("IdKaryawan_Sopir")]
        public pthT1Karyawan? T1Karyawan_Sopir { get; set; }
    }
}
