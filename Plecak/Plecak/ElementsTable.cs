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
    public partial class ElementsTable : Form
    {
        List<Element> list;

        public ElementsTable( List<Element> list, string title = null)
        {
            InitializeComponent();
            if(title != null)
            {
                this.Text = title;
            }
            this.list = list;
            dataGridView1.DataSource = list;

        }
    }
}
