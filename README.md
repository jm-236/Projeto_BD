## Configuração do Banco de Dados

1. Copie o arquivo `Shared/Database/ConnectionConfig.example.cs` para `ConnectionConfig.cs`
2. Abra `ConnectionConfig.cs` e preencha com suas credenciais do PostgreSQL:
   - Host (localhost)
   - Port (porta do seu PostgreSQL)
   - Username (seu usuário)
   - Password (sua senha)
   - Database (nome do banco)
3. **IMPORTANTE:** O arquivo `ConnectionConfig.cs` está no `.gitignore` e nunca será comitado

## Primeira execução para colaboradores
```bash
cp Shared/Database/ConnectionConfig.example.cs Shared/Database/ConnectionConfig.cs
# Depois edite o ConnectionConfig.cs com suas credenciais
```