namespace TcaSolutions.Forms
{
    partial class ListProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListProductForm));
            dataGridViewProduct = new DataGridView();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            buttonUpdateProduct = new Button();
            buttonDeleteProduct = new Button();
            button1 = new Button();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            textBoxStock = new TextBox();
            textBoxBarcode = new TextBox();
            textBoxCategory = new TextBox();
            labelName = new Label();
            labelDescription = new Label();
            labelCategory = new Label();
            labelBarcode = new Label();
            labelStock = new Label();
            buttonFilter = new Button();
            panelFilter = new Panel();
            labelFilters = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            panelFilter.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AllowUserToOrderColumns = true;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(12, 113);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowTemplate.Height = 25;
            dataGridViewProduct.Size = new Size(776, 345);
            dataGridViewProduct.TabIndex = 0;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // buttonUpdateProduct
            // 
            buttonUpdateProduct.Location = new Point(332, 476);
            buttonUpdateProduct.Name = "buttonUpdateProduct";
            buttonUpdateProduct.Size = new Size(80, 24);
            buttonUpdateProduct.TabIndex = 16;
            buttonUpdateProduct.Text = "Atualizar";
            buttonUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.BackColor = Color.Red;
            buttonDeleteProduct.FlatStyle = FlatStyle.Popup;
            buttonDeleteProduct.ForeColor = Color.Snow;
            buttonDeleteProduct.Location = new Point(464, 476);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(80, 24);
            buttonDeleteProduct.TabIndex = 17;
            buttonDeleteProduct.Text = "Deletar";
            buttonDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(207, 476);
            button1.Name = "button1";
            button1.Size = new Size(80, 24);
            button1.TabIndex = 18;
            button1.Text = "Ver";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(13, 27);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 19;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(145, 27);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(100, 23);
            textBoxDescription.TabIndex = 20;
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new Point(535, 27);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(100, 23);
            textBoxStock.TabIndex = 22;
            // 
            // textBoxBarcode
            // 
            textBoxBarcode.Location = new Point(407, 27);
            textBoxBarcode.Name = "textBoxBarcode";
            textBoxBarcode.Size = new Size(100, 23);
            textBoxBarcode.TabIndex = 23;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(277, 27);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(100, 23);
            textBoxCategory.TabIndex = 24;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(13, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 15);
            labelName.TabIndex = 25;
            labelName.Text = "Nome";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(145, 9);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(58, 15);
            labelDescription.TabIndex = 26;
            labelDescription.Text = "Descrição";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(277, 10);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(58, 15);
            labelCategory.TabIndex = 27;
            labelCategory.Text = "Categoria";
            // 
            // labelBarcode
            // 
            labelBarcode.AutoSize = true;
            labelBarcode.Location = new Point(407, 10);
            labelBarcode.Name = "labelBarcode";
            labelBarcode.Size = new Size(97, 15);
            labelBarcode.TabIndex = 28;
            labelBarcode.Text = "Código de barras";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new Point(535, 9);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(49, 15);
            labelStock.TabIndex = 29;
            labelStock.Text = "Estoque";
            // 
            // buttonFilter
            // 
            buttonFilter.BackColor = Color.Gray;
            buttonFilter.FlatStyle = FlatStyle.Popup;
            buttonFilter.ForeColor = SystemColors.ActiveCaptionText;
            buttonFilter.Location = new Point(676, 25);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(80, 24);
            buttonFilter.TabIndex = 30;
            buttonFilter.Text = "Filtrar";
            buttonFilter.UseVisualStyleBackColor = false;
            // 
            // panelFilter
            // 
            panelFilter.BorderStyle = BorderStyle.Fixed3D;
            panelFilter.Controls.Add(textBoxName);
            panelFilter.Controls.Add(buttonFilter);
            panelFilter.Controls.Add(textBoxDescription);
            panelFilter.Controls.Add(labelStock);
            panelFilter.Controls.Add(labelName);
            panelFilter.Controls.Add(labelBarcode);
            panelFilter.Controls.Add(labelDescription);
            panelFilter.Controls.Add(labelCategory);
            panelFilter.Controls.Add(textBoxCategory);
            panelFilter.Controls.Add(textBoxStock);
            panelFilter.Controls.Add(textBoxBarcode);
            panelFilter.Location = new Point(12, 32);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(776, 66);
            panelFilter.TabIndex = 31;
            // 
            // labelFilters
            // 
            labelFilters.AutoSize = true;
            labelFilters.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFilters.Location = new Point(12, 9);
            labelFilters.Name = "labelFilters";
            labelFilters.Size = new Size(53, 20);
            labelFilters.TabIndex = 32;
            labelFilters.Text = "Filtros";
            // 
            // ListProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 107, 142);
            ClientSize = new Size(800, 512);
            Controls.Add(labelFilters);
            Controls.Add(panelFilter);
            Controls.Add(button1);
            Controls.Add(buttonDeleteProduct);
            Controls.Add(buttonUpdateProduct);
            Controls.Add(dataGridViewProduct);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListProductForm";
            Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewProduct;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Button buttonUpdateProduct;
        private Button buttonDeleteProduct;
        private Button button1;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private TextBox textBoxStock;
        private TextBox textBoxBarcode;
        private TextBox textBoxCategory;
        private Label labelName;
        private Label labelDescription;
        private Label labelCategory;
        private Label labelBarcode;
        private Label labelStock;
        private Button buttonFilter;
        private Panel panelFilter;
        private Label labelFilters;
    }
}