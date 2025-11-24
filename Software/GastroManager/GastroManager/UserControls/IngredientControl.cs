using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GastroManager.UserControls
{
    public partial class IngredientControl : UserControl
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string IngredientName 
        { 
            get 
            { 
                return lblNameIngredient.Tag.ToString(); 
            } 
            set 
            {
                lblNameIngredient.Text = value;
                lblNameIngredient.Tag = value;
            } 
        }
        public int Price;
        public int Stock;
        public string Unit;

        public IngredientControl()
        {
            InitializeComponent();
        }
    }
}
