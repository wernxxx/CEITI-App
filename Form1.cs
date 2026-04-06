using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CEITI
{
    public partial class Form1 : Form
    {
        string connection = "Data Source=PC\\SQLEXPRESS;Initial Catalog=CEITI;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string query = "SELECT * FROM Note";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string query = @"INSERT INTO Note
                    (StudentId, DisciplinaId, ProfesorId, Nota, DataEvaluare)
                    VALUES(@s,@d,@p,@n,@data)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@s", txtStudentId.Text);
                        cmd.Parameters.AddWithValue("@d", txtDisciplinaId.Text);
                        cmd.Parameters.AddWithValue("@p", txtProfesorId.Text);
                        cmd.Parameters.AddWithValue("@n", txtNota.Text);
                        cmd.Parameters.AddWithValue("@data", dateTimePicker1.Value);

                        cmd.ExecuteNonQuery();
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string query = @"UPDATE Note SET
                    StudentId=@s,
                    DisciplinaId=@d,
                    ProfesorId=@p,
                    Nota=@n,
                    DataEvaluare=@data
                    WHERE Id=@id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@s", txtStudentId.Text);
                        cmd.Parameters.AddWithValue("@d", txtDisciplinaId.Text);
                        cmd.Parameters.AddWithValue("@p", txtProfesorId.Text);
                        cmd.Parameters.AddWithValue("@n", txtNota.Text);
                        cmd.Parameters.AddWithValue("@data", dateTimePicker1.Value);

                        cmd.Parameters.AddWithValue("@id",
                            dataGridView1.CurrentRow.Cells["Id"].Value);

                        cmd.ExecuteNonQuery();
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                txtStudentId.Text = row.Cells["StudentId"].Value.ToString();
                txtDisciplinaId.Text = row.Cells["DisciplinaId"].Value.ToString();
                txtProfesorId.Text = row.Cells["ProfesorId"].Value.ToString();
                txtNota.Text = row.Cells["Nota"].Value.ToString();

                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["DataEvaluare"].Value);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string query = @"SELECT Nota, DataEvaluare 
                                     FROM Note 
                                     WHERE StudentId=@id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtStudentId.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            lblAfisare.Text = "";

                            while (reader.Read())
                            {
                                lblAfisare.Text +=
                                    "Nota: " + reader["Nota"] +
                                    " | Data: " + reader["DataEvaluare"] + "\n";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string query = @"
                    SELECT StudentId, AVG(Nota) AS Media
                    FROM Note
                    GROUP BY StudentId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        lblAfisare.Text = "RAPORT MEDII:\n";

                        while (reader.Read())
                        {
                            lblAfisare.Text +=
                                "Student ID: " + reader["StudentId"] +
                                " | Media: " + reader["Media"] + "\n";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Designer wrappers expected by the current designer file
        private void button1_Click(object sender, EventArgs e)
        {
            btnLoad_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnInsert_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnFilter_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnUpdate_Click(sender, e);
        }

        private void lblAfisare_Click_1(object sender, EventArgs e)
        {
            // no-op
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // no-op
        }
    }
}