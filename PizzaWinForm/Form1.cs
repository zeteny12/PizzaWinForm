using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PizzaWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Fájl beolvasása
        private void button_FajlBeolvas_Click(object sender, EventArgs e)
        {
            //Fájl kiválasztása
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pontosvesszővel tagolt csv|*.csv|Szöveges dokumentum|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;     //Az '.exe' fájl mappája
            openFileDialog.Title = "Válassza ki a fájlt";

            //Fájl beolvasása
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBox_BeolvasottPizzak.Items.Add(new Pizza(sr.ReadLine()));   //Átadjuk a 'listBox'-nak
                    }
                }
            }
        }

        //Átlagár
        private void button_Atlagar_Click(object sender, EventArgs e)
        {
            double atlag = 0;
            foreach (Pizza item in listBox_BeolvasottPizzak.Items)
            {
                atlag += item.Pizzaar;
            }
            atlag = atlag / listBox_BeolvasottPizzak.Items.Count;

            MessageBox.Show("A pizzák átlagos ára: " + atlag.ToString("#,##0.0") + "Ft", "Átlagár", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Rendelés leadása
        private void button_RendelesLeadasa_Click(object sender, EventArgs e)
        {
            //Ellenőrizzük, hogy a 'darabszám' értéke helyesen lett-e megadva
            try
            {
                int darabszam = int.Parse(textBox_Darabszam.Text);
                RendelesLeadas();
            }
            catch (Exception)   //Ha nem, akkor közöljük a felhasználóval
            {
                MessageBox.Show("Számmal adja meg a darabszámot!", "Hiba", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void RendelesLeadas()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Szöveges dokumentum|*.txt";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "PizzaRendeles";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string leadottrendeles = Path.GetFileName(saveFileDialog.FileName);     //Csak a fájl neve

                if (File.Exists(saveFileDialog.FileName))
                {
                    //Ha a fájl már létezik, akkor közöljük a felhasználóval, és eldöntheti, hogy felül akarja-e írni, vagy sem
                    DialogResult result = MessageBox.Show("A fájl már létezik. Felülírja?", "Figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    
                    //Ha igen, akkor teljesítjük
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (StreamWriter sw = new StreamWriter(leadottrendeles, false))
                            {
                                //Készpénz vagy Kártya
                                if (radioButton_Keszpenz.Checked == true)
                                {
                                    sw.WriteLine("Fizetési mód: Készpénz");
                                }
                                else if (radioButton_Kartya.Checked == true)
                                {
                                    sw.WriteLine("Fizetési mód: Kártya");
                                }

                                //Igényel-e számlát
                                if (checkBox_Szamla.Checked == true)
                                {
                                    sw.WriteLine("Számla: Igen");
                                }
                                else
                                {
                                    sw.WriteLine("Számla: Nem");
                                }

                                //Kiválasztott pizza nevének kiírása
                                sw.WriteLine($"Kiválasztott pizza: {textBox_KivalasztottPizza.Text}");

                                //Kiválasztott mennyiség kiírása
                                sw.WriteLine($"Kiválasztott mennyiség: {textBox_Darabszam.Text}db");

                                //Végösszeg kiírása --- Ha a kiválasztott pizza neve megyegyezik a listában kiválasztott pizza nevével, akkor a végösszeg egyenlő lesz az adott pizza árával, majd megszorozzuk a megadott mennyiséggel
                                double vegosszeg = 0;
                                if (((Pizza)listBox_BeolvasottPizzak.SelectedItem).Pizzanev == textBox_KivalasztottPizza.Text)
                                {
                                    vegosszeg = ((Pizza)listBox_BeolvasottPizzak.SelectedItem).Pizzaar;
                                    vegosszeg = vegosszeg * double.Parse(textBox_Darabszam.Text);
                                }
                                sw.WriteLine($"Végösszeg: {vegosszeg}Ft\n\n");
                            }

                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show("A művelet végrehajtása sikertelen!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else    //Ha nem akarja, akkor beleírjuk az adatokat
                    {
                        try
                        {
                            using (StreamWriter sw = new StreamWriter(leadottrendeles, true))
                            {
                                //Készpénz vagy Kártya
                                if (radioButton_Keszpenz.Checked == true)
                                {
                                    sw.WriteLine("Fizetési mód: Készpénz");
                                }
                                else if (radioButton_Kartya.Checked == true)
                                {
                                    sw.WriteLine("Fizetési mód: Kártya");
                                }

                                //Igényel-e számlát
                                if (checkBox_Szamla.Checked == true)
                                {
                                    sw.WriteLine("Számla: Igen");
                                }
                                else
                                {
                                    sw.WriteLine("Számla: Nem");
                                }

                                //Kiválasztott pizza nevének kiírása
                                sw.WriteLine($"Kiválasztott pizza: {textBox_KivalasztottPizza.Text}");

                                //Kiválasztott mennyiség kiírása
                                sw.WriteLine($"Kiválasztott mennyiség: {textBox_Darabszam.Text}db");

                                //Végösszeg kiírása --- Ha a kiválasztott pizza neve megyegyezik a listában kiválasztott pizza nevével, akkor a végösszeg egyenlő lesz az adott pizza árával, majd megszorozzuk a megadott mennyiséggel
                                double vegosszeg = 0;
                                if (((Pizza)listBox_BeolvasottPizzak.SelectedItem).Pizzanev == textBox_KivalasztottPizza.Text)
                                {
                                    vegosszeg = ((Pizza)listBox_BeolvasottPizzak.SelectedItem).Pizzaar;
                                    vegosszeg = vegosszeg * double.Parse(textBox_Darabszam.Text);
                                }
                                sw.WriteLine($"Végösszeg: {vegosszeg}Ft\n\n");
                            }

                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show("A művelet végrehajtása sikertelen!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else    //Ha nem létezik a fájl, akkor létrehozzuk, és beleírjuk az adatokat
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(leadottrendeles, true))
                        {
                            //Készpénz vagy Kártya
                            if (radioButton_Keszpenz.Checked == true)
                            {
                                sw.WriteLine("Fizetési mód: Készpénz");
                            }
                            else if (radioButton_Kartya.Checked == true)
                            {
                                sw.WriteLine("Fizetési mód: Kártya");
                            }

                            //Igényel-e számlát
                            if (checkBox_Szamla.Checked == true)
                            {
                                sw.WriteLine("Számla: Igen");
                            }
                            else
                            {
                                sw.WriteLine("Számla: Nem");
                            }

                            //Kiválasztott pizza nevének kiírása
                            sw.WriteLine($"Kiválasztott pizza: {textBox_KivalasztottPizza.Text}");

                            //Kiválasztott mennyiség kiírása
                            sw.WriteLine($"Kiválasztott mennyiség: {textBox_Darabszam.Text}db");

                            //Végösszeg kiírása --- Ha a kiválasztott pizza neve megyegyezik a listában kiválasztott pizza nevével, akkor a végösszeg egyenlő lesz az adott pizza árával, majd megszorozzuk a megadott mennyiséggel
                            double vegosszeg = 0;
                            if (((Pizza)listBox_BeolvasottPizzak.SelectedItem).Pizzanev == textBox_KivalasztottPizza.Text)
                            {
                                vegosszeg = ((Pizza)listBox_BeolvasottPizzak.SelectedItem).Pizzaar;
                                vegosszeg = vegosszeg * double.Parse(textBox_Darabszam.Text);
                            }
                            sw.WriteLine($"Végösszeg: {vegosszeg}Ft\n\n");
                        }

                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("A művelet végrehajtása sikertelen!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Belvasott pizza kijelölése
        private void listBox_BeolvasottPizzak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_BeolvasottPizzak.SelectedIndex >= 0)
            {
                textBox_KivalasztottPizza.Text = ((Pizza)listBox_BeolvasottPizzak.SelectedItem).Pizzanev.ToString();
            }
        }

        //Darabszám -- erre végül nem volt szükség
        private void textBox_Darabszam_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
