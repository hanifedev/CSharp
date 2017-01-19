 public SqlConnection baglanti;
        public SqlCommand komut;
        private void Form1_Load(object sender, EventArgs e)
        {
            kisigetir();
        }
        void kisigetir()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=HANIFE\\SQLEXPRESS;Initial Catalog=deneme; Integrated Security=SSPI");
            baglanti.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select * From kullanicilar", baglanti);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=HANIFE\\SQLEXPRESS;Initial Catalog=deneme; Integrated Security=SSPI");
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * From kullanicilar where kullaniciadi='" + textBox1.Text + "' and parola='" + textBox2.Text + "' ";
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("hosgeldiniz");
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("yanlıs kullanıcı adı veya parola girdiniz");
            }
        }
