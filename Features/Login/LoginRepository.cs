using System;
using Npgsql;
using patrimonioDB.Shared.Database;

namespace patrimonioDB.Features.Login
{
    public class LoginRepository
    {
        public Usuario? BuscarPorLogin(string login)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                string sql = @"
                    SELECT p.id, p.nome, p.login, p.senha, u.data_admissao, u.setor_id, u.salario, u.cargo
                    FROM usuario u 
                    INNER JOIN pessoa p ON u.id_pessoa = p.id 
                    WHERE p.login = @login";

                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@login", login);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var usuario = new Usuario
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Login = reader.GetString(2),
                                Senha = reader.GetString(3),
                                DataAdmissao = reader.GetDateTime(4),
                                SetorId = reader.GetInt32(5),
                                Salario = reader.GetDouble(6),
                                Cargo = reader.GetString(7)
                            };
                            return usuario;
                        }

                        return null; // não encontrou
                    }
                }
            }
        }
    }
}