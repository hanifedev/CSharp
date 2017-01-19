for (i = 0; i <= listBox1.Items.Count - 1; i++)
     for (j = i; j <= listBox1.Items.Count - 1; j++)
          if (int.Parse(listBox1.Items[j].ToString()) >
          int.Parse(listBox1.Items[i].ToString()))
          {
               c = int.Parse(listBox1.Items[i].ToString());
               listBox1.Items[i] = listBox1.Items[j];
               listBox1.Items[j] = c.ToString();
          }
for (i = 0; i <= listBox2.Items.Count - 1; i++)
       for (j = i; j <= listBox2.Items.Count - 1; j++)
           if (int.Parse(listBox2.Items[j].ToString()) <
           int.Parse(listBox2.Items[i].ToString()))
           {
                 c = int.Parse(listBox2.Items[i].ToString());
                 listBox2.Items[i] = listBox1.Items[j];
                 listBox2.Items[j] = c.ToString();
           } 
}
