namespace NerdDataSet
{
	partial class NerdDataSet
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NerdDataSet));
			this.pnlMain = new System.Windows.Forms.Panel();
			this.cbxDataTables = new System.Windows.Forms.ComboBox();
			this.dgvInformation = new System.Windows.Forms.DataGridView();
			this.pnlMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pnlMain.BackgroundImage = global::NerdDataSet.Properties.Resources.Nerd_Data_Set_Background;
			this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlMain.Controls.Add(this.cbxDataTables);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlMain.Location = new System.Drawing.Point(0, 0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(852, 68);
			this.pnlMain.TabIndex = 2;
			// 
			// cbxDataTables
			// 
			this.cbxDataTables.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.cbxDataTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDataTables.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxDataTables.FormattingEnabled = true;
			this.cbxDataTables.Location = new System.Drawing.Point(0, 43);
			this.cbxDataTables.Name = "cbxDataTables";
			this.cbxDataTables.Size = new System.Drawing.Size(852, 25);
			this.cbxDataTables.TabIndex = 2;
			this.cbxDataTables.SelectedIndexChanged += new System.EventHandler(this.cbxDataTables_SelectedIndexChanged);
			// 
			// dgvInformation
			// 
			this.dgvInformation.BackgroundColor = System.Drawing.Color.Black;
			this.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInformation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvInformation.GridColor = System.Drawing.SystemColors.ControlText;
			this.dgvInformation.Location = new System.Drawing.Point(0, 68);
			this.dgvInformation.Name = "dgvInformation";
			this.dgvInformation.Size = new System.Drawing.Size(852, 501);
			this.dgvInformation.TabIndex = 1;
			this.dgvInformation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInformation_CellDoubleClick);
			// 
			// NerdDataSet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 569);
			this.Controls.Add(this.dgvInformation);
			this.Controls.Add(this.pnlMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NerdDataSet";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nerd DataSet";
			this.Load += new System.EventHandler(this.NerdDataSet_Load);
			this.pnlMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.ComboBox cbxDataTables;
		private System.Windows.Forms.DataGridView dgvInformation;
	}
}

