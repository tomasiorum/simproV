﻿using SimproV.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimproV.Models
{
    public class SubmeterComerciante : ISubmeterComerciante
    {
        public string NIF { get; set; }
        public string Atividade { get; set; }
    }
}
