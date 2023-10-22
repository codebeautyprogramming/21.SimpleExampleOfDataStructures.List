using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class IngredientsForm : Form
    {
        public IngredientsForm()
        {
            InitializeComponent();
        }

        private void AddToFridgeBtn_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient
            {
                Name = NameTxt.Text,
                Type = TypeTxt.Text,
                Weight = WeightNum.Value,
                KcalPer100g = KcalPer100gNum.Value,
                PricePer100g = PricePer100gNum.Value
            };

            string message = $@"
            {ingredient.Name}
            {ingredient.Type}
            {ingredient.Weight}
            {ingredient.KcalPer100g}
            {ingredient.PricePer100g}";
            
            MessageBox.Show(message);
        }
    }
}

public class Ingredient
{
    public string Name { get; set; }
    public string Type { get; set; }
    public decimal Weight { get; set; }
    public decimal KcalPer100g { get; set; }
    public decimal PricePer100g { get; set; }
}