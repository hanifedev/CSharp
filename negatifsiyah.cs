Bitmap resim;

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.InitialDirectory = "c:\\";
            openfile.Filter = "Bitmap Dosyaları (*.bmp)|*.bmp|Jpeg Dosyaları (*.jpg)|*.jpg";
            openfile.FilterIndex = 2;
            openfile.RestoreDirectory = true;
            if (DialogResult.OK == openfile.ShowDialog())
            {
                resim = (Bitmap)Bitmap.FromFile(openfile.FileName, false);
                pictureBox1.Image = resim;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            sfd.Title = "Kayıt";
            sfd.FileName = "resim";
            DialogResult sonuc = sfd.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                pictureBox2.Image.Save(sfd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap yeni_resim = new Bitmap(resim.Width, resim.Height);
            for (int i = 0; i < resim.Width; i++)
            {
                for (int j = 0; j < resim.Height; j++)
                {
                    Color renkler = resim.GetPixel(i, j);
                    int gri = (int)(((renkler.R * 0.299) + (renkler.G * 0.587) + (renkler.B * 0.114)));
                    Color yeni_renkler = Color.FromArgb(gri, gri, gri);
                    yeni_resim.SetPixel(i, j, yeni_renkler);
                }

                pictureBox2.Image = yeni_resim;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap yeni_resim = new Bitmap(resim.Width, resim.Height);
            for (int i = 0; i < resim.Width; i++)
            {
                for (int j = 0; j < resim.Height; j++)
  {
                    Color renkler = resim.GetPixel(i, j);
                    int r = (int)(255 - renkler.R);
                    int g = (int)(255 - renkler.G);
                    int b = (int)(255 - renkler.B);
                    Color yeni_renkler = Color.FromArgb(r,g,b);
                    yeni_resim.SetPixel(i, j, yeni_renkler);
                }

                pictureBox2.Image = yeni_resim;

            }
