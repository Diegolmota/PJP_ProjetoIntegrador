using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public class ViewEmprestimos : Form
    {
        private readonly DataGridView DgvEmprestimos;

        public ViewEmprestimos()
        {
            // ControllerEmprestimo.Sincronizar();

            Size = new Size(800, 400);
            StartPosition = FormStartPosition.CenterScreen;
            DgvEmprestimos = new DataGridView
            {
                Location = new Point(0, 200),
                Size = new Size(800, 150)
            };

            Controls.Add(DgvEmprestimos);
            ControllerEmprestimo.Sincronizar();
            Listar();
        }

        private void Listar()
        {
            List<Emprestimo> emprestimos = ControllerEmprestimo.ListarEmprestimos();
            DgvEmprestimos.Columns.Clear();
            DgvEmprestimos.AutoGenerateColumns = false;
            DgvEmprestimos.DataSource = emprestimos;

            DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id"
            });
            DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Data_emprestimo",
                HeaderText = "Data Emprestimo"
            });
            DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Data_prazo",
                HeaderText = "Data Prazo"
            });
            DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Data_devolucao",
                HeaderText = "Data Devolucao"
            });
            DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Horario",
                HeaderText = "Horario"
            });
            DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id_multa",
                HeaderText = "Id Multa"
            });
            DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id_usuario",
                HeaderText = "Id Usuario"
            });
            DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id_livro",
                HeaderText = "Id Livro"
            });
        }
    }
}