namespace ZenMoney.Elements
{
    partial class ExpencesForm
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
            this.dateTimeBox = new System.Windows.Forms.DateTimePicker();
            this.dateTimeName = new System.Windows.Forms.TextBox();
            this.fromName = new System.Windows.Forms.TextBox();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.amountName = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.typeName = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimeBox
            // 
            this.dateTimeBox.Location = new System.Drawing.Point(111, 12);
            this.dateTimeBox.Name = "dateTimeBox";
            this.dateTimeBox.Size = new System.Drawing.Size(193, 20);
            this.dateTimeBox.TabIndex = 1;
            this.dateTimeBox.ValueChanged += new System.EventHandler(this.DateTimeBox_ValueChanged);
            // 
            // dateTimeName
            // 
            this.dateTimeName.Location = new System.Drawing.Point(12, 12);
            this.dateTimeName.Name = "dateTimeName";
            this.dateTimeName.ReadOnly = true;
            this.dateTimeName.Size = new System.Drawing.Size(84, 20);
            this.dateTimeName.TabIndex = 2;
            this.dateTimeName.Text = "Choose date";
            // 
            // fromName
            // 
            this.fromName.Location = new System.Drawing.Point(12, 38);
            this.fromName.Name = "fromName";
            this.fromName.ReadOnly = true;
            this.fromName.Size = new System.Drawing.Size(84, 20);
            this.fromName.TabIndex = 6;
            this.fromName.Text = "On";
            // 
            // fromBox
            // 
            this.fromBox.Location = new System.Drawing.Point(111, 38);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(193, 20);
            this.fromBox.TabIndex = 5;
            this.fromBox.TextChanged += new System.EventHandler(this.FromBox_TextChanged);
            // 
            // amountName
            // 
            this.amountName.Location = new System.Drawing.Point(12, 64);
            this.amountName.Name = "amountName";
            this.amountName.ReadOnly = true;
            this.amountName.Size = new System.Drawing.Size(84, 20);
            this.amountName.TabIndex = 8;
            this.amountName.Text = "Amount";
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(111, 64);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(193, 20);
            this.amountBox.TabIndex = 7;
            this.amountBox.TextChanged += new System.EventHandler(this.AmountBox_TextChanged);
            // 
            // typeName
            // 
            this.typeName.Location = new System.Drawing.Point(12, 90);
            this.typeName.Name = "typeName";
            this.typeName.ReadOnly = true;
            this.typeName.Size = new System.Drawing.Size(84, 20);
            this.typeName.TabIndex = 11;
            this.typeName.Text = "Type";
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(111, 90);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(193, 20);
            this.typeBox.TabIndex = 12;
            this.typeBox.TextChanged += new System.EventHandler(this.TypeBox_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 116);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 23);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add Data";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExpencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 156);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.typeName);
            this.Controls.Add(this.amountName);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.fromName);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.dateTimeName);
            this.Controls.Add(this.dateTimeBox);
            this.Name = "ExpencesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Expences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeBox;
        private System.Windows.Forms.TextBox dateTimeName;
        private System.Windows.Forms.TextBox fromName;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.TextBox amountName;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.TextBox typeName;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Button addButton;
    }
}