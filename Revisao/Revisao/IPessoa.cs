﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public interface IPessoa
    {
        string Documento { get; }
        string Nome { get; set; }
    }
}
