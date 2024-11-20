using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sem.Zvd.Ind.OOP;

namespace Sem.Zvd.Ind.OOP
{
    public partial class fMain : Form
    {
        private CCircle currentCircle;  
        private CTriangle currentTriangle;  
        private int EmblemCount = 0;

        private object[] figures = new object[100];

        public fMain()
        {
            InitializeComponent();
            
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateCircle_Click(object sender, EventArgs e)
        {
            Graphics graphics = pnMain.CreateGraphics();
            currentCircle = new CCircle(graphics, pnMain.Width / 2, pnMain.Height / 2, 50);
            figures[EmblemCount] = currentCircle; 
            cmbEmblema.Items.Add("Circle " + EmblemCount);  
            EmblemCount++;
            currentCircle.Show();

        }

        private void btnCreateTriangle_Click(object sender, EventArgs e)
        {
            Graphics graphics = pnMain.CreateGraphics();
            currentTriangle = new CTriangle(graphics, pnMain.Width / 2, pnMain.Height / 2, 50);
            figures[EmblemCount] = currentTriangle; 
            cmbEmblema.Items.Add("Triangle " + EmblemCount);  
            EmblemCount++;
            currentTriangle.Show();


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cmbEmblema.SelectedItem != null)
            {
                string selectedItem = cmbEmblema.SelectedItem.ToString();
                if (selectedItem.StartsWith("Circle"))
                {
                    currentCircle.Show();  
                }
                else if (selectedItem.StartsWith("Triangle"))
                {
                    currentTriangle.Show();  
                }
            }

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (cmbEmblema.SelectedItem != null)
            {
                string selectedItem = cmbEmblema.SelectedItem.ToString();
                if (selectedItem.StartsWith("Circle"))
                {
                    currentCircle.Hide();  
                }
                else if (selectedItem.StartsWith("Triangle"))
                {
                    currentTriangle.Hide(); 
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (cmbEmblema.SelectedItem != null)
            {
                string selectedItem = cmbEmblema.SelectedItem.ToString();
                if (selectedItem.StartsWith("Circle"))
                {
                    currentCircle.Move(0, -10);  
                }
                else if (selectedItem.StartsWith("Triangle"))
                {
                    currentTriangle.Move(0, -10);  
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (cmbEmblema.SelectedItem != null)
            {
                string selectedItem = cmbEmblema.SelectedItem.ToString();
                if (selectedItem.StartsWith("Circle"))
                {
                    currentCircle.Move(0, 10);  
                }
                else if (selectedItem.StartsWith("Triangle"))
                {
                    currentTriangle.Move(0, 10); 
                }
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (cmbEmblema.SelectedItem != null)
            {
                string selectedItem = cmbEmblema.SelectedItem.ToString();
                if (selectedItem.StartsWith("Circle"))
                {
                    currentCircle.Move(-10, 0);  
                }
                else if (selectedItem.StartsWith("Triangle"))
                {
                    currentTriangle.Move(-10, 0);  
                }
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            if (cmbEmblema.SelectedItem != null)
            {
                string selectedItem = cmbEmblema.SelectedItem.ToString();
                if (selectedItem.StartsWith("Circle"))
                {
                    currentCircle.Move(10, 0);  
                }
                else if (selectedItem.StartsWith("Triangle"))
                {
                    currentTriangle.Move(10, 0);  
                }
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (cmbEmblema.SelectedItem != null)
            {
                string selectedItem = cmbEmblema.SelectedItem.ToString();
                if (selectedItem.StartsWith("Circle"))
                {
                    currentCircle.Expand(5);  
                }
                else if (selectedItem.StartsWith("Triangle"))
                {
                    currentTriangle.Expand(5); 
                }
            }
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (cmbEmblema.SelectedItem != null)
            {
                string selectedItem = cmbEmblema.SelectedItem.ToString();
                if (selectedItem.StartsWith("Circle"))
                {
                    currentCircle.Collapse(5); 
                }
                else if (selectedItem.StartsWith("Triangle"))
                {
                    currentTriangle.Collapse(5);  
                }
            }
        }
    }
}
