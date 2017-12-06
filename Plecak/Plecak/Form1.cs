using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plecak
{
    public partial class fError : Form
    {
        ListOfElements list = new ListOfElements();
        public fError()
        {            
            InitializeComponent();

            if (list.Count <= 0)
            {
                bWeight.Enabled = false;
                bPrice.Enabled = false;
                priceError.Visible = false;
                weightError.Visible = false;
                listaPosortowamaCenaWagaToolStripMenuItem.Enabled = false;
                listaWygenerowanychElementówToolStripMenuItem.Enabled = false;
                plecakToolStripMenuItem.Enabled = false;
                MaximumSize = Size;
                MinimumSize = Size;
            }
        }

        //przycisk generujący wszystkie dane
        private void button1_Click(object sender, EventArgs e)
        {
            if(nWeightMax.Value <= 0 || nWeightMin.Value <= 0 || nPriceMax.Value <= 0 || nPriceMin.Value <= 0 || nBackpackSize.Value <= 0 || nNumberOfElements.Value <= 0)
            {
                lError.Visible = true;
                return;
            }
            
            if(check_values((int)nWeightMin.Value, (int)nWeightMax.Value))
            {
                lError.Visible = true;
                return;
            }

            if(check_values((int)nPriceMin.Value, (int)nPriceMax.Value))
            {
                lError.Visible = true;
                return;
            }

            int copy = 1;
            if(nMaxCopyOfElement.Value > 1)
            {
                copy = (int)nMaxCopyOfElement.Value;
            }

            lError.Visible = false;

            Random rnd = new Random();

            for(int i = 0; i<nNumberOfElements.Value; i++)
            {
                if (list.Count <= 0)
                    list.Clear();
                list.Add(new Element(rnd.Next((int)nWeightMin.Value, (int)nWeightMax.Value), rnd.Next((int)nPriceMin.Value, (int)nPriceMax.Value), rnd.Next(1,copy)));   
            }

            bWeight.Enabled = true;
            bPrice.Enabled = true;
            listaWygenerowanychElementówToolStripMenuItem.Enabled = true;
            listaPosortowamaCenaWagaToolStripMenuItem.Enabled = true;

        }


        //przycisk generujący zmianę wartości
        private void bPrice_Click(object sender, EventArgs e)
        {
           if(nPriceMax.Value <= 0 || nPriceMin.Value <=0 )
            {
                priceError.Visible = true;
                return;
            }
            priceError.Visible = false;

            Random rnd = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].price = rnd.Next((int)nPriceMin.Value, (int)nPriceMax.Value);
            }

        }


        //przycisk generującu zmianę wagi
        private void bWeight_Click(object sender, EventArgs e)
        {
            if(nWeightMax.Value <= 0 || nWeightMin.Value <=0 )
            {
                weightError.Visible = true;
               return;
            }
            weightError.Visible = false;

            Random rnd = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].weight = rnd.Next((int)nWeightMin.Value, (int)nWeightMax.Value);
            }

        }

        //sprawdzanie czy wartości wpisane w pola numeric sa poprawne
        private bool check_values(int min, int max)
        {
            if(min >= max)
            {
                return true;
            }
            return false;

        }

        private void listaWygenerowanychElementówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElementsTable table = new ElementsTable(list, "Lista elementów");
            table.Show();          
        }

        private void listaPosortowamaCenaWagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Thief thief = new Thief();
            thief.bubblesort(list);
            ElementsTable table = new ElementsTable(thief.LOE);
            table.Show();
        }

        private void plecakToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        ///wywoływanie algorytmu zachłanny 0 waga min
        private void zachłannyWagaMinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thief thief = new Thief(list,(int)nBackpackSize.Value);
            thief.n_element_min_weight();
            ElementsTable table = new ElementsTable(thief.LOE, "Elementy posortowane od waga min");
            table.Show();

            ElementsTable tableBckpack = new ElementsTable(thief.BP, "Elementy dodane do plecaka");
            tableBckpack.Show();

        }

        ///wywoływanie lalgorytmu zachłanny 0 max cena
        private void zachłannyCenaMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thief thief = new Thief(list, (int)nBackpackSize.Value);
            thief.n_element_max_price();
            ElementsTable table = new ElementsTable(thief.LOE, "Elementy posortowane od cena max");
            table.Show();

            ElementsTable tableBackpack = new ElementsTable(thief.BP,"Elementy dodane do plecaka");
            tableBackpack.Show();

        }

        ///wywoływanie algorytmu zachłanny 0 cena / waga
        private void zachłannyCenaWagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thief thief = new Thief(list, (int)nBackpackSize.Value);
            thief.n_element_price_weight();
            ElementsTable table = new ElementsTable(thief.LOE, "Elementy posortowane cena / waga");
            table.Show();

            ElementsTable tableBackpack = new ElementsTable(thief.BP, "Elementy dodane do plecaka");
            tableBackpack.Show();
        }

        /// <summary>
        /// zachłanny wyświetla plecak i listę elementów oraż ilość, zależny od wagi elementu
        /// zmniejsza ilość elementów na liście
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zachłannyWagaMinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thief thief = new Thief(list, (int)nBackpackSize.Value);
            thief.r_element_min_weight();
            ElementsTable table = new ElementsTable(thief.LOE, "Elementy posortowane od waga min");
            table.Show();

            ElementsTable tableBckpack = new ElementsTable(thief.BP, "Elementy dodane do plecaka");
            tableBckpack.Show();
        }

        /// <summary>
        /// zachłanny wyświetla plecak i listę elementów oraz ilość, zależny od ceny elementu
        /// zmniejsza ilość elementów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zachłannyCenaMaxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thief thief = new Thief(list, (int)nBackpackSize.Value);
            thief.r_element_max_price();
            ElementsTable table = new ElementsTable(thief.LOE, "Elementy posortowane od cena max");
            table.Show();

            ElementsTable tableBackpack = new ElementsTable(thief.BP, "Elementy dodane do plecaka");
            tableBackpack.Show();
        }

        /// <summary>
        /// zachłanny wyświetla plecak i listę elementów oraz ilość, zależny od ceny / masy elementu
        /// zmniejsza ilość elementów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zachłannyCenaWagaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thief thief = new Thief(list, (int)nBackpackSize.Value);
            thief.r_element_price_weight();
            ElementsTable table = new ElementsTable(thief.LOE, "Elementy posortowane cena / waga");
            table.Show();

            ElementsTable tableBackpack = new ElementsTable(thief.BP, "Elementy dodane do plecaka");
            tableBackpack.Show();
        }
    }
}
