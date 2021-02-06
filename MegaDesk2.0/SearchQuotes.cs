using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

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

        public void addColumns()
        {

            materialsView.Columns.Add("DeskWidth", "DeskWidth");
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

        private void materialsView__CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if ((materialsView.Rows[e.RowIndex].DataBoundItem != null) &&
                 (materialsView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(
                              materialsView.Rows[e.RowIndex].DataBoundItem,
                              materialsView.Columns[e.ColumnIndex].DataPropertyName
                            );
            }

        }

        private string BindProperty(object property, string propertyName)
        {
            string retValue = "";

            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;

                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;

                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }

            return retValue;
        }

    }

}
