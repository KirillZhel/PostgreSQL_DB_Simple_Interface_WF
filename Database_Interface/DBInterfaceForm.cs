using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Interface
{
    public partial class DBInterfaceForm : Form
    {

        private string connString = String.Format($"Server={ConnectionData.Server};" +
                                                  $"Port={ConnectionData.Port};" +
                                                  $"User Id={ConnectionData.UserID};" +
                                                  $"Password={ConnectionData.Password};" +
                                                  $"Database={ConnectionData.DataBase};");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;

        private NpgsqlDataAdapter npgsqlDataAdapter;
        private NpgsqlCommandBuilder npgsqlCommandBuilder;
        private DataSet dataSet;
        public bool isUpdate = false;

        public DBInterfaceForm()
        {
            InitializeComponent();
        }

        private void DBInterfaceForm_Load(object sender, EventArgs e)
        {
            //можно загрузку данных в combobox сделать
            //в отдельном методе, который я буду вызывать
            //в конструкторе здесь
            List<Table> tables = new List<Table>
            {
                new Table {Id = 0, Name = "people"},
                new Table {Id = 1, Name = "groups"},
                new Table {Id = 2, Name = "marks"},
                new Table {Id = 3, Name = "subjects"}
            };

            tableListComboBox.DataSource = tables;
            tableListComboBox.DisplayMember = "Name";
            tableListComboBox.ValueMember = "Id";

            //тут должно происходить открытие соединения с базой данных
            //тогда возможно можно привязать показывание таблицы к событию comboBox

            conn = new NpgsqlConnection(connString);
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            string user = passwordTextBox.Text;
            string password = userNameTextBox.Text;
            bool authorizationStatus = false;

            try
            {
                conn.Open();

                sql = $"SELECT user_name, hash_password, " +
                      $"(hash_password = crypt('{passwordTextBox.Text}', hash_password)) AS match " +
                      $"FROM users where user_name = '{userNameTextBox.Text}';";

                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    authorizationStatus = dt.Rows[0].Field<bool>("match");
                }

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Ошибка: " + ex.Message);
            }

                tableListComboBox.Enabled = authorizationStatus;
                tabControl1.Enabled = authorizationStatus;
        }

        private void tableListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tableListComboBox.SelectedIndex)
            {
                case 0:
                    ShowInsertPeopleCell();
                    break;
                case 1:
                    ShowInsertGroupCell();
                    break;
                case 2:
                    ShowInsertMarkCell();
                    break;
                case 3:
                    ShowInsertSubjectCell();
                    break;
                default:
                    //tableSelectionlabel.Text = $"ничего не показываю";
                    break;
            }
        }

        private void ShowInsertSubjectCell()
        {
            insertLabel1.Visible = true;
            insertLabel2.Visible = false;
            insertLabel3.Visible = false;
            insertLabel4.Visible = false;
            insertLabel5.Visible = false;
            insertLabel1.Text = "название предмета";

            insertTextBox1.Visible = true;
            insertTextBox2.Visible = false;
            insertTextBox3.Visible = false;
            insertTextBox4.Visible = false;
            insertTypeComboBox.Visible = false;
        }

        private void ShowInsertMarkCell()
        {
            insertLabel1.Visible = true;
            insertLabel2.Visible = true;
            insertLabel3.Visible = true;
            insertLabel4.Visible = true;
            insertLabel5.Visible = false;
            insertLabel1.Text = "ID студента";
            insertLabel2.Text = "ID предмета";
            insertLabel3.Text = "ID преподавателя";
            insertLabel4.Text = "оценка";

            insertTextBox1.Visible = true;
            insertTextBox2.Visible = true;
            insertTextBox3.Visible = true;
            insertTextBox4.Visible = true;
            insertTypeComboBox.Visible = false;
        }

        private void ShowInsertGroupCell()
        {
            insertLabel1.Visible = true;
            insertLabel2.Visible = false;
            insertLabel3.Visible = false;
            insertLabel4.Visible = false;
            insertLabel5.Visible = false;
            insertLabel1.Text = "название группы";

            insertTextBox1.Visible = true;
            insertTextBox2.Visible = false;
            insertTextBox3.Visible = false;
            insertTextBox4.Visible = false;
            insertTypeComboBox.Visible = false;
        }

        private void ShowInsertPeopleCell()
        {
            insertLabel1.Visible = true;
            insertLabel2.Visible = true;
            insertLabel3.Visible = true;
            insertLabel4.Visible = true;
            insertLabel5.Visible = true;
            insertLabel1.Text = "фамилия";
            insertLabel2.Text = "имя";
            insertLabel3.Text = "отчество";
            insertLabel4.Text = "группа";
            insertLabel5.Text = "тип";

            insertTextBox1.Visible = true;
            insertTextBox2.Visible = true;
            insertTextBox3.Visible = true;
            insertTextBox4.Visible = true;
            insertTypeComboBox.Visible = true;
        }

        private void ShowTableButton_Click(object sender, EventArgs e)
        {
            Select();
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = $"select * from {tableListComboBox.Text}";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dataGridViewSelect.DataSource = null; //reset dataGridView
                dataGridViewSelect.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void showDeletedButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = $"select * from {tableListComboBox.Text} where id = {deleteIdTextBox.Text}";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dataGridViewDelete.DataSource = null;
                dataGridViewDelete.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = $"DELETE FROM {tableListComboBox.Text} WHERE id = {deleteIdTextBox.Text}";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();

                MessageBox.Show($"строка {deleteIdTextBox.Text} удалена из таблицы {tableListComboBox.Text}",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            switch (tableListComboBox.SelectedIndex)
            {
                case 0:
                    InsertPeople();
                    break;
                case 1:
                    InsertGroupOrSubject();
                    break;
                case 2:
                    InsertMark();
                    break;
                case 3:
                    InsertGroupOrSubject();
                    break;
                default:
                    MessageBox.Show("Ошибка");
                    break;
            }
        }

        private void InsertPeople()
        {
            try
            {
                conn.Open();
                if (insertTypeComboBox.Text == "S")
                {
                    sql = $"INSERT INTO {tableListComboBox.Text} (last_name, first_name, pather_name, group_id, type) " +
                        $"VALUES('{insertTextBox1.Text}', '{insertTextBox2.Text}', '{insertTextBox3.Text}'," +
                        $" {insertTextBox4.Text}, '{insertTypeComboBox.Text}')";
                }
                else
                {
                    sql = $"INSERT INTO {tableListComboBox.Text} (last_name, first_name, pather_name, type) " +
                        $"VALUES('{insertTextBox1.Text}', '{insertTextBox2.Text}', '{insertTextBox3.Text}', 'P')";
                }
                
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                MessageBox.Show("Вставка произведена успешно");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void InsertGroupOrSubject()
        {
            try
            {
                conn.Open();
                sql = $"INSERT INTO {tableListComboBox.Text} (name) VALUES ('{insertTextBox1.Text}')";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                MessageBox.Show("Вставка произведена успешно");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void InsertMark()
        {
            try
            {
                conn.Open();
                sql = $"INSERT INTO {tableListComboBox.Text} (student_id, subject_id, teacher_id, value) VALUES " +
                    $"({insertTextBox1.Text}, {insertTextBox2.Text}, {insertTextBox3.Text}, {insertTextBox4.Text})";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                MessageBox.Show("Вставка произведена успешно");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void showUpdatededButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = $"select * from {tableListComboBox.Text} where id = {updateTextBox6.Text}";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                npgsqlDataAdapter = new NpgsqlDataAdapter(sql, conn);
                dataSet = new DataSet();
                npgsqlDataAdapter.Fill(dataSet);
                
                
                conn.Close();
                dataGridViewUpdate.DataSource = null;
                dataGridViewUpdate.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void dataGridViewUpdate_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isUpdate = true;
            //dataGridViewUpdate[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(122, 214, 188); // Смена цвета на синий после изменения содержимого
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                try
                {
                    npgsqlCommandBuilder = new NpgsqlCommandBuilder(npgsqlDataAdapter);
                    npgsqlDataAdapter.Update(dataSet);
                    MessageBox.Show("Обновление завершено!");
                    isUpdate = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("нет обновлений!");
            }
        }
    }
}
