namespace Lab7_v2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstDrinks = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.grpCoffeeOptions = new System.Windows.Forms.GroupBox();
            this.radCream = new System.Windows.Forms.CheckBox();
            this.radSugar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstBlend = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstReady = new System.Windows.Forms.ListBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpCoffeeOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Drink";
            // 
            // lstDrinks
            // 
            this.lstDrinks.FormattingEnabled = true;
            this.lstDrinks.ItemHeight = 20;
            this.lstDrinks.Items.AddRange(new object[] {
            "Coffee"});
            this.lstDrinks.Location = new System.Drawing.Point(12, 31);
            this.lstDrinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDrinks.Name = "lstDrinks";
            this.lstDrinks.Size = new System.Drawing.Size(178, 44);
            this.lstDrinks.TabIndex = 0;
            this.lstDrinks.SelectedIndexChanged += new System.EventHandler(this.LstDrinks_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Display";
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 20;
            this.lstDisplay.Location = new System.Drawing.Point(12, 198);
            this.lstDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(752, 104);
            this.lstDisplay.TabIndex = 0;
            // 
            // btnPrepare
            // 
            this.btnPrepare.Location = new System.Drawing.Point(16, 439);
            this.btnPrepare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrepare.Name = "btnPrepare";
            this.btnPrepare.Size = new System.Drawing.Size(158, 35);
            this.btnPrepare.TabIndex = 3;
            this.btnPrepare.Text = "Prepare";
            this.btnPrepare.UseVisualStyleBackColor = true;
            this.btnPrepare.Click += new System.EventHandler(this.BtnPrepare_Click);
            // 
            // grpCoffeeOptions
            // 
            this.grpCoffeeOptions.Controls.Add(this.radCream);
            this.grpCoffeeOptions.Controls.Add(this.radSugar);
            this.grpCoffeeOptions.Location = new System.Drawing.Point(224, 31);
            this.grpCoffeeOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCoffeeOptions.Name = "grpCoffeeOptions";
            this.grpCoffeeOptions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCoffeeOptions.Size = new System.Drawing.Size(133, 128);
            this.grpCoffeeOptions.TabIndex = 2;
            this.grpCoffeeOptions.TabStop = false;
            this.grpCoffeeOptions.Text = "Options";
            this.grpCoffeeOptions.Visible = false;
            // 
            // radCream
            // 
            this.radCream.AutoSize = true;
            this.radCream.Location = new System.Drawing.Point(9, 78);
            this.radCream.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radCream.Name = "radCream";
            this.radCream.Size = new System.Drawing.Size(75, 24);
            this.radCream.TabIndex = 1;
            this.radCream.Text = "Cream";
            this.radCream.UseVisualStyleBackColor = true;
            // 
            // radSugar
            // 
            this.radSugar.AutoSize = true;
            this.radSugar.Location = new System.Drawing.Point(9, 42);
            this.radSugar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radSugar.Name = "radSugar";
            this.radSugar.Size = new System.Drawing.Size(71, 24);
            this.radSugar.TabIndex = 0;
            this.radSugar.Text = "Sugar";
            this.radSugar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Blend";
            // 
            // lstBlend
            // 
            this.lstBlend.FormattingEnabled = true;
            this.lstBlend.ItemHeight = 20;
            this.lstBlend.Items.AddRange(new object[] {
            "Regular",
            "Dark"});
            this.lstBlend.Location = new System.Drawing.Point(12, 109);
            this.lstBlend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstBlend.Name = "lstBlend";
            this.lstBlend.Size = new System.Drawing.Size(178, 64);
            this.lstBlend.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Drinks ready to go";
            // 
            // lstReady
            // 
            this.lstReady.FormattingEnabled = true;
            this.lstReady.ItemHeight = 20;
            this.lstReady.Location = new System.Drawing.Point(12, 329);
            this.lstReady.Name = "lstReady";
            this.lstReady.Size = new System.Drawing.Size(752, 104);
            this.lstReady.TabIndex = 6;
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(313, 439);
            this.btnTake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(158, 35);
            this.btnTake.TabIndex = 4;
            this.btnTake.Text = "Take your drink";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.BtnTake_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(610, 439);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab7_v2.Properties.Resources.hotDrinks;
            this.pictureBox1.Location = new System.Drawing.Point(420, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.lstReady);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstBlend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpCoffeeOptions);
            this.Controls.Add(this.btnPrepare);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDrinks);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hot Drink Machine by Fernando Pereira and Steve Kennedy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCoffeeOptions.ResumeLayout(false);
            this.grpCoffeeOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDrinks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnPrepare;
        private System.Windows.Forms.GroupBox grpCoffeeOptions;
        private System.Windows.Forms.CheckBox radCream;
        private System.Windows.Forms.CheckBox radSugar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstBlend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstReady;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

