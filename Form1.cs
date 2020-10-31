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

namespace regisztracios_alkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DateTime most = DateTime.Now;
        private string neme = "";

        private void ment_button_Click(object sender, EventArgs e)
        {
            Boolean nev =true;
            Boolean nem =true;
            Boolean datum = true;
            Boolean hobbi = true;
            string fmsg =" ";

            if (String.IsNullOrEmpty(nev_tb.Text.Trim()))
            {
                nev = false;
                fmsg += "Nem adott meg nevet";
            }

            if (szuletesi_dtp.Value.Date > most.Date)
            {
                fmsg += "Érvénytelen születési dátum, \n vagy formátum";
                datum = false;

            }

            if (n_rb.Checked)
            {
                neme = "Nő";
            }
            else if (f_rb.Checked)
            {
                neme = "Férfi";
            }
            else
            {
                fmsg += "A nemének magadása kötelető";
                nem = false;
            }

            if (hobbi_tb.SelectedIndex<0)
            {
                fmsg = "Nem választottál hobbit";
                hobbi = false;
            }

            if (nev == true && nem ==true && datum==true && hobbi ==true)
            {
                string[] hobbik = new string[hobbi_tb.Items.Count];
                string teszt;

                for (int i = 0; i < hobbik.Length; i++)
                {
                    hobbik[i] = hobbi_tb.Items[i].ToString();
                }

                mentes mentes = new mentes(nev_tb.Text, neme,hobbik, hobbi_tb.SelectedIndex.ToString(), szuletesi_dtp.Value.Date);

                DialogResult valami = mentess.ShowDialog();

                StreamWriter sw = new StreamWriter(mentess.FileName);
                sw.WriteLine("{0};{1};{2};{3};{4}", mentes.Nev, mentes.Nem, mentes.Hobbi, mentes.Khobbi, String.Join("-", mentes.Szul));

                sw.Close();


            }

        }

        private void betolt_button_Click(object sender, EventArgs e)
        {
            string[] listbox;

            DialogResult valami = ofd_nyit.ShowDialog();

            StreamReader sr = new StreamReader(ofd_nyit.FileName);
            hobbi_tb.Items.Clear();

            while (!sr.EndOfStream)
            {
                listbox = sr.ReadLine().Split(';');
                nev_tb.Text = listbox[0];

                szuletesi_dtp.Value = Convert.ToDateTime(listbox[1]);

                string[] betoltotthobbik = listbox[2].Split('-');
                foreach (string elem in betoltotthobbik)
                {
                    hobbi_tb.Items.Add(elem);
                }

                if (listbox [4] == "férfi")
                {
                    f_rb.Checked = true;
                }
                else
                {
                    n_rb.Checked = true;
                }


            }
        }

        private void h_h_button_Click(object sender, EventArgs e)
        {
            string helyi = hh_tb.Text.Trim();
            if (!String.IsNullOrEmpty(helyi) && !hobbi_tb.Items.Contains(helyi))
            {
                hobbi_tb.Items.Add(helyi);
                hh_tb.Clear();
            }
        }

        private void hobbi_tb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hobbi_tb.SelectedItem != null)
            {
                hh_tb.Text = hobbi_tb.SelectedItem.ToString();
            }
        }
    }
}
