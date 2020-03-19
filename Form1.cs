using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab7_v2
{
    public partial class Form1 : Form
    {
        private List<Drink> drinkList = new List<Drink>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Coffee c1 = new Coffee(400.0, true, true, "Dark");
            Coffee c2 = new Coffee(400.0, true, true, "Regular");

            drinkList.Add(c1);
            drinkList.Add(c2);

            lstReady.Items.Add(c1.Display());
            lstReady.Items.Add(c2.Display());
        }

        private void BtnPrepare_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            int blendIndex = lstBlend.SelectedIndex;
            int drinkIndex = lstDrinks.SelectedIndex;
            if (blendIndex == -1 || drinkIndex == -1)
            {
                MessageBox.Show("Drink and Blend must be selected", "Insuficient information");
            }
            else
            {
                //Code if it is a Coffee
                if (lstDrinks.Items[drinkIndex].ToString() == "Coffee")
                    PrepareCoffee(drinkIndex, blendIndex);
                //Code if there were others drink options

            }
        }

        private void RefreshDrinkList()
        {
            lstReady.Items.Clear();
            foreach (Drink drink in drinkList)
                lstReady.Items.Add(drink.Display());
        }

        private void BtnTake_Click(object sender, EventArgs e)
        {
            int index = lstReady.SelectedIndex;
            if (index != -1)
            {
                drinkList.RemoveAt(index);
                RefreshDrinkList();
                lstDisplay.Items.Clear();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrepareCoffee(int drinkIndex, int blendIndex)
        {
            bool cream = radCream.Checked;
            bool sugar = radSugar.Checked;


            Coffee coffee;
            if (lstBlend.SelectedIndex == 0)
            {
                if (sugar && cream)
                    coffee = new Coffee(300.0, true, true, "Regular");
                else if (sugar && !cream)
                    coffee = new Coffee(300.0, true, false, "Regular");
                else if (!sugar && cream)
                    coffee = new Coffee(300.0, false, true, "Regular");
                else
                    coffee = new Coffee(300.0, false, false, "Regular");
            }
            else
            {
                if (sugar && cream)
                    coffee = new Coffee(300.0, true, true, "Dark");
                else if (sugar && !cream)
                    coffee = new Coffee(300.0, true, false, "Dark");
                else if (!sugar && cream)
                    coffee = new Coffee(300.0, false, true, "Dark");
                else
                    coffee = new Coffee(300.0, false, false, "Dark");
            }

            bool isCoffeeReady = false;
            foreach (Coffee item in drinkList)
            {
                if (coffee == item)
                {
                    isCoffeeReady = true;
                    break;
                }
            }

            if (isCoffeeReady)
                lstDisplay.Items.Add($"There is a coffee ready for you, there's no need to wait preparation!!");
            else
            {
                lstDisplay.Items.Add(coffee.Prepare());
                lstDisplay.Items.Add(coffee.Serve());
                lstReady.Items.Add(coffee.Display());
                drinkList.Add(coffee);
                RefreshDrinkList();
            }
        }

        private void LstDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstDrinks.SelectedIndex;
            if (index != -1)
            {
                if (lstDrinks.Items[index].ToString() == "Coffee")
                    grpCoffeeOptions.Visible = true;
            }
        }
    }
}
