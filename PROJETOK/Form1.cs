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
    public partial class Form1 : Form
    {
        int id;
        string str_conection = "Data Source = 89.154.2.41,62444;Initial Catalog = "your BD";User Id="your user";Password="your password";";

        public Form1()      
        {
            InitializeComponent();

            inicializar();

            this.Text = "Inserção de dados";
        }

        private void inicializar()
        {
            //criar uma conexão:
            SqlConnection C = new SqlConnection(str_conection);
            C.Open();
            //criar comando SQL para extrair os dados pretendidos:
            SqlCommand command = C.CreateCommand();
            command.CommandText = "select * from T_clientes";
            //trazer os dados da tabela especificada para uma "tabela" em memória:
            SqlDataAdapter da = new SqlDataAdapter(command);
            var dt = new DataTable();
            da.Fill(dt);
            //despejar essa "tabela" num controlo, neste caso, na listbox:
            //para aparecer a lista de clientes no incio do form
            cbx_cliente.DataSource = Conecta(str_conection, "SELECT * from T_clientes");
            cbx_cliente.DisplayMember = "nome_cliente";
            cbx_cliente.ValueMember = "id";



            //para aparecer a lista de funcionarios no incio do form
            cbx_funcionarios.DataSource = Conecta(str_conection, "SELECT * from T_funcionarios");
            cbx_funcionarios.DisplayMember = "nome_funcionario";
            cbx_funcionarios.ValueMember = "id";

            //para aparecer items em combobox
            comboBox1.DataSource = Conecta(str_conection, "SELECT * from T_items");
            comboBox1.DisplayMember = "designacao";
            comboBox1.ValueMember = "id";

            //coloniza a listbox1 com os nomes dos clientes
            listBox1.DataSource = Conecta(str_conection, "SELECT * from T_clientes");
            listBox1.DisplayMember = "nome_cliente";
            listBox1.ValueMember = "id";

            //coloniza a listbox2 com os nomes dos funcinarios
            listBox2.DataSource = Conecta(str_conection, "SELECT * from T_funcionarios");
            listBox2.DisplayMember = "nome_funcionario";
            listBox2.ValueMember = "id";

           


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
        } //------------------------------------------------ CONECTAR----------------------------------------------      

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void bt_clientes_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void cbx_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {



            string pesquisaDB = "SELECT id as P, cod_cliente as C, cod_funcionario as F, data as DATA, tempo as MINUTOS," + " descritivo as DESCRITIVO, (select designacao from T_items where id=cod_item) as ITEM from Registo_de_tempos " 
                                + "where cod_cliente = " + cbx_cliente.SelectedValue.ToString() + "and " + "cod_funcionario = " + cbx_funcionarios.SelectedValue.ToString();

            grd_dados.DataSource = Conecta(str_conection, pesquisaDB);

            esconderComp();
        }

        private void txt_cliente_TextChanged(object sender, EventArgs e)
        {

            //filtra os resultados que vem da BD atraves do metodo textchanged
            string s = txt_cliente.Text;

            cbx_cliente.DataSource = Conecta(str_conection, "select * from T_clientes where nome_cliente like '%" + s + "%'");
            listBox1.DataSource = Conecta(str_conection, "select * from T_clientes where nome_cliente like '%" + s + "%'");
        }
       
        private void cbx_funcionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string pesquisaDB = "SELECT id as P, cod_cliente as C, cod_funcionario as F, data as DATA, tempo as MINUTOS," + " descritivo as DESCRITIVO, (select designacao from T_items where id=cod_item) as ITEM from Registo_de_tempos "
            + "where cod_cliente = " + cbx_cliente.SelectedValue.ToString() + "and " + "cod_funcionario = " + cbx_funcionarios.SelectedValue.ToString();
            grd_dados.DataSource = Conecta(str_conection, pesquisaDB);
        }

        private void bt_mostrador_Click(object sender, EventArgs e)
        {

            grd_mostrador.ColumnHeadersVisible = false;
            grd_mostrador.RowHeadersVisible = false;

            string total_RTempos ="Select count(*) from dbo.Registo_de_tempos";
            string total_RAno = "select count(*) from dbo.Registo_de_tempos where year(data) = year(CURRENT_TIMESTAMP)";
            string total_RMes = "select count(*) from dbo.Registo_de_tempos where month(data) = month(CURRENT_TIMESTAMP)";
            string total_Func_mes = "select count(*) from dbo.Registo_de_tempos where month(data) = month(CURRENT_TIMESTAMP) and cod_funcionario = ";
            string total_minutos_Fmes = "select sum(tempo) from dbo.Registo_de_tempos where month(data) = month(CURRENT_TIMESTAMP) and cod_funcionario = ";
            string total_cliente_mes = "select count(*) from dbo.Registo_de_tempos where month(data) = month(CURRENT_TIMESTAMP) and cod_cliente = ";
            string total_minutos_Cmes = "select sum(tempo) from dbo.Registo_de_tempos where month(data) = month(CURRENT_TIMESTAMP) and cod_cliente = ";
            DataTable t = Conecta(str_conection, total_RTempos);
            DataTable t1 = Conecta(str_conection, total_RAno);
            DataTable t2 = Conecta(str_conection, total_RMes);
            DataTable t3 = Conecta(str_conection, total_Func_mes + cbx_funcionarios.SelectedValue);
            DataTable t4 = Conecta(str_conection, total_minutos_Fmes + cbx_funcionarios.SelectedValue);
            DataTable t5 = Conecta(str_conection, total_cliente_mes + cbx_cliente.SelectedValue);
            DataTable t6 = Conecta(str_conection, total_minutos_Cmes + cbx_cliente.SelectedValue);

            grd_mostrador.Rows.Clear();

            grd_mostrador.Rows.Add(6);
            grd_mostrador.Rows[0].Cells[0].Value = "Total de Registos";
            grd_mostrador.Rows[0].Cells[1].Value = t.Rows[0][0].ToString();
            grd_mostrador.Rows[1].Cells[0].Value = "Registos este ano";
            grd_mostrador.Rows[1].Cells[1].Value = t1.Rows[0][0].ToString();
            grd_mostrador.Rows[2].Cells[0].Value = "Registos este mês";
            grd_mostrador.Rows[2].Cells[1].Value = t2.Rows[0][0].ToString();
            grd_mostrador.Rows[3].Cells[0].Value = cbx_funcionarios.Text + " este mês" + " Registo(s)";
            grd_mostrador.Rows[3].Cells[1].Value = t3.Rows[0][0].ToString() + " m." ;
            grd_mostrador.Rows[4].Cells[0].Value = cbx_funcionarios.Text + " este mês";
            grd_mostrador.Rows[4].Cells[1].Value = t4.Rows[0][0].ToString() + " m.";
            grd_mostrador.Rows[5].Cells[0].Value = cbx_cliente.Text + " este mês";
            grd_mostrador.Rows[5].Cells[1].Value = t5.Rows[0][0].ToString() + " Registo(s)";
            grd_mostrador.Rows[6].Cells[0].Value = cbx_cliente.Text + " este mês";
            grd_mostrador.Rows[6].Cells[1].Value = t6.Rows[0][0].ToString() + " m.";

            


        }

        private void grd_mostrador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
            grd_dados.Rows.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
            string s = txt_funcionario.Text;
            cbx_funcionarios.DataSource = Conecta(str_conection, "select * from T_funcionarios where nome_funcionario like '%" + s + "%'");
            listBox2.DataSource = Conecta(str_conection, "select * from T_funcionarios where nome_funcionario like '%" + s + "%'");
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)//copia o nome selecionado na list box para a combo - clientes
        {
            cbx_funcionarios.Text = listBox1.Text;
        }

        private void bt_enviarDados_Click(object sender, EventArgs e)

        {
            string data_formatada = Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd"); // Formata a data para o modelo europeu como está na base de dados

         


            tempo o = new tempo();

            o.setTempo(textBox1.Text);

            int minutos = o.GetTempo();
           

            if (minutos >= 0 && textBox2.Text.Trim() != "") 

            {
                // String para inserir dados na base de dados.
                string inserir = "Insert into dbo.Registo_de_tempos(cod_cliente, cod_funcionario, data, tempo, descritivo, cod_item) Values(" + cbx_cliente.SelectedValue + ", " +
                 cbx_funcionarios.SelectedValue + ",' " + data_formatada + "', " + textBox1.Text + ",' " + textBox2.Text + "', " + comboBox1.SelectedValue + ")";



                string alterar = "UPDATE dbo.Registo_de_Tempos SET data = '" + data_formatada + "', tempo =" + textBox1.Text + ", descritivo = '" + textBox2.Text + "', " +
                "cod_item = " + comboBox1.SelectedValue + " Where id = " + id;


                
                if (bt_enviarDados.Text == "ENVIAR DADOS")
                {
                    grd_dados.Update();
                    grd_dados.Refresh();

                    DialogResult dr = MessageBox.Show(dateTimePicker1.Value + "/nCliente: " +
                        cbx_cliente.Text + "\nFuncionários: " + cbx_funcionarios.Text +
                        "\nTempo: " + textBox1.Text + "\nDescrição: " + textBox2.Text +
                        "\n Categoria: " + comboBox1.Text + "\nData: " + dateTimePicker1.Text,
                        "Enviar Dados?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (dr)
                    {
                        case DialogResult.Cancel:
                            break;
                        case DialogResult.Yes:
                            Conecta(str_conection, inserir);
                            break;
                           
                        case DialogResult.No:
                            break;
                        default:
                            break;
                    }
                }
                if (bt_enviarDados.Text == "ALTERAR DADOS")
                {




                    DialogResult dr = MessageBox.Show(dateTimePicker1.Value + "/nCliente: " +
                        cbx_cliente.Text + "\nFuncionários: " + cbx_funcionarios.Text +
                        "\nTempo: " + textBox1.Text + "\nDescrição: " + textBox2.Text +
                        "\n Categoria: " + comboBox1.Text + "\nData: " + dateTimePicker1.Text,
                        "Alterar Dados? ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (dr)
                    {
                        case DialogResult.Cancel:
                            break;
                        case DialogResult.Yes:
                            Conecta(str_conection, alterar);
                            grd_dados.Update();
                            break;
                        case DialogResult.No:
                            textBox1.BackColor = Color.White;
                            textBox2.BackColor = Color.White;
                            comboBox1.BackColor = Color.White;
                            textBox1.Clear();
                            textBox2.Clear();
                            comboBox1.Text = "Contabilidade";
                            dateTimePicker1.Value = DateTime.Now;
                            break;
                        default:
                            break;
                    }
                }

            }
            else
            {
                MessageBox.Show("ERRO NA INSERÇÃO DE DADOS");
            }

            grd_dados.Update();
            grd_dados.Refresh();

        }

        private void grd_dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            bt_enviarDados.Text = "ALTERAR DADOS";
            {
              
                string data_formatada = Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd");
                

                if (grd_dados.SelectedRows.Count>-1)
                {
                    id = Convert.ToInt16(grd_dados.Rows[e.RowIndex].Cells[0].Value.ToString());
                    textBox1.Text = grd_dados.Rows[e.RowIndex].Cells[4].Value.ToString();
                    textBox2.Text = grd_dados.Rows[e.RowIndex].Cells[5].Value.ToString();
                    comboBox1.Text = grd_dados.Rows[e.RowIndex].Cells[6].Value.ToString();
                    dateTimePicker1.Text = grd_dados.Rows[e.RowIndex].Cells[3].Value.ToString();
                    
                }

            }
        }

        private void grd_dados_KeyDown(object sender, KeyEventArgs e)
        {
            
            int RowIndex = grd_dados.CurrentCell.OwningRow.Index;
            id = Convert.ToInt16(grd_dados.Rows[RowIndex].Cells[0].Value.ToString());
            string apagar = "delete from Registo_de_tempos where Id = " + id;
            if (e.KeyCode == Keys.Delete)
            {

                DialogResult dr = MessageBox.Show("Apagar os Registos?", "Apagar Registos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (dr)
                {
                    case DialogResult.Yes:
                        Conecta(str_conection, apagar);
                        e.Handled = true;
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }

                MessageBox.Show(apagar);
            }
            if (e.KeyCode == Keys.Escape)
            {
               
                bt_enviarDados.Text = "ENVIAR DADOS";
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.Text = "Contabilidade";
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 
           cbx_funcionarios.Text = listBox2.Text;
        }

        private void esconderComp()
        {
            grd_dados.Columns[0].Visible = false;
            grd_dados.Columns[1].Visible = false;
            grd_dados.Columns[2].Visible = false;
            
        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            cbx_funcionarios.Text = listBox2.Text;
        }

        private void listBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            cbx_cliente.Text = listBox1.Text;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        
    }

}
