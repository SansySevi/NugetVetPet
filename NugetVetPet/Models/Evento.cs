﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetVetPet.Models
{
    [Table("V_EVENTOS")]
    public class Evento
    {
        [Key]
        [Column("ID")]
        public int id { get; set; }

        [Column("TITLE")]
        public string title { get; set; }

        [Column("START")]
        public DateTime start { get; set; }

        [Column("IDUSUARIO")]
        public int resourceid { get; set; }
    }
}

