global using SQLite;
global using System;
global using System.Collections.Generic;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;

namespace bwaAvernus.Shared._1._Master
{
    public class T5DokumenRute : BaseModelMasterDetil
    {
		public string JenisDokumen { get; set; }
		public Guid IdRute { get; set; }
        
        [ForeignKey("IdRute")]
        public T3Rute? T3Rute { get; set; }
    }

}
