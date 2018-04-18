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
    public partial class laptopDetails : Form
    {
        Laptop laptop;
        SKLEPEntities db;

        public laptopDetails(Laptop laptop, SKLEPEntities db)
        {
            this.db = db;
            this.laptop = laptop;
            InitializeComponent();
        }

        private void laptopDetails_Load(object sender, EventArgs e)
        {
            this.textProcesor.Text = laptop.procesor.ToString();
            this.textModel.Text = laptop.model.ToString();
            this.textHDD.Text = laptop.hdd.ToString();
            this.textRAM.Text = laptop.ram.ToString();
            this.textEkran.Text = laptop.ekran.ToString();
            this.textCena.Text = laptop.cena.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            laptop.procesor = int.Parse(this.textProcesor.Text);
            //laptop.model = int.Parse(this.textModel.Text); //model jest kluczem podstawowym i nie da się go zapisać 
            laptop.hdd = int.Parse(this.textHDD.Text);
            laptop.ram = int.Parse(this.textRAM.Text);
            laptop.ekran = int.Parse(this.textEkran.Text);
            laptop.cena = int.Parse(this.textCena.Text);
            db.SaveChanges();

            //Laptop laptopNew = new Laptop();
            //    laptopNew.ram = 141;
            //db.Laptop.Add(laptopNew);
            //db.SaveChanges();

            //db.Laptop.Remove(laptop);
        }
    }
}
