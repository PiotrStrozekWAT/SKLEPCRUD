using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKLEPCRUD
{
    public partial class LaptopyLista : Form
    {
        SKLEPEntities db; //db jest instancją wywołaną w formularzu głównym

        public LaptopyLista(SKLEPEntities sklepEntities) //wywołanie konstruktora
        {
            db = sklepEntities; //wywołanie 
            InitializeComponent();
        }

        private void LaptopyLista_Load(object sender, EventArgs e)
        {
            this.gridLaptopy.DataSource = db.Laptop.ToList(); //załaduj laptopy z bazy danych

        }

        private void gridLaptopy_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Laptop selectedLaptop = (Laptop)((DataGridView)sender).CurrentRow.DataBoundItem; //wskazanie wybranego wiersza - rzutowanie zmiennych
            laptopDetails laptopDetails = new laptopDetails(selectedLaptop, db);
            laptopDetails.Show(); //otwiera forumlarz
        }
    }
}
