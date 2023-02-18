namespace Assignment_4_csharp
{
    partial class Form1
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
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.btnDeleteProducts = new System.Windows.Forms.Button();
            this.btnUpdateProducts = new System.Windows.Forms.Button();
            this.btnAddNewProducts = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductsPrice = new System.Windows.Forms.TextBox();
            this.rtbProductsDescription = new System.Windows.Forms.RichTextBox();
            this.txtProductsName = new System.Windows.Forms.TextBox();
            this.groupBoxProcedures = new System.Windows.Forms.GroupBox();
            this.btnSaveNewProcedures = new System.Windows.Forms.Button();
            this.btnDeleteProcedures = new System.Windows.Forms.Button();
            this.btnUpdateProcedures = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtProcedurePrice = new System.Windows.Forms.TextBox();
            this.rtbProcedureDescription = new System.Windows.Forms.RichTextBox();
            this.txtProcedureName = new System.Windows.Forms.TextBox();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxProducts.SuspendLayout();
            this.groupBoxProcedures.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 25;
            this.listBoxItems.Location = new System.Drawing.Point(26, 126);
            this.listBoxItems.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(297, 704);
            this.listBoxItems.TabIndex = 0;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entire Inventory";
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.btnDeleteProducts);
            this.groupBoxProducts.Controls.Add(this.btnUpdateProducts);
            this.groupBoxProducts.Controls.Add(this.btnAddNewProducts);
            this.groupBoxProducts.Controls.Add(this.label4);
            this.groupBoxProducts.Controls.Add(this.label3);
            this.groupBoxProducts.Controls.Add(this.label2);
            this.groupBoxProducts.Controls.Add(this.txtProductsPrice);
            this.groupBoxProducts.Controls.Add(this.rtbProductsDescription);
            this.groupBoxProducts.Controls.Add(this.txtProductsName);
            this.groupBoxProducts.Font = new System.Drawing.Font("Elephant", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxProducts.Location = new System.Drawing.Point(357, 92);
            this.groupBoxProducts.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxProducts.Size = new System.Drawing.Size(972, 340);
            this.groupBoxProducts.TabIndex = 2;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "Products";
            // 
            // btnDeleteProducts
            // 
            this.btnDeleteProducts.Location = new System.Drawing.Point(723, 267);
            this.btnDeleteProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProducts.Name = "btnDeleteProducts";
            this.btnDeleteProducts.Size = new System.Drawing.Size(153, 48);
            this.btnDeleteProducts.TabIndex = 8;
            this.btnDeleteProducts.Text = "Delete";
            this.btnDeleteProducts.UseVisualStyleBackColor = true;
            this.btnDeleteProducts.Click += new System.EventHandler(this.btnDeleteProducts_Click);
            // 
            // btnUpdateProducts
            // 
            this.btnUpdateProducts.Location = new System.Drawing.Point(455, 267);
            this.btnUpdateProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateProducts.Name = "btnUpdateProducts";
            this.btnUpdateProducts.Size = new System.Drawing.Size(169, 48);
            this.btnUpdateProducts.TabIndex = 7;
            this.btnUpdateProducts.Text = "Update";
            this.btnUpdateProducts.UseVisualStyleBackColor = true;
            this.btnUpdateProducts.Click += new System.EventHandler(this.btnUpdateProducts_Click);
            // 
            // btnAddNewProducts
            // 
            this.btnAddNewProducts.Location = new System.Drawing.Point(199, 267);
            this.btnAddNewProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewProducts.Name = "btnAddNewProducts";
            this.btnAddNewProducts.Size = new System.Drawing.Size(175, 48);
            this.btnAddNewProducts.TabIndex = 6;
            this.btnAddNewProducts.Text = "Add New";
            this.btnAddNewProducts.UseVisualStyleBackColor = true;
            this.btnAddNewProducts.Click += new System.EventHandler(this.btnAddNewProducts_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // txtProductsPrice
            // 
            this.txtProductsPrice.Location = new System.Drawing.Point(235, 203);
            this.txtProductsPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductsPrice.Name = "txtProductsPrice";
            this.txtProductsPrice.Size = new System.Drawing.Size(640, 36);
            this.txtProductsPrice.TabIndex = 2;
            // 
            // rtbProductsDescription
            // 
            this.rtbProductsDescription.Location = new System.Drawing.Point(235, 73);
            this.rtbProductsDescription.Margin = new System.Windows.Forms.Padding(4);
            this.rtbProductsDescription.Name = "rtbProductsDescription";
            this.rtbProductsDescription.Size = new System.Drawing.Size(640, 108);
            this.rtbProductsDescription.TabIndex = 1;
            this.rtbProductsDescription.Text = "";
            // 
            // txtProductsName
            // 
            this.txtProductsName.Location = new System.Drawing.Point(236, 29);
            this.txtProductsName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductsName.Name = "txtProductsName";
            this.txtProductsName.Size = new System.Drawing.Size(640, 36);
            this.txtProductsName.TabIndex = 0;
            // 
            // groupBoxProcedures
            // 
            this.groupBoxProcedures.Controls.Add(this.btnSaveNewProcedures);
            this.groupBoxProcedures.Controls.Add(this.btnDeleteProcedures);
            this.groupBoxProcedures.Controls.Add(this.btnUpdateProcedures);
            this.groupBoxProcedures.Controls.Add(this.label8);
            this.groupBoxProcedures.Controls.Add(this.label7);
            this.groupBoxProcedures.Controls.Add(this.label6);
            this.groupBoxProcedures.Controls.Add(this.label5);
            this.groupBoxProcedures.Controls.Add(this.txtMinutes);
            this.groupBoxProcedures.Controls.Add(this.txtProcedurePrice);
            this.groupBoxProcedures.Controls.Add(this.rtbProcedureDescription);
            this.groupBoxProcedures.Controls.Add(this.txtProcedureName);
            this.groupBoxProcedures.Font = new System.Drawing.Font("Elephant", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxProcedures.Location = new System.Drawing.Point(350, 440);
            this.groupBoxProcedures.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxProcedures.Name = "groupBoxProcedures";
            this.groupBoxProcedures.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxProcedures.Size = new System.Drawing.Size(979, 390);
            this.groupBoxProcedures.TabIndex = 3;
            this.groupBoxProcedures.TabStop = false;
            this.groupBoxProcedures.Text = "Procedures";
            // 
            // btnSaveNewProcedures
            // 
            this.btnSaveNewProcedures.Location = new System.Drawing.Point(206, 327);
            this.btnSaveNewProcedures.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveNewProcedures.Name = "btnSaveNewProcedures";
            this.btnSaveNewProcedures.Size = new System.Drawing.Size(175, 55);
            this.btnSaveNewProcedures.TabIndex = 9;
            this.btnSaveNewProcedures.Text = "Save New";
            this.btnSaveNewProcedures.UseVisualStyleBackColor = true;
            this.btnSaveNewProcedures.Click += new System.EventHandler(this.btnSaveNewProcedures_Click);
            // 
            // btnDeleteProcedures
            // 
            this.btnDeleteProcedures.Location = new System.Drawing.Point(694, 327);
            this.btnDeleteProcedures.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProcedures.Name = "btnDeleteProcedures";
            this.btnDeleteProcedures.Size = new System.Drawing.Size(175, 55);
            this.btnDeleteProcedures.TabIndex = 9;
            this.btnDeleteProcedures.Text = "Delete";
            this.btnDeleteProcedures.UseVisualStyleBackColor = true;
            this.btnDeleteProcedures.Click += new System.EventHandler(this.btnDeleteProcedures_Click);
            // 
            // btnUpdateProcedures
            // 
            this.btnUpdateProcedures.Location = new System.Drawing.Point(462, 327);
            this.btnUpdateProcedures.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateProcedures.Name = "btnUpdateProcedures";
            this.btnUpdateProcedures.Size = new System.Drawing.Size(169, 55);
            this.btnUpdateProcedures.TabIndex = 9;
            this.btnUpdateProcedures.Text = "Update";
            this.btnUpdateProcedures.UseVisualStyleBackColor = true;
            this.btnUpdateProcedures.Click += new System.EventHandler(this.btnUpdateProcedures_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Minutes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name:";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(229, 268);
            this.txtMinutes.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(640, 36);
            this.txtMinutes.TabIndex = 11;
            // 
            // txtProcedurePrice
            // 
            this.txtProcedurePrice.Location = new System.Drawing.Point(228, 207);
            this.txtProcedurePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtProcedurePrice.Name = "txtProcedurePrice";
            this.txtProcedurePrice.Size = new System.Drawing.Size(640, 36);
            this.txtProcedurePrice.TabIndex = 10;
            // 
            // rtbProcedureDescription
            // 
            this.rtbProcedureDescription.Location = new System.Drawing.Point(228, 76);
            this.rtbProcedureDescription.Margin = new System.Windows.Forms.Padding(4);
            this.rtbProcedureDescription.Name = "rtbProcedureDescription";
            this.rtbProcedureDescription.Size = new System.Drawing.Size(640, 108);
            this.rtbProcedureDescription.TabIndex = 9;
            this.rtbProcedureDescription.Text = "";
            // 
            // txtProcedureName
            // 
            this.txtProcedureName.Location = new System.Drawing.Point(228, 20);
            this.txtProcedureName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProcedureName.Name = "txtProcedureName";
            this.txtProcedureName.Size = new System.Drawing.Size(640, 36);
            this.txtProcedureName.TabIndex = 9;
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Location = new System.Drawing.Point(26, 902);
            this.WarningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(0, 25);
            this.WarningLabel.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(264, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(742, 43);
            this.label9.TabIndex = 5;
            this.label9.Text = "Beauty Shop Inventory Maintenance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 957);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.groupBoxProcedures);
            this.Controls.Add(this.groupBoxProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxItems);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxProducts.ResumeLayout(false);
            this.groupBoxProducts.PerformLayout();
            this.groupBoxProcedures.ResumeLayout(false);
            this.groupBoxProcedures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxItems;
        private Label label1;
        private GroupBox groupBoxProducts;
        private Button btnDeleteProducts;
        private Button btnUpdateProducts;
        private Button btnAddNewProducts;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtProductsPrice;
        private RichTextBox rtbProductsDescription;
        private TextBox txtProductsName;
        private GroupBox groupBoxProcedures;
        private Button btnSaveNewProcedures;
        private Button btnDeleteProcedures;
        private Button btnUpdateProcedures;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtMinutes;
        private TextBox txtProcedurePrice;
        private RichTextBox rtbProcedureDescription;
        private TextBox txtProcedureName;
        private Label WarningLabel;
        private Label label9;
    }
}