public void yenile()
        {
            this.tabloTableAdapter.Fill(this.vtDataSet.tablo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");
            OleDbCommand kaydet = new OleDbCommand("insert into tablo(ad,soyad,numara)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", baglan);
            baglan.Open();
            kaydet.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Yazıldı");
            yenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("update tablo set ad='" + textBox1.Text + "',soyad='" + textBox2.Text + "', numara='" + textBox3.Text + "' Where ad='" + textBox4.Text + "'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt güncellendi");
            yenile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("delete*from tablo where ad='" + textBox4.Text + "'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt silindi");
            yenile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vtDataSet.tablo' table. You can move, or remove it, as needed.
            this.tabloTableAdapter.Fill(this.vtDataSet.tablo);

        }
    }
}
