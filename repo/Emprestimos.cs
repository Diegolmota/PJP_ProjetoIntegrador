using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySqlConnector;
using Model;

namespace Repo
{
    public class RepoEmprestimos
    {
        private static MySqlConnection conexao;
        static List<Emprestimo> emprestimos = new List<Emprestimo>();

        public static List<Emprestimo> ListEmprestimos()
        {
            return emprestimos;
        }

        public static void InitConexao()
        {
            string info = "server=localhost;database=bibliotechDB;user id=root;password=''";
            conexao = new MySqlConnection(info);
            try
            {
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados.");
            }
        }

        public static void CloseConexao()
        {
            conexao.Close();
        }

        public static List<Emprestimo> Sincronizar()
        {
            InitConexao();
            string query = "SELECT * FROM emprestimos"; // Corrigido de 'pessoas' para 'emprestimos'
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Emprestimo emprestimo = new Emprestimo
                {
                    Id = Convert.ToInt32(reader["id_emprestimo"]),
                    Data_emprestimo = reader["data_emprestimo"].ToString(),
                    Data_prazo = reader["data_prazo"].ToString(),
                    Data_devolucao = reader["data_devolucao"].ToString(),
                    Horario = reader["horario"].ToString(),
                    Id_multa = Convert.ToInt32(reader["id_multa"]),
                    Id_usuario = Convert.ToInt32(reader["id_usuario"]),
                    Id_livro = Convert.ToInt32(reader["id_livro"]) // Corrigido de 'id_livro' para 'Id_livro'
                };
                emprestimos.Add(emprestimo);
            }
            CloseConexao();
            return emprestimos;
        }
    }
}