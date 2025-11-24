namespace GastroManager.UserControls
{
    partial class IngredientControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            numUnit = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numUnit).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 23);
            label1.Name = "label1";
            label1.Size = new Size(205, 34);
            label1.TabIndex = 3;
            label1.Text = "Name of Ingredient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 58);
            label2.Name = "label2";
            label2.Size = new Size(41, 22);
            label2.TabIndex = 4;
            label2.Text = "Price:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Poppins", 9F);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(15, 80);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(46, 22);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Delete";
            // 
            // numUnit
            // 
            numUnit.Location = new Point(171, 65);
            numUnit.Name = "numUnit";
            numUnit.Size = new Size(49, 23);
            numUnit.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F);
            label3.Location = new Point(226, 66);
            label3.Name = "label3";
            label3.Size = new Size(33, 22);
            label3.TabIndex = 7;
            label3.Text = "Unit";
            // 
            // IngredientControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label3);
            Controls.Add(numUnit);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IngredientControl";
            Size = new Size(267, 134);
            ((System.ComponentModel.ISupportInitialize)numUnit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private NumericUpDown numUnit;
        private Label label3;
    }
}
