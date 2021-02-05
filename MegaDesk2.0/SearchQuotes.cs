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

        private void materialsView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void surfaceMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
