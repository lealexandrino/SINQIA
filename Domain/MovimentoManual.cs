﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public partial class MovimentoManual
    {
        public decimal DatMes { get; set; }
        public decimal DatAno { get; set; }
        public decimal NumLancamento { get; set; }
        public string CodProduto { get; set; }
        public string CodCosif { get; set; }
        public decimal ValValor { get; set; }
        public string DesDescricao { get; set; }
        public DateTime DatMovimento { get; set; }
        public string CodUsuarios { get; set; }

        public ProdutoCosif CodCosifNavigation { get; set; }

        [NotMapped]
        public string DesProduto { get; set; }
    }
}
