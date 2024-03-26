namespace lab4WinForms
{
    partial class AdminWindow
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
            components = new System.ComponentModel.Container();
            ProductListView = new ListView();
            GoodsName = new ColumnHeader();
            Id = new ColumnHeader();
            GoodsPrice = new ColumnHeader();
            GoodsImage = new ColumnHeader();
            imageList = new ImageList(components);
            groupBox1 = new GroupBox();
            Pricetxb = new TextBox();
            DeleteButton = new Button();
            ChangeButton = new Button();
            Imagetbx = new TextBox();
            Nametxb = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            AddButton = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ProductListView
            // 
            ProductListView.Columns.AddRange(new ColumnHeader[] { GoodsName, Id, GoodsPrice, GoodsImage });
            ProductListView.Location = new Point(12, 12);
            ProductListView.Name = "ProductListView";
            ProductListView.Size = new Size(446, 426);
            ProductListView.TabIndex = 0;
            ProductListView.UseCompatibleStateImageBehavior = false;
            ProductListView.SelectedIndexChanged += ProductListView_SelectedIndexChanged;
            // 
            // GoodsName
            // 
            GoodsName.Text = "GoodsName";
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // GoodsPrice
            // 
            GoodsPrice.Text = "GoodsPrice";
            // 
            // GoodsImage
            // 
            GoodsImage.Text = "GoodsImage";
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageSize = new Size(64, 64);
            imageList.TransparentColor = Color.Transparent;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Pricetxb);
            groupBox1.Controls.Add(DeleteButton);
            groupBox1.Controls.Add(ChangeButton);
            groupBox1.Controls.Add(Imagetbx);
            groupBox1.Controls.Add(Nametxb);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(464, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 244);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Изменение";
            // 
            // Pricetxb
            // 
            Pricetxb.Location = new Point(76, 59);
            Pricetxb.Name = "Pricetxb";
            Pricetxb.Size = new Size(150, 23);
            Pricetxb.TabIndex = 8;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(15, 146);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(211, 23);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(15, 117);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(211, 23);
            ChangeButton.TabIndex = 7;
            ChangeButton.Text = "Изменить";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // Imagetbx
            // 
            Imagetbx.Location = new Point(76, 88);
            Imagetbx.Name = "Imagetbx";
            Imagetbx.Size = new Size(150, 23);
            Imagetbx.TabIndex = 5;
            // 
            // Nametxb
            // 
            Nametxb.Location = new Point(76, 30);
            Nametxb.Name = "Nametxb";
            Nametxb.Size = new Size(150, 23);
            Nametxb.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 96);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Картинка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 67);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Цена";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(464, 262);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(183, 23);
            AddButton.TabIndex = 2;
            AddButton.Text = "Добавить новый экземпляр";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "https://www.wallister.de/cdn/shop/products/K842010_01.jpg?v=1687439248";
            pictureBox1.Location = new Point(653, 262);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // AdminWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(AddButton);
            Controls.Add(groupBox1);
            Controls.Add(ProductListView);
            Name = "AdminWindow";
            Text = "AdminWindow";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView ProductListView;
        private ColumnHeader GoodsName;
        private ColumnHeader Id;
        private ColumnHeader GoodsPrice;
        private ColumnHeader GoodsImage;
        private ImageList imageList;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button DeleteButton;
        private Button ChangeButton;
        private TextBox Imagetbx;
        private TextBox Nametxb;
        private Button AddButton;
        private PictureBox pictureBox1;
        private TextBox Pricetxb;
    }
}