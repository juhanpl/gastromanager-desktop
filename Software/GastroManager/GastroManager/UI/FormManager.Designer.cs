namespace GastroManager
{
    partial class FormManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControls = new TabControl();
            tabDishes = new TabPage();
            dgvDishes = new DataGridView();
            colDishId = new DataGridViewTextBoxColumn();
            colDishName = new DataGridViewTextBoxColumn();
            colPortionPrice = new DataGridViewTextBoxColumn();
            colDetails = new DataGridViewLinkColumn();
            numMax = new NumericUpDown();
            numMin = new NumericUpDown();
            lblPrice = new Label();
            checkAvailable = new CheckBox();
            txtName = new TextBox();
            lblName = new Label();
            cbCategory = new ComboBox();
            lblCategory = new Label();
            label2 = new Label();
            label1 = new Label();
            tabIngredients = new TabPage();
            tabDishDescription = new TabPage();
            label10 = new Label();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            button1 = new Button();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            pItems = new FlowLayoutPanel();
            btnDishes = new Button();
            btnIngredients = new Button();
            btnExit = new Button();
            colStock = new DataGridViewCheckBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colCost = new DataGridViewTextBoxColumn();
            tabControls.SuspendLayout();
            tabDishes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDishes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMin).BeginInit();
            tabDishDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pItems.SuspendLayout();
            SuspendLayout();
            // 
            // tabControls
            // 
            tabControls.Controls.Add(tabDishes);
            tabControls.Controls.Add(tabIngredients);
            tabControls.Controls.Add(tabDishDescription);
            tabControls.Location = new Point(166, -25);
            tabControls.Name = "tabControls";
            tabControls.SelectedIndex = 0;
            tabControls.Size = new Size(640, 492);
            tabControls.TabIndex = 1;
            // 
            // tabDishes
            // 
            tabDishes.Controls.Add(dgvDishes);
            tabDishes.Controls.Add(numMax);
            tabDishes.Controls.Add(numMin);
            tabDishes.Controls.Add(lblPrice);
            tabDishes.Controls.Add(checkAvailable);
            tabDishes.Controls.Add(txtName);
            tabDishes.Controls.Add(lblName);
            tabDishes.Controls.Add(cbCategory);
            tabDishes.Controls.Add(lblCategory);
            tabDishes.Controls.Add(label2);
            tabDishes.Controls.Add(label1);
            tabDishes.Location = new Point(4, 24);
            tabDishes.Name = "tabDishes";
            tabDishes.Padding = new Padding(3);
            tabDishes.Size = new Size(632, 464);
            tabDishes.TabIndex = 1;
            tabDishes.Text = "tabPage2";
            tabDishes.UseVisualStyleBackColor = true;
            // 
            // dgvDishes
            // 
            dgvDishes.AllowUserToAddRows = false;
            dgvDishes.AllowUserToDeleteRows = false;
            dgvDishes.AllowUserToOrderColumns = true;
            dgvDishes.AllowUserToResizeColumns = false;
            dgvDishes.AllowUserToResizeRows = false;
            dgvDishes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDishes.Columns.AddRange(new DataGridViewColumn[] { colDishId, colDishName, colPortionPrice, colDetails });
            dgvDishes.Location = new Point(33, 170);
            dgvDishes.MultiSelect = false;
            dgvDishes.Name = "dgvDishes";
            dgvDishes.Size = new Size(537, 257);
            dgvDishes.TabIndex = 12;
            dgvDishes.CellContentClick += dgvDishes_CellContentClick;
            dgvDishes.SelectionChanged += dgvDishes_SelectionChanged;
            // 
            // colDishId
            // 
            colDishId.HeaderText = "Dish Id";
            colDishId.Name = "colDishId";
            colDishId.ReadOnly = true;
            colDishId.Visible = false;
            // 
            // colDishName
            // 
            colDishName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDishName.HeaderText = "Dish Name";
            colDishName.Name = "colDishName";
            colDishName.ReadOnly = true;
            // 
            // colPortionPrice
            // 
            colPortionPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPortionPrice.HeaderText = "Portion Price";
            colPortionPrice.Name = "colPortionPrice";
            colPortionPrice.ReadOnly = true;
            // 
            // colDetails
            // 
            colDetails.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDetails.HeaderText = "Details";
            colDetails.Name = "colDetails";
            colDetails.ReadOnly = true;
            // 
            // numMax
            // 
            numMax.Location = new Point(512, 126);
            numMax.Name = "numMax";
            numMax.Size = new Size(41, 23);
            numMax.TabIndex = 10;
            numMax.Value = new decimal(new int[] { 15, 0, 0, 0 });
            numMax.ValueChanged += maxPrice_ValueChanged;
            // 
            // numMin
            // 
            numMin.Location = new Point(465, 126);
            numMin.Name = "numMin";
            numMin.Size = new Size(41, 23);
            numMin.TabIndex = 8;
            numMin.ValueChanged += minPrice_ValueChanged;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Poppins Medium", 8F, FontStyle.Bold);
            lblPrice.Location = new Point(340, 128);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(119, 19);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price (min-max):";
            // 
            // checkAvailable
            // 
            checkAvailable.AutoSize = true;
            checkAvailable.Font = new Font("Poppins", 8F);
            checkAvailable.Location = new Point(36, 124);
            checkAvailable.Name = "checkAvailable";
            checkAvailable.Size = new Size(266, 23);
            checkAvailable.TabIndex = 6;
            checkAvailable.Text = "Show only dishes with available ingredients";
            checkAvailable.UseVisualStyleBackColor = true;
            checkAvailable.CheckedChanged += checkAvailable_CheckedChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(397, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(173, 23);
            txtName.TabIndex = 5;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Poppins Medium", 8F, FontStyle.Bold);
            lblName.Location = new Point(340, 89);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 19);
            lblName.TabIndex = 4;
            lblName.Text = "Name:";
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(111, 86);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(121, 23);
            cbCategory.TabIndex = 3;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Poppins Medium", 8F, FontStyle.Bold);
            lblCategory.Location = new Point(33, 89);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 19);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 53);
            label2.Name = "label2";
            label2.Size = new Size(516, 22);
            label2.TabIndex = 1;
            label2.Text = "Explore our full menu below. Use the filter to see only dishes with available ingredients.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 19);
            label1.Name = "label1";
            label1.Size = new Size(143, 34);
            label1.TabIndex = 0;
            label1.Text = "List of Dishes";
            // 
            // tabIngredients
            // 
            tabIngredients.Location = new Point(4, 24);
            tabIngredients.Name = "tabIngredients";
            tabIngredients.Padding = new Padding(3);
            tabIngredients.Size = new Size(632, 464);
            tabIngredients.TabIndex = 0;
            tabIngredients.Text = "tabPage1";
            tabIngredients.UseVisualStyleBackColor = true;
            // 
            // tabDishDescription
            // 
            tabDishDescription.Controls.Add(label10);
            tabDishDescription.Controls.Add(numericUpDown1);
            tabDishDescription.Controls.Add(label7);
            tabDishDescription.Controls.Add(button1);
            tabDishDescription.Controls.Add(label6);
            tabDishDescription.Controls.Add(label3);
            tabDishDescription.Controls.Add(label4);
            tabDishDescription.Controls.Add(label5);
            tabDishDescription.Controls.Add(label8);
            tabDishDescription.Controls.Add(dataGridView1);
            tabDishDescription.Controls.Add(label9);
            tabDishDescription.Controls.Add(pictureBox1);
            tabDishDescription.Location = new Point(4, 24);
            tabDishDescription.Name = "tabDishDescription";
            tabDishDescription.Padding = new Padding(3);
            tabDishDescription.Size = new Size(632, 464);
            tabDishDescription.TabIndex = 2;
            tabDishDescription.Text = "tabDishDescription";
            tabDishDescription.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoEllipsis = true;
            label10.AutoSize = true;
            label10.Font = new Font("Poppins Medium", 8F, FontStyle.Bold);
            label10.Location = new Point(43, 126);
            label10.Name = "label10";
            label10.Size = new Size(125, 19);
            label10.TabIndex = 22;
            label10.Text = "Short Description:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(384, 56);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(47, 23);
            numericUpDown1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins Medium", 8F, FontStyle.Bold);
            label7.Location = new Point(310, 87);
            label7.Name = "label7";
            label7.Size = new Size(79, 19);
            label7.TabIndex = 21;
            label7.Text = "Total Cost:";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            button1.Location = new Point(220, 401);
            button1.Name = "button1";
            button1.Size = new Size(130, 30);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 8F, FontStyle.Bold);
            label6.Location = new Point(310, 58);
            label6.Name = "label6";
            label6.Size = new Size(68, 19);
            label6.TabIndex = 19;
            label6.Text = "Servings:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 20);
            label3.Name = "label3";
            label3.Size = new Size(112, 34);
            label3.TabIndex = 16;
            label3.Text = "Recipe for";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 8F, FontStyle.Bold);
            label4.Location = new Point(43, 58);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 17;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Medium", 8F, FontStyle.Bold);
            label5.Location = new Point(43, 87);
            label5.Name = "label5";
            label5.Size = new Size(101, 19);
            label5.TabIndex = 18;
            label5.Text = "Cooking Time:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label8.Location = new Point(43, 167);
            label8.Name = "label8";
            label8.Size = new Size(108, 28);
            label8.TabIndex = 15;
            label8.Text = "Ingredients";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colStock, colName, colQuantity, colUnit, colCost });
            dataGridView1.Location = new Point(26, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(324, 183);
            dataGridView1.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label9.Location = new Point(413, 167);
            label9.Name = "label9";
            label9.Size = new Size(66, 28);
            label9.TabIndex = 11;
            label9.Text = "Image";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(399, 205);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 183);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pItems
            // 
            pItems.Controls.Add(btnDishes);
            pItems.Controls.Add(btnIngredients);
            pItems.Controls.Add(btnExit);
            pItems.Dock = DockStyle.Left;
            pItems.Location = new Point(0, 0);
            pItems.Name = "pItems";
            pItems.Size = new Size(175, 450);
            pItems.TabIndex = 13;
            // 
            // btnDishes
            // 
            btnDishes.BackColor = Color.White;
            btnDishes.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDishes.Location = new Point(3, 3);
            btnDishes.Name = "btnDishes";
            btnDishes.Size = new Size(168, 40);
            btnDishes.TabIndex = 0;
            btnDishes.Text = "Dishes";
            btnDishes.UseVisualStyleBackColor = false;
            btnDishes.Click += btnDishes_Click;
            // 
            // btnIngredients
            // 
            btnIngredients.BackColor = Color.White;
            btnIngredients.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnIngredients.Location = new Point(3, 49);
            btnIngredients.Name = "btnIngredients";
            btnIngredients.Size = new Size(168, 40);
            btnIngredients.TabIndex = 1;
            btnIngredients.Text = "Ingredients";
            btnIngredients.UseVisualStyleBackColor = false;
            btnIngredients.Click += btnIngredients_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnExit.Location = new Point(3, 95);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(168, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // colStock
            // 
            colStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStock.FillWeight = 48.8505974F;
            colStock.HeaderText = "";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.FillWeight = 126.903557F;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colQuantity.FillWeight = 108.081963F;
            colQuantity.HeaderText = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colUnit
            // 
            colUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUnit.FillWeight = 108.081963F;
            colUnit.HeaderText = "Unit";
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            // 
            // colCost
            // 
            colCost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCost.FillWeight = 108.081963F;
            colCost.HeaderText = "Cost";
            colCost.Name = "colCost";
            colCost.ReadOnly = true;
            // 
            // FormManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pItems);
            Controls.Add(tabControls);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dishes";
            Load += FormManager_Load;
            tabControls.ResumeLayout(false);
            tabDishes.ResumeLayout(false);
            tabDishes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDishes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMin).EndInit();
            tabDishDescription.ResumeLayout(false);
            tabDishDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pItems.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControls;
        private TabPage tabDishes;
        private TabPage tabIngredients;
        private Label label2;
        private Label label1;
        private CheckBox checkAvailable;
        private TextBox txtName;
        private Label lblName;
        private ComboBox cbCategory;
        private Label lblCategory;
        private NumericUpDown numMax;
        private NumericUpDown numMin;
        private Label lblPrice;
        private DataGridView dgvDishes;
        private DataGridViewTextBoxColumn colDishId;
        private DataGridViewTextBoxColumn colDishName;
        private DataGridViewTextBoxColumn colPortionPrice;
        private DataGridViewLinkColumn colDetails;
        private FlowLayoutPanel pItems;
        private Button btnDishes;
        private Button btnIngredients;
        private Button btnExit;
        private TabPage tabDishDescription;
        private PictureBox pictureBox1;
        private Label label10;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private Button button1;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private DataGridView dataGridView1;
        private Label label9;
        private DataGridViewCheckBoxColumn colStock;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colCost;
    }
}
