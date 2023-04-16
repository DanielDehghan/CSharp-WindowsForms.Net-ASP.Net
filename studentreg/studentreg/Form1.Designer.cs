namespace studentreg
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtFee = new System.Windows.Forms.TextBox();
			this.txtCourse = new System.Windows.Forms.TextBox();
			this.txtStdName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(341, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(514, 59);
			this.label1.TabIndex = 0;
			this.label1.Text = "Student Registration";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtFee);
			this.groupBox1.Controls.Add(this.txtCourse);
			this.groupBox1.Controls.Add(this.txtStdName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(36, 130);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(695, 386);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Student Registration";
			// 
			// txtFee
			// 
			this.txtFee.Location = new System.Drawing.Point(291, 281);
			this.txtFee.Name = "txtFee";
			this.txtFee.Size = new System.Drawing.Size(337, 39);
			this.txtFee.TabIndex = 7;
			// 
			// txtCourse
			// 
			this.txtCourse.Location = new System.Drawing.Point(291, 193);
			this.txtCourse.Name = "txtCourse";
			this.txtCourse.Size = new System.Drawing.Size(337, 39);
			this.txtCourse.TabIndex = 6;
			// 
			// txtStdName
			// 
			this.txtStdName.Location = new System.Drawing.Point(291, 97);
			this.txtStdName.Name = "txtStdName";
			this.txtStdName.Size = new System.Drawing.Size(337, 39);
			this.txtStdName.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 286);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 32);
			this.label4.TabIndex = 4;
			this.label4.Text = "Fee";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 32);
			this.label3.TabIndex = 3;
			this.label3.Text = "Course";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(195, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "Student Name";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(36, 554);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(184, 86);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(244, 554);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(184, 86);
			this.btnClear.TabIndex = 9;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Edit,
            this.Delete});
			this.dataGridView1.Location = new System.Drawing.Point(818, 162);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 37;
			this.dataGridView1.Size = new System.Drawing.Size(966, 465);
			this.dataGridView1.TabIndex = 10;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "ID";
			this.Column1.MinimumWidth = 8;
			this.Column1.Name = "Column1";
			this.Column1.Width = 150;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Student Name";
			this.Column2.MinimumWidth = 8;
			this.Column2.Name = "Column2";
			this.Column2.Width = 150;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Course";
			this.Column3.MinimumWidth = 8;
			this.Column3.Name = "Column3";
			this.Column3.Width = 150;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Fee";
			this.Column4.MinimumWidth = 8;
			this.Column4.Name = "Column4";
			this.Column4.Width = 150;
			// 
			// Edit
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Edit.DefaultCellStyle = dataGridViewCellStyle3;
			this.Edit.HeaderText = "Edit";
			this.Edit.MinimumWidth = 8;
			this.Edit.Name = "Edit";
			this.Edit.Text = "Edit";
			this.Edit.UseColumnTextForButtonValue = true;
			this.Edit.Width = 150;
			// 
			// Delete
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete.DefaultCellStyle = dataGridViewCellStyle4;
			this.Delete.HeaderText = "Delete";
			this.Delete.MinimumWidth = 8;
			this.Delete.Name = "Delete";
			this.Delete.Text = "Delete";
			this.Delete.UseColumnTextForButtonValue = true;
			this.Delete.Width = 150;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(1249, 702);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(166, 73);
			this.btnRefresh.TabIndex = 11;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1843, 850);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtCourse;
		private System.Windows.Forms.TextBox txtStdName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFee;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewButtonColumn Edit;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
		private System.Windows.Forms.Button btnRefresh;
	}
}

