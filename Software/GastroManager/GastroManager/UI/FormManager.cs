using GastroManager.Data;
using GastroManager.Datos;
using GastroManager.Interfaces;
using GastroManager.Logic;

namespace GastroManager
{
    public partial class FormManager : Form
    {

        private bool _IsLoading = false;

        public FormManager()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            //Init colors
            pItems.BackColor = ColorTranslator.FromHtml("#F96436");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            tabControls.SelectedTab = tabIngredients;
            this.Text = "Ingredients";
        }

        private void btnDishes_Click(object sender, EventArgs e)
        {
            tabControls.SelectedTab = tabDishes;
            this.Text = "Dishes";
        }

        private void AdjustPrices()
        {

            numMax.Minimum = numMin.Value;
            numMin.Maximum = numMax.Value;

        }

        private void LoadCategories()
        {
            //Refresh items
            cbCategory.Items.Clear();

            //Init repo for obtains all categories
            var repoCategories = new CategoriesData();
            var logicCategories = new CategoriesLogic(repoCategories);
            var categories = logicCategories.GetCategories();

            //Add categories to the combobox
            cbCategory.Items.Add("All categories");
            cbCategory.Items.AddRange(categories.Select(u => u.CategoryName).ToArray());
            cbCategory.SelectedIndex = 0;

        }

        private void ExecuteFilter()
        {

            if (_IsLoading) return;

            //Clear all dishes of the DataGridView
            dgvDishes.Rows.Clear();

            //Init repo
            var repoDishes = new DishesData();
            var logicDishes = new DishesLogic(repoDishes);

            //Set filters
            string category = cbCategory.Text;
            string name = txtName.Text;
            bool availableIngredients = checkAvailable.Checked;
            int min = Convert.ToInt32(numMin.Value);
            int max = Convert.ToInt32(numMax.Value);

            var dishes = logicDishes.GetFilteredDishes(categoryName: category,
                                                       dishName: name,
                                                       availableIngredients:
                                                       availableIngredients,
                                                       minPrice: min,
                                                       maxPrice: max);

            //Add dishes to the DataGridView
            foreach (var dish in dishes)
            {

                dgvDishes.Rows.Add(dish.DishId, dish.DishName, dish.FinalPriceForClients, "View");

            }

        }

        private void LoadAllDishes()
        {

            //Init repo for obtain all dishes
            var repoDishes = new DishesData();
            var logicDishes = new DishesLogic(repoDishes);

            var dishes = logicDishes.GetDishes();

            //Add dishes to the DataGridView
            foreach (var dish in dishes)
            {

                dgvDishes.Rows.Add(dish.DishId, dish.DishName, dish.FinalPriceForClients, "View");

            }

        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            //Loading state: If isn't complete the others events can't succeed
            _IsLoading = true;

            //Adjust numericupdowns for the minimun and maximun prices
            AdjustPrices();

            //Reload all items
            LoadCategories();
            LoadAllDishes();

            _IsLoading = false;

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExecuteFilter();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ExecuteFilter();
        }

        private void checkAvailable_CheckedChanged(object sender, EventArgs e)
        {
            ExecuteFilter();
        }
        private void minPrice_ValueChanged(object sender, EventArgs e)
        {
            AdjustPrices();
            ExecuteFilter();
        }

        private void maxPrice_ValueChanged(object sender, EventArgs e)
        {

            AdjustPrices();
            ExecuteFilter();

        }

        private void dgvDishes_SelectionChanged(object sender, EventArgs e)
        {
            dgvDishes.ClearSelection();
        }

        private void dgvDishes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDishes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() == "View")
            {

                tabControls.SelectedTab = tabDishDescription;
                this.Text = "Recipes";

            }
        }

    }
}
