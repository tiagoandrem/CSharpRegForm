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
    public partial class Form2 : Form
    {
        int id;
        string str_conection = "Data Source = 89.154.2.41,62444;Initial Catalog = "your BD";User Id="your user";Password="your password";";
        public Form2()
        {
            InitializeComponent();
            SqlConnection C = new SqlConnection(str_conection);
            C.Open();
            //criar comando SQL para extrair os dados pretendidos:
            SqlCommand command = C.CreateCommand();
            command.CommandText = "SELECT * FROM T_funcionarios";
            //trazer os dados da tabela especificada para uma "tabela" em memória:
            SqlDataAdapter da = new SqlDataAdapter(command);
            var dt = new DataTable();
            da.Fill(dt);
            //despejar essa "tabela" num controlo, neste caso, na listbox:
            grd_funcionarios.DataSource = dt;
            //lbx_info.DataSource = dt;
            //lbx_info.DisplayMember = "nome_cliente";
            //desligar a conexão:
            escondercamp();
            this.Text = "Funcionários";
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

        
        private void bt_adicionaFuncionario_Click_1(object sender, EventArgs e)
        {
            Class2 o = new Class2();
            Class2 o1 = new Class2();
            o.setFrases(txt_Insert_Nome_Fun.Text);
            o1.setFrases(txt_num_funcionario.Text);



            string letras = o.GetString();
            string letras1 = o1.GetString();




            if (letras != ""&& letras1 != "" && txt_Insert_Nome_Fun.Text.Trim() != "" || letras != "" && letras1 != "" && txt_num_funcionario.Text.Trim() != "")
            {

                string inserir = "Insert into dbo.T_funcionarios ( nome_funcionario, telefone) Values('" + txt_Insert_Nome_Fun.Text + "', " +
                    txt_num_funcionario.Text + ")";



                Conecta(str_conection, inserir);
                MessageBox.Show(inserir);
                escondercamp();
            }
            else
            {
                MessageBox.Show("Preencha Corretamente os campos");
            }
        }


        private void bt_alterarFuncionario_Click_1(object sender, EventArgs e)
        {

            Class2 o = new Class2();
            Class2 o1 = new Class2();
            o.setFrases(txt_Insert_Nome_Fun.Text);
            o1.setFrases(txt_num_funcionario.Text);



            string letras = o.GetString();
            string letras1 = o1.GetString();




            if (letras != "" && letras1 != "" && txt_Insert_Nome_Fun.Text.Trim() != "" || letras != "" && letras1 != "" && txt_num_funcionario.Text.Trim() != "")
            {


                string alterar = "UPDATE dbo.T_funcionarios SET nome_funcionario = '" + txt_Insert_Nome_Fun.Text + "', telefone = '" +
             txt_num_funcionario.Text + "' Where id = " + id;


                MessageBox.Show(alterar);

                Conecta(str_conection, alterar);


                
            }
            else
            {
                MessageBox.Show("Preencha Corretamente os campos");
            }

        }

        private void grd_funcionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           


                if (grd_funcionarios.SelectedRows.Count > -1)
                {
                  id = Convert.ToInt16(grd_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString());

                  txt_Insert_Nome_Fun.Text = grd_funcionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                  txt_num_funcionario.Text = grd_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();

                  
                }

            

        }
        
        private void escondercamp()
        {
            grd_funcionarios.Columns[0].Visible = false;
        }
    }
}
