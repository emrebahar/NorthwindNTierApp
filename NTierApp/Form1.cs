using NTierApp.BLL.Repositories.Concrete;
using NTierApp.Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //DataContext dataContext = new DataContext(); Gereksiz  :)
        Products selectedProducts = new Products();
        CategoryRepository categoryRepository = new CategoryRepository();
        ProductRepository productRepository = new ProductRepository();
        private void Form1_Load(object sender, EventArgs e)
        {
            FillCmbKategori(comboBox1);
            FillCmbKategori(cmbUrunEklemeKategorler);
            FillCmbKategori(cmbGuncellemeKategoriler);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                FillGridView();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //int selectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                //selectedProducts = dataContext.Products.Find(selectedID);
                //txtGuncellemeUrunAd.Text = selectedProducts.ProductName;
                //txtGuncellemeFiyat.Text = selectedProducts.UnitPrice.ToString();
                //nudGuncellemeStok.Value = (int)selectedProducts.UnitsInStock;
                //cmbGuncellemeKategoriler.SelectedValue = selectedProducts.CategoryID;
                //-----------------------//
                int selectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                selectedProducts = productRepository.GetById(selectedID);
                txtGuncellemeUrunAd.Text = selectedProducts.ProductName;
                txtGuncellemeFiyat.Text = selectedProducts.UnitPrice.ToString();
                nudGuncellemeStok.Value = (int)selectedProducts.UnitsInStock;
                cmbGuncellemeKategoriler.SelectedValue = selectedProducts.CategoryID;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata " + ex.Message);
            }
            
            //cmbGuncellemeKategoriler.SelectedIndex = (int)selectedProducts.CategoryID;
        }
        void FillCmbKategori(ComboBox comboBox)
        {
            //comboBox.DisplayMember = "CategoryName";
            //comboBox.ValueMember = "CategoryID";
            //comboBox.DataSource = dataContext.Categories.Select(x => new
            //{
            //    x.CategoryName,
            //    x.CategoryID
            //}).ToList();
            comboBox.DisplayMember = "CategoryName";
            comboBox.ValueMember = "CategoryID";
            comboBox.DataSource = categoryRepository.GetAllCategoryDTO();

        }
        void FillGridView()
        {
            //int selectedCategoryID = Convert.ToInt32(comboBox1.SelectedValue);
            //dataGridView1.DataSource = dataContext.Products.Select(x => new
            //{
            //    x.CategoryID,
            //    x.Categories.CategoryName,
            //    x.ProductID,
            //    x.ProductName,
            //    x.UnitPrice,
            //    x.UnitsInStock
            //}).Where(x => x.CategoryID == selectedCategoryID).ToList();
            //dataGridView1.Columns.Remove("CategoryID");
            dataGridView1.DataSource = productRepository.GetByIdAllProduct((int)comboBox1.SelectedValue);
            dataGridView1.Columns.Remove("CategoryID");

        }
        void FillGridView(int selectedCategoryID)
        {
            //dataGridView1.DataSource = dataContext.Products.Select(x => new
            //{
            //    x.CategoryID,
            //    x.ProductID,
            //    x.ProductName,
            //    x.UnitPrice,
            //    x.UnitsInStock
            //}).Where(x => x.CategoryID == selectedCategoryID).ToList();
            //--------------------//
            dataGridView1.DataSource = productRepository.GetByIdAllProduct(selectedCategoryID);
            dataGridView1.Columns.Remove("CategoryID");
            comboBox1.SelectedValue = selectedCategoryID;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                selectedProducts.ProductName = txtGuncellemeUrunAd.Text;
                selectedProducts.UnitPrice = Convert.ToDecimal(txtGuncellemeFiyat.Text);
                selectedProducts.UnitsInStock = Convert.ToInt16(nudGuncellemeStok.Value);
                selectedProducts.CategoryID = (int)cmbGuncellemeKategoriler.SelectedValue;
                productRepository.Update(); // Update Değiştirldi
                MessageBox.Show("Güncelleme Tamamlandı");
                FillGridView((int)selectedProducts.CategoryID);
                tabControl1.SelectedTab = tabPageUrunListele;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata "+ex.Message);
            }
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //Products newProducts = new Products();
                //newProducts.ProductName = txtEklemeUrunAd.Text;
                //newProducts.UnitPrice = Convert.ToDecimal(txtEklemeFiyat.Text);
                //newProducts.UnitsInStock = Convert.ToInt16(nudEklemeStok.Value);
                //newProducts.CategoryID = (int)cmbUrunEklemeKategorler.SelectedValue;
                //dataContext.Set<Products>().Add(newProducts);
                //dataContext.SaveChanges();
                //MessageBox.Show("Ekleme Tamamlandı.");
                //FillGridView((int)newProducts.CategoryID);
                //tabControl1.SelectedTab = tabPageUrunListele;
                //-*--------------------//
                Products newProduct = new Products();
                newProduct.ProductName = txtEklemeUrunAd.Text;
                newProduct.UnitPrice = Convert.ToDecimal(txtEklemeFiyat.Text);
                newProduct.UnitsInStock = Convert.ToInt16(nudEklemeStok.Value);
                newProduct.CategoryID = (int)cmbUrunEklemeKategorler.SelectedValue;
                productRepository.Add(newProduct); // Add Değiştirildi
                MessageBox.Show("Ekleme Tamamlandı.");
                FillGridView((int)newProduct.CategoryID);
                tabControl1.SelectedTab = tabPageUrunListele;


            }
            catch (Exception ex)
            {
                 MessageBox.Show("Hata! "+ex.Message);
            }
            
        }

        private void UrunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageUrunEkle;
        }

        private void UrunGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                selectedProducts.ProductName = txtGuncellemeUrunAd.Text;
                selectedProducts.UnitPrice = Convert.ToDecimal(txtGuncellemeFiyat.Text);
                selectedProducts.UnitsInStock = Convert.ToInt16(nudGuncellemeStok.Value);
                selectedProducts.CategoryID = (int)cmbGuncellemeKategoriler.SelectedValue;
                tabControl1.SelectedTab = tabPageUrunGuncelle;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata "+ex.Message);
            }
            
        }

        private void UrunSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //int categoryID = (int)selectedProducts.CategoryID;
                //dataContext.Products.Remove(selectedProducts);
                //dataContext.SaveChanges();
                //FillGridView(categoryID);
                //-------------------//
                int categoryID = (int)selectedProducts.CategoryID;
                productRepository.Delete(selectedProducts);
                FillGridView(categoryID);
                MessageBox.Show("Silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            
        }

    }
}
