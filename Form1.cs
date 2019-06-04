using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            this.Close();
        }


        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
//ВСТАВКААААААААА
        private async void button1_Click_1(object sender, EventArgs e)
        {
            if (label13.Visible)
                label13.Visible = false;
            if (!string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox7.Text) &&
                !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox6.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))


            {
                SqlCommand command = new SqlCommand("INSERT INTO [FilmTable] (Name, Producer, Year, Actor, Rate, People)VALUES(@Name, @Producer, @Year, @Actor, @Rate, @People)", sqlConnection);
                command.Parameters.AddWithValue("Name", textBox7.Text);
                command.Parameters.AddWithValue("Producer", textBox6.Text);
                command.Parameters.AddWithValue("Year", textBox5.Text);
                command.Parameters.AddWithValue("Actor", textBox4.Text);
                command.Parameters.AddWithValue("Rate", textBox3.Text);
                command.Parameters.AddWithValue("People", textBox2.Text);

                await command.ExecuteNonQueryAsync();
            }

            else if (string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrWhiteSpace(textBox7.Text))
            {
                label20.Visible = true;
                label20.Text = "Поле (Фамилия) не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                label21.Visible = true;
                label21.Text = "Поле (Режиссер) не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                label22.Visible = true;
                label22.Text = "Поле (Год выхода) не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле (Фамилия актёра) не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                label24.Visible = true;
                label24.Text = "Поле (Рейтинг) не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                label25.Visible = true;
                label25.Text = "Поле (Кол-во зрителей) не заполненно";
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
//ИЗМЕНЕНИЕЕЕЕЕЕЕЕЕЕЕЕЕ!!!!! ! ! ! ! ! ! ! ! ! ! ! ! ! !! !
        private async void button2_Click(object sender, EventArgs e)
        {

            if (label14.Visible)
                label14.Visible = false;
            
                if (
                !string.IsNullOrEmpty(textBox12.Text) && !string.IsNullOrWhiteSpace(textBox12.Text) &&
                !string.IsNullOrEmpty(textBox11.Text) && !string.IsNullOrWhiteSpace(textBox11.Text) &&
                !string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrWhiteSpace(textBox10.Text) &&
                !string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox9.Text) &&
                !string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox8.Text) &&
                !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))


            {
                    SqlCommand command = new SqlCommand("UPDATE [FilmTable] SET [Name]=@Name, [Producer]=@Producer, [Year]=@Year, [Actor]=@Actor, [Rate]=@Rate, [People]=@Actor) WHERE [Id]=@Id", sqlConnection);

                    command.Parameters.AddWithValue("Name", textBox12.Text);
                    command.Parameters.AddWithValue("Producer", textBox11.Text);
                    command.Parameters.AddWithValue("Year", textBox10.Text);
                    command.Parameters.AddWithValue("Actor", textBox9.Text);
                    command.Parameters.AddWithValue("Rate", textBox8.Text);
                    command.Parameters.AddWithValue("People", textBox1.Text);

                    await command.ExecuteNonQueryAsync();
                }


      
             else if (string.IsNullOrEmpty(textBox12.Text) || string.IsNullOrWhiteSpace(textBox12.Text))
            {
                label26.Visible = true;
                label26.Text = "Поле (Фамилия) не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox11.Text) || string.IsNullOrWhiteSpace(textBox11.Text))
            {
                label27.Visible = true;
                label27.Text = "Поле (Режиссер) не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox10.Text) || string.IsNullOrWhiteSpace(textBox10.Text))
            {
                label28.Visible = true;
                label28.Text = "Поле (Год выхода) не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox9.Text) || string.IsNullOrWhiteSpace(textBox9.Text))
            {
                label29.Visible = true;
                label29.Text = "Поле (Фамилия актёра) не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrWhiteSpace(textBox8.Text))
            {
                label30.Visible = true;
                label30.Text = "Поле (Рейтинг) не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                label31.Visible = true;
                label31.Text = "Поле (Кол-во зрителей) не заполненно";
            }
        } 
            
        




        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
// А ЭТО УДАЛЕНИЕ, НО ПО КОЛ-ВУ ЗРИТЕЛЕЙ, МОЖНО КОНЕЧНО И ПО ID, Я В КУРСЕ КАК ЭТО СДЕЛАТЬ, НО ДУМАЮ ТАК БУДЕТ ПОЛУЧШЕ
        private async void button3_Click(object sender, EventArgs e)
        {

            if (label16.Visible)
                label16.Visible = false;

            if (
            !string.IsNullOrEmpty(textBox15.Text) && !string.IsNullOrWhiteSpace(textBox15.Text))


            {
                SqlCommand command = new SqlCommand("DELETE FROM [FilmTable] WHERE [People]=@People", sqlConnection);

                command.Parameters.AddWithValue("People", textBox15.Text);

                await command.ExecuteNonQueryAsync();
            }


            else
            {
                label16.Visible = true;
                label16.Text = "Введите верное значение";

            }
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged_1(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ahmet\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [FilmTable]", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync ())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["name"]) + " " + Convert.ToString(sqlReader["producer"]) + "       " + Convert.ToString(sqlReader["year"]) + "        " + Convert.ToString(sqlReader["actor"]) + " " + Convert.ToString(sqlReader["rate"]) + "      " + Convert.ToString(sqlReader["people"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
                 finally
                 {
                if (sqlReader != null)
                    sqlReader.Close();

                 }
        }

        private async void ОбновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [FilmTable]", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["name"]) + " " + Convert.ToString(sqlReader["producer"]) + "       " + Convert.ToString(sqlReader["year"]) + "        " + Convert.ToString(sqlReader["actor"]) + " " + Convert.ToString(sqlReader["rate"]) + "      " + Convert.ToString(sqlReader["people"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();

            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }


        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Косо, криво, но с душой.");
        }


        private void ДобавлениеИнформацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чтобы добавить информацию, кликаете на 'INSTERT'    ");
        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }
    }
}
