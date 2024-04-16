namespace TcaSolutions.Forms
{
    partial class CreateProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProductForm));
            labelName = new Label();
            labelDescription = new Label();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            labelCostPrice = new Label();
            labelPrice = new Label();
            textBoxStock = new TextBox();
            textBoxCostPrice = new TextBox();
            textBoxBarcode = new TextBox();
            labelBarcode = new Label();
            labelStock = new Label();
            pictureBoxProduct = new PictureBox();
            buttonSelectImage = new Button();
            labelImage = new Label();
            buttonCreateProduct = new Button();
            buttonCancel = new Button();
            dateTimePickerManufacturerDate = new DateTimePicker();
            dateTimePickerExpiryDate = new DateTimePicker();
            labelManufactureDate = new Label();
            labelExpiryDate = new Label();
            textBoxSupplier = new TextBox();
            labelSupplier = new Label();
            comboBoxCategory = new ComboBox();
            labelCategory = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(281, 49);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Nome";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(546, 49);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(58, 15);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Descrição";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(546, 202);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(242, 23);
            textBoxPrice.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(281, 67);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(242, 23);
            textBoxName.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(546, 67);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(242, 23);
            textBoxDescription.TabIndex = 4;
            // 
            // labelCostPrice
            // 
            labelCostPrice.AutoSize = true;
            labelCostPrice.Location = new Point(281, 181);
            labelCostPrice.Name = "labelCostPrice";
            labelCostPrice.Size = new Size(87, 15);
            labelCostPrice.TabIndex = 5;
            labelCostPrice.Text = "Preço de Custo";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(546, 181);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(37, 15);
            labelPrice.TabIndex = 6;
            labelPrice.Text = "Preço";
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new Point(281, 136);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(242, 23);
            textBoxStock.TabIndex = 7;
            // 
            // textBoxCostPrice
            // 
            textBoxCostPrice.Location = new Point(281, 202);
            textBoxCostPrice.Name = "textBoxCostPrice";
            textBoxCostPrice.Size = new Size(242, 23);
            textBoxCostPrice.TabIndex = 8;
            // 
            // textBoxBarcode
            // 
            textBoxBarcode.Location = new Point(546, 136);
            textBoxBarcode.Name = "textBoxBarcode";
            textBoxBarcode.Size = new Size(242, 23);
            textBoxBarcode.TabIndex = 9;
            // 
            // labelBarcode
            // 
            labelBarcode.AutoSize = true;
            labelBarcode.Location = new Point(546, 115);
            labelBarcode.Name = "labelBarcode";
            labelBarcode.Size = new Size(97, 15);
            labelBarcode.TabIndex = 10;
            labelBarcode.Text = "Codigo de Barras";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new Point(281, 115);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(49, 15);
            labelStock.TabIndex = 11;
            labelStock.Text = "Estoque";
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.BackColor = SystemColors.Window;
            pictureBoxProduct.Location = new Point(41, 103);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(183, 162);
            pictureBoxProduct.TabIndex = 12;
            pictureBoxProduct.TabStop = false;
            // 
            // buttonSelectImage
            // 
            buttonSelectImage.Location = new Point(100, 291);
            buttonSelectImage.Name = "buttonSelectImage";
            buttonSelectImage.Size = new Size(75, 23);
            buttonSelectImage.TabIndex = 13;
            buttonSelectImage.Text = "Selecionar";
            buttonSelectImage.UseVisualStyleBackColor = true;
            buttonSelectImage.Click += buttonSelectImage_Click;
            // 
            // labelImage
            // 
            labelImage.AutoSize = true;
            labelImage.Location = new Point(41, 85);
            labelImage.Name = "labelImage";
            labelImage.Size = new Size(51, 15);
            labelImage.TabIndex = 14;
            labelImage.Text = "Imagem";
            // 
            // buttonCreateProduct
            // 
            buttonCreateProduct.Location = new Point(448, 401);
            buttonCreateProduct.Name = "buttonCreateProduct";
            buttonCreateProduct.Size = new Size(75, 23);
            buttonCreateProduct.TabIndex = 15;
            buttonCreateProduct.Text = "Cadastrar";
            buttonCreateProduct.UseVisualStyleBackColor = true;
            buttonCreateProduct.Click += buttonCreateProduct_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(546, 401);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 16;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // dateTimePickerManufacturerDate
            // 
            dateTimePickerManufacturerDate.Location = new Point(281, 334);
            dateTimePickerManufacturerDate.Name = "dateTimePickerManufacturerDate";
            dateTimePickerManufacturerDate.Size = new Size(242, 23);
            dateTimePickerManufacturerDate.TabIndex = 17;
            // 
            // dateTimePickerExpiryDate
            // 
            dateTimePickerExpiryDate.Location = new Point(546, 334);
            dateTimePickerExpiryDate.Name = "dateTimePickerExpiryDate";
            dateTimePickerExpiryDate.Size = new Size(242, 23);
            dateTimePickerExpiryDate.TabIndex = 18;
            // 
            // labelManufactureDate
            // 
            labelManufactureDate.AutoSize = true;
            labelManufactureDate.Location = new Point(281, 316);
            labelManufactureDate.Name = "labelManufactureDate";
            labelManufactureDate.Size = new Size(64, 15);
            labelManufactureDate.TabIndex = 19;
            labelManufactureDate.Text = "Fabricação";
            // 
            // labelExpiryDate
            // 
            labelExpiryDate.AutoSize = true;
            labelExpiryDate.Location = new Point(546, 316);
            labelExpiryDate.Name = "labelExpiryDate";
            labelExpiryDate.Size = new Size(51, 15);
            labelExpiryDate.TabIndex = 20;
            labelExpiryDate.Text = "Validade";
            // 
            // textBoxSupplier
            // 
            textBoxSupplier.Location = new Point(546, 268);
            textBoxSupplier.Name = "textBoxSupplier";
            textBoxSupplier.Size = new Size(242, 23);
            textBoxSupplier.TabIndex = 21;
            // 
            // labelSupplier
            // 
            labelSupplier.AutoSize = true;
            labelSupplier.Location = new Point(546, 250);
            labelSupplier.Name = "labelSupplier";
            labelSupplier.Size = new Size(67, 15);
            labelSupplier.TabIndex = 22;
            labelSupplier.Text = "Fornecedor";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Categoria 1" });
            comboBoxCategory.Location = new Point(281, 268);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(242, 23);
            comboBoxCategory.TabIndex = 23;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(281, 250);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(58, 15);
            labelCategory.TabIndex = 24;
            labelCategory.Text = "Categoria";
            // 
            // CreateProductForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(35, 107, 142);
            ClientSize = new Size(805, 450);
            Controls.Add(labelCategory);
            Controls.Add(comboBoxCategory);
            Controls.Add(labelSupplier);
            Controls.Add(textBoxSupplier);
            Controls.Add(labelExpiryDate);
            Controls.Add(labelManufactureDate);
            Controls.Add(dateTimePickerExpiryDate);
            Controls.Add(dateTimePickerManufacturerDate);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreateProduct);
            Controls.Add(labelImage);
            Controls.Add(buttonSelectImage);
            Controls.Add(pictureBoxProduct);
            Controls.Add(labelStock);
            Controls.Add(labelBarcode);
            Controls.Add(textBoxBarcode);
            Controls.Add(textBoxCostPrice);
            Controls.Add(textBoxStock);
            Controls.Add(labelPrice);
            Controls.Add(labelCostPrice);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(textBoxPrice);
            Controls.Add(labelDescription);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateProductForm";
            Padding = new Padding(5);
            Text = "Cadastrar";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelDescription;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private Label labelCostPrice;
        private Label labelPrice;
        private TextBox textBoxStock;
        private TextBox textBoxCostPrice;
        private TextBox textBoxBarcode;
        private Label labelBarcode;
        private Label labelStock;
        private PictureBox pictureBoxProduct;
        private Button buttonSelectImage;
        private Label labelImage;
        private Button buttonCreateProduct;
        private Button buttonCancel;
        private DateTimePicker dateTimePickerManufacturerDate;
        private DateTimePicker dateTimePickerExpiryDate;
        private Label labelManufactureDate;
        private Label labelExpiryDate;
        private TextBox textBoxSupplier;
        private Label labelSupplier;
        private ComboBox comboBoxCategory;
        private Label labelCategory;
    }
}