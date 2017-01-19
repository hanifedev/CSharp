private void Form1_Load(object sender, EventArgs e)
        {
            LinkLabel linkLabel1 = new LinkLabel();
            this.Controls.Add(linkLabel1);
            linkLabel1.Text = "Dosya";
            linkLabel1.Font = new Font("Arial", 12, FontStyle.Bold);
            linkLabel1.ForeColor = Color.Red;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(10, 15);
         

            LinkLabel linkLabel2 = new LinkLabel();
            this.Controls.Add(linkLabel2);
            linkLabel2.Text = "Düzen";
            linkLabel2.Font = new Font("Arial", 12, FontStyle.Bold);
            linkLabel2.ForeColor = Color.Red;
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(80, 15);
       

            LinkLabel linkLabel3 = new LinkLabel();
            this.Controls.Add(linkLabel3);
            linkLabel3.Text = "Hakkımızda";
            linkLabel3.Font = new Font("Arial", 12, FontStyle.Bold);
            linkLabel3.ForeColor = Color.Red;
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(150, 15);
            linkLabel3.Click+= new EventHandler(linkLabel3_Click);


            

            LinkLabel linkLabel4 = new LinkLabel();
            this.Controls.Add(linkLabel4);
            linkLabel4.Text = "Kapat";
            linkLabel4.Font = new Font("Arial", 12, FontStyle.Bold);
            linkLabel4.ForeColor = Color.Red;
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(250, 15);
            
        }

        private void linkLabel3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            form.BringToFront();
        }
