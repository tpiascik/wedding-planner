using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wedding_Planner
{
    public partial class Form2 : Form
    {
        List<Guest> guestList;
        int hallCost = 10000;
        int limoCost = 1000;
        int photoCost = 1000;
        int flowerCost = 200;
        int totalCost =0;
        public Form2()
        {

            InitializeComponent();
            
            
        }
        public Form2(List<Guest> gl)
        {
            guestList = new List<Guest>(gl);
            InitializeComponent();
            calculate();
        }
        private void calculate()
        {
            totalCost = limoCost + photoCost + hallCost + flowerCost;
        }
        void ShowParent()
        {
            this.Owner.Show();
            
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            ShowParent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numGuestLabel.Text += guestList.Count.ToString();
            limoLabel.Text += showCurrency(limoCost);
            photoLabel.Text += showCurrency(photoCost);
            hallLabel.Text += showCurrency(hallCost);
            flowerLabel.Text += showCurrency(flowerCost);
            totalLabel.Text += showCurrency(totalCost);
            cppLabel.Text += showCurrency(totalCost/guestList.Count);

        }
        private String showCurrency(int number)
        {
            String num = "";
            for (int i=0; number > 0; number /= 10)
            {
                
                num = number % 10+num;
                i++;
                if (i % 3 == 0)
                {
                    num = "," + num;//proper currency formatting
                }
            }
            return "$"+num;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
