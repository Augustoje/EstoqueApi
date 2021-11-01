﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueApi.Models
{
    public class Venda
    {
        public int ID { get; set; }
        public double total { get; set; }
        public int quantidade { get; set; }
        public double precoUnitario { get; set; }
        public string data { get; set; }
        public Produto Produto { get; set; }
    }
}
