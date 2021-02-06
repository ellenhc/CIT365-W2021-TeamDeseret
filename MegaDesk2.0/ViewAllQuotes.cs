using System;
using System.Windows.Forms;

namespace MegaDesk_Carlson
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            materialsView.DataSource = DeskQuote.quotelist;
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            Hide();
        }
    }
}
