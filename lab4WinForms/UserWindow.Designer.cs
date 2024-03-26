namespace lab4WinForms
{
    partial class UserWindow
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
            SuspendLayout();
            // 
            // ProductListView
            // 
            ProductListView.Columns.AddRange(new ColumnHeader[] { GoodsName, Id, GoodsPrice, GoodsImage });
            ProductListView.Location = new Point(12, 12);
            ProductListView.Name = "ProductListView";
            ProductListView.Size = new Size(505, 426);
            ProductListView.TabIndex = 0;
            ProductListView.UseCompatibleStateImageBehavior = false;
            ProductListView.SelectedIndexChanged += ProductListView_SelectedIndexChanged;
            // 
            // GoodsName
            // 
            GoodsName.Text = "GoodsName";
            GoodsName.Width = 120;
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
            GoodsImage.Width = 256;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageSize = new Size(64, 64);
            imageList.TransparentColor = Color.Transparent;
            // 
            // UserWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 450);
            Controls.Add(ProductListView);
            Name = "UserWindow";
            Text = "UserWindow";
            ResumeLayout(false);
        }

        #endregion

        private ListView ProductListView;
        private ColumnHeader Id;
        private ColumnHeader GoodsName;
        private ColumnHeader GoodsPrice;
        private ImageList imageList;
        private ColumnHeader GoodsImage;
    }
}