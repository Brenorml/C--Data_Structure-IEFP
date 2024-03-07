using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMySQL
{
    internal class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string username;
        private string password;
        private string port;

        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "127.0.0.1"; //"127.0.0.1" ou "localhost"
            database = "formandos_prog13";
            username = "Programador13";
            password = "Programador";
            port = "3306";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";" + "PORT=" + port + ";";
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public int Count()
        {
            string query = "SELECT count(*) from formando;";

            int count = -1;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (MySqlException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }

        public bool InserirManual()
        {
            string query = "INSERT INTO formando (id_formando, nome, morada, contacto, sexo, data_nascimento) VALUES (1, 'Breno', 'Rua do estudante', '99999999', 'M', '1982-09-08');";
            bool teste = false;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    teste = true;
                    CloseConnection();                    
                }
            }
            catch (MySqlException ex)
            {
               MessageBox.Show("Dados já existentes", ex.Message);               
            }
            finally { 
                CloseConnection(); 
            }
            return teste;
        }

        public bool InserirFormulario(string id, string nome, string morada, string contacto, string iban, char genero, string dataNascimento)
        {
            string query = "INSERT INTO formando (id_formando, nome, morada, contacto, iban, sexo, data_nascimento) VALUES " + "(" + id + ", '" + nome + "', '" + morada + "', '" + contacto + "', '" + iban + "', '" + genero + "', '" + dataNascimento + "');";

            bool flag = false;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    
                    flag = true;
                    //CloseConnection();                    
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }

        public int devolveUtimoID()
        {
            int ultimoID = 0;
            string query = "SELECT MAX(id_formando) FROM formando;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //ultimoID = int.Parse(cmd.ExecuteScalar().ToString());
                    int.TryParse(cmd.ExecuteScalar().ToString(), out ultimoID);

                    ultimoID++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return ultimoID;
        }

        public bool PesquisaFormando(string idPesquisa, ref string nome, ref string morada, ref string contacto, ref string iban, ref char genero, ref string data_Nascimento)
        {
            string query = "select nome, morada, contacto, iban, sexo, data_nascimento from formando where id_formando = " + idPesquisa;

            bool flag = false;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        nome = dataReader[0].ToString();
                        morada = dataReader["morada"].ToString();
                        contacto = dataReader[2].ToString();
                        iban= dataReader[3].ToString();
                        genero = dataReader[4].ToString()[0];
                        data_Nascimento = dataReader[5].ToString();
                        flag = true;
                    }
                    dataReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                CloseConnection(); 
            }
            return flag;
        }

        public bool Delete(string id)
        {
            string query = "DELETE FROM formando WHERE id_formando = " + id + ";";

            bool flag = false;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    flag = true;                                       
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }

        public bool AlterarFormulario(string id, string nome, string morada, string contacto, string iban, char genero, string dataNascimento)
        {
            string query = "UPDATE formando SET nome = '" + nome + "', morada = '" + morada + "', contacto = '" + contacto + "', iban = '" + iban + "', sexo = '" + genero + "', data_nascimento = '" + dataNascimento + "' WHERE id_formando = " + id + ";";
                                

            bool flag = false;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    flag = true;
                    //CloseConnection();                    
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }

        public void PreencherDataGridViewFormandos(ref DataGridView dgv, char genero, string nome)
        {
            string query = "SELECT id_formando, nome, iban, data_nascimento, sexo FROM formando";
            bool flag = false;

            if (genero != 'T' &&  genero != ' ')
            {
                query += " WHERE sexo = '" + genero + "'";
                flag = true;
            }

            if (nome.Length > 0 && flag == true)
            {
                query += " AND nome LIKE '%" + nome + "%'";
            }
            else
            {
                query += " WHERE nome LIKE '%" + nome + "%'";
            }

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    int idxLinhas = 0;
                    while (dr.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[idxLinhas].Cells["codID"].Value = dr[0].ToString();
                        dgv.Rows[idxLinhas].Cells[1].Value = dr[1].ToString();
                        dgv.Rows[idxLinhas].Cells["iban"].Value = dr[2].ToString();
                        dgv.Rows[idxLinhas].Cells[3].Value = DateTime.Parse(dr[3].ToString()).ToString("dd-MM-yyyy");
                        dgv.Rows[idxLinhas].Cells["genero"].Value = dr["sexo"].ToString();
                        idxLinhas++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }            
        }

        public bool InserirNacionalidade(string alf2Codigo, string nacionalidade)
        {
            string query = "INSERT INTO nacionalidade (id_nacionalidade, alf2, nacionalidade) VALUES (0, '" + alf2Codigo + "', '" + nacionalidade + "')";

            bool flag = false;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    flag = true;
                    //CloseConnection();                    
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }

        public bool PreencherNacionalidade(ref ComboBox combo)
        {
            string query = "SELECT id_nacionalidade, alf2, nacionalidade FROM nacionalidade ORDER BY nacionalidade";

            bool flag = false;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        combo.Items.Add(dataReader[2].ToString() + " - " + dataReader[1].ToString() + " - " + dataReader[0].ToString());                        
                        
                        flag = true;
                    }
                    dataReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }

        
        public bool DeleteNacionalidade(int id_nacionalidade)
        {
            string query = "DELETE FROM nacionalidade WHERE id_nacionalidade = " + id_nacionalidade + ";";

            bool flag = false;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    flag = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }

        public bool AlterarNacionalidade(int id_nacionalidade, string alf2, string nacionalidade)
        {
            string query = "UPDATE nacionalidade SET alf2 = '" + alf2 + "', nacionalidade = '" + nacionalidade + "' WHERE id_nacionalidade = " + id_nacionalidade + ";";


            bool flag = false;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    flag = true;
                    //CloseConnection();                    
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }

        public void PreencherDataGridViewNacionalidade(ref DataGridView dgv)
        {
            string query = "SELECT id_nacionalidade, alf2, nacionalidade FROM nacionalidade";
                        
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    int idxLinhas = 0;
                    while (dr.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[idxLinhas].Cells["id_nacionalidade"].Value = dr[0].ToString();
                        dgv.Rows[idxLinhas].Cells["alf2"].Value = dr[1].ToString();
                        dgv.Rows[idxLinhas].Cells["nacionalidade"].Value = dr[2].ToString();                        
                        idxLinhas++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
