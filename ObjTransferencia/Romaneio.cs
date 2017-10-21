﻿using System;

namespace ObjTransferencia
{
    class Romaneio
    {
        public int IDRomaneio { get; set; };
        public int IDCliente { get; set; };
        public int IDFornecedor { get; set; };
        public int IDFruta { get; set; };
        public int QtdFruta { get; set; };
        public int IDCarregamento { get; set; };
        public decimal ValorFrete { get; set; };
        public decimal AdiantFretMot { get; set; };
        public DateTime DataRomaneio { get; set; };
        public string FormaPgto { get; set; };
        public decimal CustoCarregamento { get; set; };
        public decimal ValorComissao { get; set; };
        public decimal ValorTotalRomaneio { get; set; };
        public decimal TaxaNota { get; set; };
        public decimal Seguro { get; set; };
        public string UnidMedida { get; set; };

    }
}
