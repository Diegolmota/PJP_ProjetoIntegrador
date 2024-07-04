using Controller;
using Model;

namespace View;

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
            HeaderText = "Data_emprestimo"
        });
        DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Data_prazo",
            HeaderText = "Data_prazo"
        });
        DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Data_devolucao",
            HeaderText = "Data_devolucao"
        });
        DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Horario",
            HeaderText = "Horario"
        });
        DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Id_multa",
            HeaderText = "Id_multa"
        });
        DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Id_usuario",
            HeaderText = "Id_usuario"
        });
        DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Id_livro",
            HeaderText = "Id_livro"
        });
    }
}
/*
using Controller;
using Model;

namespace View;

public class ViewEmprestimos : Form
{
    private readonly Label LblNome;
    private readonly Label LblSenha;
    private readonly TextBox InpNome;
    private readonly TextBox InpSenha;

    private readonly DataGridView DgvEmprestimos;
    public ViewEmprestimos()
    {
        // ControllerEmprestimo.Sincronizar();

        Size = new Size(500, 600);
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = Color.Gray;

        LblNome = new Label {
            Text = "Nome",
            Location = new Point(50, 50),
        };
        LblSenha = new Label {
            Text = "Senha",
            Location = new Point(50, 100),
        };
        InpNome = new TextBox {
            Name = "Nome",
            Location = new Point(150, 50),
            Size = new Size(200, 20)
        };
        InpSenha = new TextBox {
            Name = "Senha",
            Location = new Point(150, 100),
            Size = new Size(200, 20)
        };


        DgvEmprestimos = new DataGridView
        {
            Location = new Point(50, 300), //tabela
            Size = new Size(400, 150) 
        };

        Controls.Add(LblNome);
        Controls.Add(LblSenha);
        Controls.Add(InpNome);
        Controls.Add(InpSenha);
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
            HeaderText = "Data_emprestimo"
        });
        DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Data_prazo",
            HeaderText = "Data_prazo"
        });
        DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Data_devolucao",
            HeaderText = "Data_devolucao"
        });
        DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Horario",
            HeaderText = "Horario"
        });
        DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Id_multa",
            HeaderText = "Id_multa"
        });
        DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Id_usuario",
            HeaderText = "Id_usuario"
        });
        DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Id_livro",
            HeaderText = "Id_livro"
        });
    }
}*/
