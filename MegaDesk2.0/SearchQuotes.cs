using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            Hide();
        }

        private void surfaceMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            int result = surfaceMaterials.FindStringExact(surfaceMaterials.SelectedItem.ToString());
            Array resultArr = surfaceMaterials.DataSource as Array;
            string resultStr = resultArr.GetValue(result).ToString();
            List<DeskQuote> filtered = DeskQuote.quotelist.Where(x => x.Surface == resultStr).ToList();
            materialsView.DataSource = filtered;

        }

        private void showAllQuotesBtn_Click(object sender, EventArgs e)
        {
            materialsView.DataSource = DeskQuote.quotelist;
        }
    }

}
