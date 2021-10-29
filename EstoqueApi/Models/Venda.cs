﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueApi.Models
{
    public class Venda
    {
        public int ID { get; set; }
        public double Valor { get; set; }
        public int quantidade { get; set; }
        public double valorUnitario { get; set; }
        public string data { get; set; }
        public Produto Produto { get; set; }
    }
}
