namespace Lost_n_Found.Views.Home
{
    partial class AddItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.panelAddItem = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.addItemCard = new Bunifu.Framework.UI.BunifuCards();
            this.txtItemNote = new Guna.UI.WinForms.GunaTextBox();
            this.dateItemDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtItemLocation = new Guna.UI.WinForms.GunaTextBox();
            this.txtItemName = new Guna.UI.WinForms.GunaTextBox();
            this.btnReset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddItem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmbItemsCategory = new Guna.UI.WinForms.GunaComboBox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnImage = new Guna.UI.WinForms.GunaImageButton();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.grpItemStatus = new System.Windows.Forms.GroupBox();
            this.rbUnclaimed = new System.Windows.Forms.RadioButton();
            this.rbClaimed = new System.Windows.Forms.RadioButton();
            this.txtItemDescription = new Guna.UI.WinForms.GunaTextBox();
            this.grpItemType = new System.Windows.Forms.GroupBox();
            this.rbFound = new System.Windows.Forms.RadioButton();
            this.rbLost = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.openFileImage = new System.Windows.Forms.OpenFileDialog();
            this.panelAddItem.SuspendLayout();
            this.addItemCard.SuspendLayout();
            this.grpItemStatus.SuspendLayout();
            this.grpItemType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddItem
            // 
            this.panelAddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAddItem.BackgroundImage")));
            this.panelAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAddItem.Controls.Add(this.addItemCard);
            this.panelAddItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddItem.GradientBottomLeft = System.Drawing.Color.PaleTurquoise;
            this.panelAddItem.GradientBottomRight = System.Drawing.Color.Silver;
            this.panelAddItem.GradientTopLeft = System.Drawing.Color.DeepSkyBlue;
            this.panelAddItem.GradientTopRight = System.Drawing.Color.MediumTurquoise;
            this.panelAddItem.Location = new System.Drawing.Point(0, 0);
            this.panelAddItem.Name = "panelAddItem";
            this.panelAddItem.Quality = 10;
            this.panelAddItem.Size = new System.Drawing.Size(1264, 681);
            this.panelAddItem.TabIndex = 0;
            // 
            // addItemCard
            // 
            this.addItemCard.BackColor = System.Drawing.Color.White;
            this.addItemCard.BorderRadius = 20;
            this.addItemCard.BottomSahddow = true;
            this.addItemCard.color = System.Drawing.Color.White;
            this.addItemCard.Controls.Add(this.txtItemNote);
            this.addItemCard.Controls.Add(this.dateItemDate);
            this.addItemCard.Controls.Add(this.txtItemLocation);
            this.addItemCard.Controls.Add(this.txtItemName);
            this.addItemCard.Controls.Add(this.btnReset);
            this.addItemCard.Controls.Add(this.btnAddItem);
            this.addItemCard.Controls.Add(this.cmbItemsCategory);
            this.addItemCard.Controls.Add(this.bunifuCustomLabel14);
            this.addItemCard.Controls.Add(this.btnImage);
            this.addItemCard.Controls.Add(this.bunifuCustomLabel12);
            this.addItemCard.Controls.Add(this.bunifuCustomLabel13);
            this.addItemCard.Controls.Add(this.bunifuCustomLabel10);
            this.addItemCard.Controls.Add(this.bunifuCustomLabel11);
            this.addItemCard.Controls.Add(this.bunifuCustomLabel7);
            this.addItemCard.Controls.Add(this.bunifuCustomLabel8);
            this.addItemCard.Controls.Add(this.bunifuCustomLabel5);
            this.addItemCard.Controls.Add(this.bunifuCustomLabel6);
            this.addItemCard.Controls.Add(this.bunifuCustomLabel3);
            this.addItemCard.Controls.Add(this.bunifuCustomLabel4);
            this.addItemCard.Controls.Add(this.grpItemStatus);
            this.addItemCard.Controls.Add(this.txtItemDescription);
            this.addItemCard.Controls.Add(this.grpItemType);
            this.addItemCard.Controls.Add(this.bunifuCustomLabel9);
            this.addItemCard.Controls.Add(this.bunifuCustomLabel1);
            this.addItemCard.Controls.Add(this.bunifuCustomLabel2);
            this.addItemCard.LeftSahddow = false;
            this.addItemCard.Location = new System.Drawing.Point(309, 34);
            this.addItemCard.Name = "addItemCard";
            this.addItemCard.RightSahddow = true;
            this.addItemCard.ShadowDepth = 20;
            this.addItemCard.Size = new System.Drawing.Size(659, 596);
            this.addItemCard.TabIndex = 1;
            // 
            // txtItemNote
            // 
            this.txtItemNote.BackColor = System.Drawing.Color.White;
            this.txtItemNote.BaseColor = System.Drawing.Color.White;
            this.txtItemNote.BorderColor = System.Drawing.Color.Black;
            this.txtItemNote.BorderSize = 1;
            this.txtItemNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemNote.FocusedBaseColor = System.Drawing.Color.White;
            this.txtItemNote.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtItemNote.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtItemNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtItemNote.Location = new System.Drawing.Point(258, 408);
            this.txtItemNote.MultiLine = true;
            this.txtItemNote.Name = "txtItemNote";
            this.txtItemNote.PasswordChar = '\0';
            this.txtItemNote.Radius = 5;
            this.txtItemNote.Size = new System.Drawing.Size(363, 57);
            this.txtItemNote.TabIndex = 36;
            // 
            // dateItemDate
            // 
            this.dateItemDate.BackColor = System.Drawing.Color.White;
            this.dateItemDate.BorderRadius = 10;
            this.dateItemDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateItemDate.ForeColor = System.Drawing.Color.Black;
            this.dateItemDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateItemDate.FormatCustom = null;
            this.dateItemDate.Location = new System.Drawing.Point(257, 275);
            this.dateItemDate.Name = "dateItemDate";
            this.dateItemDate.Size = new System.Drawing.Size(364, 26);
            this.dateItemDate.TabIndex = 35;
            this.dateItemDate.Value = new System.DateTime(2024, 12, 20, 10, 1, 42, 597);
            // 
            // txtItemLocation
            // 
            this.txtItemLocation.BackColor = System.Drawing.Color.White;
            this.txtItemLocation.BaseColor = System.Drawing.Color.White;
            this.txtItemLocation.BorderColor = System.Drawing.Color.Black;
            this.txtItemLocation.BorderSize = 1;
            this.txtItemLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemLocation.FocusedBaseColor = System.Drawing.Color.White;
            this.txtItemLocation.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtItemLocation.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtItemLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtItemLocation.Location = new System.Drawing.Point(257, 335);
            this.txtItemLocation.MultiLine = true;
            this.txtItemLocation.Name = "txtItemLocation";
            this.txtItemLocation.PasswordChar = '\0';
            this.txtItemLocation.Radius = 5;
            this.txtItemLocation.Size = new System.Drawing.Size(363, 57);
            this.txtItemLocation.TabIndex = 32;
            // 
            // txtItemName
            // 
            this.txtItemName.BaseColor = System.Drawing.Color.White;
            this.txtItemName.BorderColor = System.Drawing.Color.Black;
            this.txtItemName.BorderSize = 1;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtItemName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtItemName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtItemName.Location = new System.Drawing.Point(255, 117);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.Radius = 5;
            this.txtItemName.Size = new System.Drawing.Size(363, 26);
            this.txtItemName.TabIndex = 28;
            // 
            // btnReset
            // 
            this.btnReset.ActiveBorderThickness = 1;
            this.btnReset.ActiveCornerRadius = 20;
            this.btnReset.ActiveFillColor = System.Drawing.Color.Red;
            this.btnReset.ActiveForecolor = System.Drawing.Color.White;
            this.btnReset.ActiveLineColor = System.Drawing.Color.Red;
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.ButtonText = "Reset";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.IdleBorderThickness = 1;
            this.btnReset.IdleCornerRadius = 20;
            this.btnReset.IdleFillColor = System.Drawing.Color.White;
            this.btnReset.IdleForecolor = System.Drawing.Color.Red;
            this.btnReset.IdleLineColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(419, 534);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 42);
            this.btnReset.TabIndex = 27;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddItem
            // 
            this.btnAddItem.ActiveBorderThickness = 1;
            this.btnAddItem.ActiveCornerRadius = 20;
            this.btnAddItem.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddItem.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddItem.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackColor = System.Drawing.Color.White;
            this.btnAddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddItem.BackgroundImage")));
            this.btnAddItem.ButtonText = "Register";
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.Black;
            this.btnAddItem.IdleBorderThickness = 1;
            this.btnAddItem.IdleCornerRadius = 20;
            this.btnAddItem.IdleFillColor = System.Drawing.Color.White;
            this.btnAddItem.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddItem.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddItem.Location = new System.Drawing.Point(515, 534);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(108, 42);
            this.btnAddItem.TabIndex = 23;
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cmbItemsCategory
            // 
            this.cmbItemsCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbItemsCategory.BaseColor = System.Drawing.Color.White;
            this.cmbItemsCategory.BorderColor = System.Drawing.Color.Black;
            this.cmbItemsCategory.BorderSize = 1;
            this.cmbItemsCategory.DisplayMember = "Name";
            this.cmbItemsCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItemsCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemsCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbItemsCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbItemsCategory.FormattingEnabled = true;
            this.cmbItemsCategory.Location = new System.Drawing.Point(257, 160);
            this.cmbItemsCategory.Name = "cmbItemsCategory";
            this.cmbItemsCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbItemsCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbItemsCategory.Radius = 5;
            this.cmbItemsCategory.Size = new System.Drawing.Size(363, 26);
            this.cmbItemsCategory.TabIndex = 49;
            this.cmbItemsCategory.ValueMember = "Id";
            this.cmbItemsCategory.SelectedIndexChanged += new System.EventHandler(this.cmbItemsCategory_SelectedIndexChanged);
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(43, 23);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(65, 13);
            this.bunifuCustomLabel14.TabIndex = 48;
            this.bunifuCustomLabel14.Text = "Item Image";
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnImage.Image = null;
            this.btnImage.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImage.Location = new System.Drawing.Point(46, 39);
            this.btnImage.Name = "btnImage";
            this.btnImage.OnHoverImage = null;
            this.btnImage.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnImage.Size = new System.Drawing.Size(70, 73);
            this.btnImage.TabIndex = 47;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(231, 408);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(18, 28);
            this.bunifuCustomLabel12.TabIndex = 46;
            this.bunifuCustomLabel12.Text = ":";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(39, 408);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(59, 28);
            this.bunifuCustomLabel13.TabIndex = 45;
            this.bunifuCustomLabel13.Text = "Note";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(233, 203);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(18, 28);
            this.bunifuCustomLabel10.TabIndex = 44;
            this.bunifuCustomLabel10.Text = ":";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(41, 203);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(170, 28);
            this.bunifuCustomLabel11.TabIndex = 43;
            this.bunifuCustomLabel11.Text = "Item Description";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(233, 273);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(18, 28);
            this.bunifuCustomLabel7.TabIndex = 42;
            this.bunifuCustomLabel7.Text = ":";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(41, 273);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(57, 28);
            this.bunifuCustomLabel8.TabIndex = 41;
            this.bunifuCustomLabel8.Text = "Date";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(233, 325);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(18, 28);
            this.bunifuCustomLabel5.TabIndex = 40;
            this.bunifuCustomLabel5.Text = ":";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(41, 325);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(93, 28);
            this.bunifuCustomLabel6.TabIndex = 39;
            this.bunifuCustomLabel6.Text = "Location";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(233, 158);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(18, 28);
            this.bunifuCustomLabel3.TabIndex = 38;
            this.bunifuCustomLabel3.Text = ":";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(41, 158);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(147, 28);
            this.bunifuCustomLabel4.TabIndex = 37;
            this.bunifuCustomLabel4.Text = "Item Category";
            // 
            // grpItemStatus
            // 
            this.grpItemStatus.Controls.Add(this.rbUnclaimed);
            this.grpItemStatus.Controls.Add(this.rbClaimed);
            this.grpItemStatus.Location = new System.Drawing.Point(440, 479);
            this.grpItemStatus.Name = "grpItemStatus";
            this.grpItemStatus.Size = new System.Drawing.Size(180, 48);
            this.grpItemStatus.TabIndex = 23;
            this.grpItemStatus.TabStop = false;
            this.grpItemStatus.Text = "Item Status";
            // 
            // rbUnclaimed
            // 
            this.rbUnclaimed.AutoSize = true;
            this.rbUnclaimed.Location = new System.Drawing.Point(102, 19);
            this.rbUnclaimed.Name = "rbUnclaimed";
            this.rbUnclaimed.Size = new System.Drawing.Size(75, 17);
            this.rbUnclaimed.TabIndex = 1;
            this.rbUnclaimed.TabStop = true;
            this.rbUnclaimed.Text = "Unclaimed";
            this.rbUnclaimed.UseVisualStyleBackColor = true;
            // 
            // rbClaimed
            // 
            this.rbClaimed.AutoSize = true;
            this.rbClaimed.Location = new System.Drawing.Point(16, 19);
            this.rbClaimed.Name = "rbClaimed";
            this.rbClaimed.Size = new System.Drawing.Size(62, 17);
            this.rbClaimed.TabIndex = 0;
            this.rbClaimed.TabStop = true;
            this.rbClaimed.Text = "Claimed";
            this.rbClaimed.UseVisualStyleBackColor = true;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.BaseColor = System.Drawing.Color.White;
            this.txtItemDescription.BorderColor = System.Drawing.Color.Black;
            this.txtItemDescription.BorderSize = 1;
            this.txtItemDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemDescription.FocusedBaseColor = System.Drawing.Color.White;
            this.txtItemDescription.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtItemDescription.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtItemDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtItemDescription.Location = new System.Drawing.Point(257, 203);
            this.txtItemDescription.MultiLine = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.PasswordChar = '\0';
            this.txtItemDescription.Radius = 5;
            this.txtItemDescription.Size = new System.Drawing.Size(364, 57);
            this.txtItemDescription.TabIndex = 29;
            // 
            // grpItemType
            // 
            this.grpItemType.Controls.Add(this.rbFound);
            this.grpItemType.Controls.Add(this.rbLost);
            this.grpItemType.Location = new System.Drawing.Point(257, 479);
            this.grpItemType.Name = "grpItemType";
            this.grpItemType.Size = new System.Drawing.Size(154, 48);
            this.grpItemType.TabIndex = 22;
            this.grpItemType.TabStop = false;
            this.grpItemType.Text = "Item Type";
            // 
            // rbFound
            // 
            this.rbFound.AutoSize = true;
            this.rbFound.Location = new System.Drawing.Point(87, 19);
            this.rbFound.Name = "rbFound";
            this.rbFound.Size = new System.Drawing.Size(55, 17);
            this.rbFound.TabIndex = 1;
            this.rbFound.TabStop = true;
            this.rbFound.Text = "Found";
            this.rbFound.UseVisualStyleBackColor = true;
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Location = new System.Drawing.Point(16, 19);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(45, 17);
            this.rbLost.TabIndex = 0;
            this.rbLost.TabStop = true;
            this.rbLost.Text = "Lost";
            this.rbLost.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(231, 115);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(18, 28);
            this.bunifuCustomLabel9.TabIndex = 15;
            this.bunifuCustomLabel9.Text = ":";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(255, 2);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(156, 41);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Add Item";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(39, 115);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(117, 28);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Item Name";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAddItem);
            this.MaximumSize = new System.Drawing.Size(1264, 681);
            this.MinimumSize = new System.Drawing.Size(1264, 681);
            this.Name = "AddItem";
            this.Size = new System.Drawing.Size(1264, 681);
            this.panelAddItem.ResumeLayout(false);
            this.addItemCard.ResumeLayout(false);
            this.addItemCard.PerformLayout();
            this.grpItemStatus.ResumeLayout(false);
            this.grpItemStatus.PerformLayout();
            this.grpItemType.ResumeLayout(false);
            this.grpItemType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panelAddItem;
        private Bunifu.Framework.UI.BunifuCards addItemCard;
        private Guna.UI.WinForms.GunaTextBox txtItemLocation;
        private Guna.UI.WinForms.GunaTextBox txtItemDescription;
        private Guna.UI.WinForms.GunaTextBox txtItemName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReset;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddItem;
        private System.Windows.Forms.GroupBox grpItemType;
        private System.Windows.Forms.RadioButton rbFound;
        private System.Windows.Forms.RadioButton rbLost;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker dateItemDate;
        private Guna.UI.WinForms.GunaTextBox txtItemNote;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.GroupBox grpItemStatus;
        private System.Windows.Forms.RadioButton rbUnclaimed;
        private System.Windows.Forms.RadioButton rbClaimed;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Guna.UI.WinForms.GunaImageButton btnImage;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Guna.UI.WinForms.GunaComboBox cmbItemsCategory;
        private System.Windows.Forms.OpenFileDialog openFileImage;
    }
}
