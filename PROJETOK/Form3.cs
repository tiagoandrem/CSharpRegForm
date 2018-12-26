using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJETOK
{
    public partial class Form3 : Form
    {
        int id;
        string str_conection = "Data Source = 89.154.2.41,62444;Initial Catalog ="your BD";User Id="your user";Password="your password";";
        public Form3()
        {
            InitializeComponent();
            SqlConnection C = new SqlConnection(str_conection);
            C.Open();
            //criar comando SQL para extrair os dados pretendidos:
            SqlCommand command = C.CreateCommand();
            command.CommandText = "SELECT * FROM T_clientes";
            //trazer os dados da tabela especificada para uma "tabela" em memória:
            SqlDataAdapter da = new SqlDataAdapter(command);
            var dt = new DataTable();
            da.Fill(dt);
            //despejar essa "tabela" num controlo, neste caso, na listbox:
            grd_clientes.DataSource = dt;
            //lbx_info.DataSource = dt;
            //lbx_info.DisplayMember = "nome_cliente";
            //desligar a conexão:
            escondercamp();
            this.Text = "Clientes";
            C.Close();
        }

        DataTable Conecta(string str_conection, string str_sql)
        {
            //recebe a string de conexão à base de dados e a string com o comando SQL
            //devolve uma tabela (datatable) com os registos provenientes da base de dados
            SqlConnection C = new SqlConnection(str_conection); C.Open();
            //criar comando SQL para extrair os dados pretendidos:
            SqlCommand command = C.CreateCommand(); command.CommandText = str_sql;//o comando SQL vem na string
            //trazer os dados da tabela especificada para uma "tabela" em memória:
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable t = new DataTable();
            da.Fill(t);
            C.Close();
            return t;  //t leva os registos
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            Class2 o = new Class2();
            Class2 o1 = new Class2();
            Class2 o2 = new Class2();
            o.setFrases(txt_nomeCliente.Text);
            o1.setFrases(txt_nomeCidade.Text);
            o2.setFrases(txt_nomePais.Text);

            string letras = o.GetString();
            string letras1 = o1.GetString();
            string letras2 = o2.GetString();


            if (letras != "" && letras1 != "" && letras2 != "" && txt_nomeCliente.Text.Trim() != "" || letras != "" && letras1 != "" && letras2 != "" && txt_nomeCidade.Text.Trim() != "" || letras != "" && letras1 != "" && letras2 != "" && txt_nomePais.Text.Trim() != "")
            {
                string inserir = "Insert into dbo.T_clientes( nome_cliente, cidade, país) Values('" + txt_nomeCliente.Text + "', '" +
                txt_nomeCidade.Text + "', '" + txt_nomePais.Text + "')";




                Conecta(str_conection, inserir);
                MessageBox.Show(inserir);

                //grd_clientes.Update();
                //grd_clientes.Refresh();
            }
            else
            {
                MessageBox.Show("Preencha Corretamente os campos");
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {

            Class2 o = new Class2();
            Class2 o1 = new Class2();
            Class2 o2 = new Class2();
            o.setFrases(txt_nomeCliente.Text);
            o1.setFrases(txt_nomeCidade.Text);
            o2.setFrases(txt_nomePais.Text);

            string letras = o.GetString();
            string letras1 = o1.GetString();
            string letras2 = o2.GetString();


            if (letras != "" && letras1 != "" && letras2 != "" && txt_nomeCliente.Text.Trim() != "" || letras != "" && letras1 != "" && letras2 != "" && txt_nomeCidade.Text.Trim() != "" || letras != "" && letras1 != "" && letras2 != "" && txt_nomePais.Text.Trim() != "")
            {
                string alterar = "UPDATE dbo.T_clientes SET nome_cliente = '" + txt_nomeCliente.Text + "', cidade = '" +
             txt_nomeCidade.Text + "', país = '" + txt_nomePais.Text + "' Where id = " + id;


            MessageBox.Show(alterar);

            Conecta(str_conection, alterar);

            }
            else
            {
                MessageBox.Show("Preencha Corretamente os campos");
            }

        }

        private void grd_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_editar.Text = "Confirmar alteração";
            {
                try
                {

                }
                catch (Exception)
                {

                    throw;
                }
                if (grd_clientes.SelectedRows.Count > -1)
                {
                    id = Convert.ToInt16(grd_clientes.Rows[e.RowIndex].Cells[0].Value.ToString());

                    txt_nomeCliente.Text = grd_clientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txt_nomeCidade.Text = grd_clientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txt_nomePais.Text = grd_clientes.Rows[e.RowIndex].Cells[3].Value.ToString();

                }

            }

        }

        private void escondercamp()
        {
            grd_clientes.Columns[0].Visible = false;
        }
    }
        

        
}
