﻿using System.ComponentModel;
using System.Net.Sockets;

namespace SistemaDeTarefa.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluido")]
        Concluido = 3
    }
}
