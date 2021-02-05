using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Carlson
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            //Populates the surface material combobox
            surfaceMaterials.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            materialsView.DataSource = DeskQuote.quotelist;
        }
    }
}
