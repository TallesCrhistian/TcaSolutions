namespace TcaSolutions.Forms
{
    partial class MainForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForms));
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBoxProducts = new PictureBox();
            label1 = new Label();
            pictureBoxCheckout = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCheckout).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(pictureBoxProducts, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBoxCheckout, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // pictureBoxProducts
            // 
            pictureBoxProducts.Anchor = AnchorStyles.None;
            pictureBoxProducts.Image = (Image)resources.GetObject("pictureBoxProducts.Image");
            pictureBoxProducts.Location = new Point(96, 234);
            pictureBoxProducts.Name = "pictureBoxProducts";
            pictureBoxProducts.Size = new Size(207, 181);
            pictureBoxProducts.TabIndex = 0;
            pictureBoxProducts.TabStop = false;
            pictureBoxProducts.Click += pictureBoxProducts_Click;
            pictureBoxProducts.MouseLeave += pictureBoxProducts_MouseLeave;
            pictureBoxProducts.MouseHover += pictureBoxProducts_MouseHover;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(569, 177);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 5;
            label1.Text = "Caixa";
            // 
            // pictureBoxCheckout
            // 
            pictureBoxCheckout.Anchor = AnchorStyles.None;
            pictureBoxCheckout.Image = (Image)resources.GetObject("pictureBoxCheckout.Image");
            pictureBoxCheckout.Location = new Point(496, 234);
            pictureBoxCheckout.Name = "pictureBoxCheckout";
            pictureBoxCheckout.Size = new Size(207, 181);
            pictureBoxCheckout.TabIndex = 5;
            pictureBoxCheckout.TabStop = false;
            pictureBoxCheckout.MouseLeave += pictureBoxCheckout_MouseLeave;
            pictureBoxCheckout.MouseHover += pictureBoxCheckout_MouseHover;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(156, 177);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 6;
            label2.Text = "Produtos";
            // 
            // MainForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 107, 142);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecionar Seção";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCheckout).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBoxProducts;
        private PictureBox pictureBoxCheckout;
        private Label label1;
        private Label label2;
    }
}