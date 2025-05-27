using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyMealPlanning
{
    public partial class RecipeCard : UserControl
    {
        public RecipeCard()
        {
            InitializeComponent();
        }

        public void SetRecipe(string recipeName, string imagePath)
        {
            lblRecipeName.Text = recipeName;

            string fullImagePath = Path.Combine(Application.StartupPath, imagePath);
            if (File.Exists(fullImagePath))
            {
                pictureBoxRecipe.Image = Image.FromFile(fullImagePath);
                pictureBoxRecipe.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
