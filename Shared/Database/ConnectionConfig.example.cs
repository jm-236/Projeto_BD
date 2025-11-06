using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrimonioDB.Example.PatrimonioDB.Shared.Database
{
    namespace patrimonioDB.Shared.Database
    {
        // INSTRUÇÕES:
        // 1. Copie este arquivo para ConnectionConfig.cs
        // 2. Preencha com suas credenciais locais do PostgreSQL
        // 3. Nunca comite o arquivo ConnectionConfig.cs
        internal static class ConnectionConfig
        {
            public const string ConnectionString = "Host=localhost;Port=[sua_porta];Username=SEU_USUARIO;Password=SUA_SENHA;Database=SEU_BANCO";
        }
    }
}