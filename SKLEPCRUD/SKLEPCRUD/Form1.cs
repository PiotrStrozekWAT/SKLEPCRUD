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
    public partial class FormStart : Form
    {
        SKLEPEntities sklepEntities = new SKLEPEntities(); //połączenie z bazą

        public FormStart()
        {
            InitializeComponent();
        }

        private void open_laptopy_Click(object sender, EventArgs e)
        {
            LaptopyLista laptopylista = new LaptopyLista(sklepEntities);
            laptopylista.Show(); //otworzenie formularza laptopylista

        }
    }
}
