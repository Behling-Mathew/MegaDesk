using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Behling
{
    public partial class AddQuote : Form
    {
        int tempShipping = 0;
        Material tempMaterial;
        public AddQuote()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            CurrentDate.Text = now.ToString("dd MMMM yyyy");
        }

        private void AddQuoteCancelBtn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void WidthInput_ValueChanged(object sender, EventArgs e)
        {
            widthInput.ForeColor = Color.Teal;
            if (widthInput.Value > Desk.MAXWIDTH || widthInput.Value < Desk.MINWIDTH)
            {
                widthInput.ForeColor = Color.Red;
                MessageBox.Show("Width must be between 24 and 96 inches.", "Out of Bounds", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void GetQuoteBtn_Click(object sender, EventArgs e)
        {

            if ((OakRadioBtn.Checked || LaminateRadioBtn.Checked || PineRadioBtn.Checked || RosewoodRadioBtn.Checked || VeneerRadioBtn.Checked) && FullName.Text != "" && ShippingBox.Text != "Select Shipping")
            {
                Console.WriteLine("A box is checked");



                DisplayQuote viewQuote = new DisplayQuote();
                viewQuote.Tag = this;
                viewQuote.Show(this);
                Hide();
                calcSurfaceArea();
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
                if (FullName.Text == "")
                {
                    MessageBox.Show("Please enter a name.", "Empty Name Field", MessageBoxButtons.OK);
                }
                else if (ShippingBox.Text == "Select Shipping")
                {
                    MessageBox.Show("Please select a shipping method.", "Please Select Shipping", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Please select a surface material.", "Empty Material Field", MessageBoxButtons.OK);
                }
            }


        }

        private void calcSurfaceArea()
        {
            DateTime now = DateTime.Now;
            
            Desk desk = new Desk();
            desk.width = (int)widthInput.Value;
            desk.depth = (int)depthInput.Value;
            int surfaceArea = desk.width * desk.depth;
            //MessageBox.Show(surfaceArea.ToString(), "Surface Area", MessageBoxButtons.OK);
            DeskQuote quote = new DeskQuote();
            int rushOrder = quote.getRushOrder(tempShipping, surfaceArea);
            getMaterial();

            try
            {
                double total = quote.calcPrice(rushOrder, (int)Drawers.Value, tempMaterial, surfaceArea);
                
                MessageBox.Show("Date: "+ now.ToString("dd MMMM yyyy")+ "\n\nName: "+FullName.Text+"\n\nSurface Area: "+surfaceArea+ "\"\n\nMaterial: "+tempMaterial+"\n\n# of drawers: "+Drawers.Value+"\n\nShipping: "+ShippingBox.Text+"\n\nTotal Cost: $"+ total.ToString(), "Quote Summary", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            

        }

        private void getMaterial()
        {
            
            if (OakRadioBtn.Checked)
            {
                tempMaterial = Material.Oak;
            }
            else if (LaminateRadioBtn.Checked)
            {
                tempMaterial = Material.Laminate;
            }
            else if (PineRadioBtn.Checked)
            {
                tempMaterial = Material.Pine;
            }
            else if (RosewoodRadioBtn.Checked)
            {
                tempMaterial = Material.Rosewood;
            }
            else if (VeneerRadioBtn.Checked)
            {
                tempMaterial = Material.Veneer;
            }
            else MessageBox.Show("Please Select a Material", "Material Not Selected");
        }

        private void DepthInput_ValueChanged(object sender, EventArgs e)
        {
            depthInput.ForeColor = Color.Teal;
            if (depthInput.Value > Desk.MAXDEPTH || depthInput.Value < Desk.MINDEPTH)
            {
                depthInput.ForeColor = Color.Red;
                MessageBox.Show("Depth must be between 12 and 48 inches.", "Out of Bounds", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
           else if (char.IsControl((char)depthInput.Value) && char.IsDigit((char)depthInput.Value))
            {
                Console.WriteLine("Testing");
            }
        }

        private void ShippingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ShippingBox.Text == "Standard (14 days)")
            {
                tempShipping = 0;
            }
            else if (ShippingBox.Text == "7-Day")
            {
                tempShipping = 7;
            }
            else if (ShippingBox.Text == "5-Day")
            {
                tempShipping = 5;
            }
            else if (ShippingBox.Text == "3-Day")
            {
                tempShipping = 3;
            }
            else tempShipping = 0;
        }
    }
}
