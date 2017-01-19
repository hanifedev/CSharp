 int sayi;
 private void button1_Click(object sender, EventArgs e)
 {
    Random s = new Random();
    for (int a = 1; a <= 50; a++)
    {
       sayi = s.Next(1, 100);
       comboBox1.Items.Add(sayi);
    }          
}
private void button2_Click(object sender, EventArgs e)
{
    cpmboBox1.Sorted = true;
}
private void button4_Click(object sender, EventArgs e)
{
     comboBox1.Items.Remove(comboBox1.SelectedItem);
}
private void button3_Click(object sender, EventArgs e)
{
     comboBox1.Items.Clear();
}
private void label1_Click(object sender, EventArgs e)
{
     label1.Text = comboBox1.Items.Count.ToString();
}
