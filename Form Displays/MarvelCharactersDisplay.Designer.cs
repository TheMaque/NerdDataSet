namespace NerdDataSet
{
	partial class MarvelCharactersDisplay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarvelCharactersDisplay));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.picViewCharacter = new System.Windows.Forms.PictureBox();
			this.txtPageID = new System.Windows.Forms.TextBox();
			this.txtAlign = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.txtAlive = new System.Windows.Forms.TextBox();
			this.txtFirstAppearance = new System.Windows.Forms.TextBox();
			this.txtHair = new System.Windows.Forms.TextBox();
			this.txtEye = new System.Windows.Forms.TextBox();
			this.txtAppearances = new System.Windows.Forms.TextBox();
			this.lblpage_id = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblAppearances = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtSex = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picViewCharacter)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = global::NerdDataSet.Properties.Resources.Marvel_logo_red;
			this.pictureBox1.Location = new System.Drawing.Point(223, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(122, 43);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// picViewCharacter
			// 
			this.picViewCharacter.BackColor = System.Drawing.Color.Transparent;
			this.picViewCharacter.Image = global::NerdDataSet.Properties.Resources.blueButton2;
			this.picViewCharacter.Location = new System.Drawing.Point(227, 318);
			this.picViewCharacter.Name = "picViewCharacter";
			this.picViewCharacter.Size = new System.Drawing.Size(96, 50);
			this.picViewCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picViewCharacter.TabIndex = 1;
			this.picViewCharacter.TabStop = false;
			this.picViewCharacter.Click += new System.EventHandler(this.picViewCharacter_Click);
			// 
			// txtPageID
			// 
			this.txtPageID.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPageID.Location = new System.Drawing.Point(102, 86);
			this.txtPageID.Name = "txtPageID";
			this.txtPageID.ReadOnly = true;
			this.txtPageID.Size = new System.Drawing.Size(100, 22);
			this.txtPageID.TabIndex = 2;
			// 
			// txtAlign
			// 
			this.txtAlign.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlign.Location = new System.Drawing.Point(262, 167);
			this.txtAlign.Name = "txtAlign";
			this.txtAlign.ReadOnly = true;
			this.txtAlign.Size = new System.Drawing.Size(100, 22);
			this.txtAlign.TabIndex = 4;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(102, 127);
			this.txtName.Name = "txtName";
			this.txtName.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(355, 22);
			this.txtName.TabIndex = 5;
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(102, 167);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(100, 22);
			this.txtID.TabIndex = 6;
			// 
			// txtYear
			// 
			this.txtYear.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtYear.Location = new System.Drawing.Point(338, 274);
			this.txtYear.Name = "txtYear";
			this.txtYear.ReadOnly = true;
			this.txtYear.Size = new System.Drawing.Size(100, 22);
			this.txtYear.TabIndex = 7;
			// 
			// txtAlive
			// 
			this.txtAlive.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlive.Location = new System.Drawing.Point(357, 86);
			this.txtAlive.Name = "txtAlive";
			this.txtAlive.ReadOnly = true;
			this.txtAlive.Size = new System.Drawing.Size(100, 22);
			this.txtAlive.TabIndex = 8;
			// 
			// txtFirstAppearance
			// 
			this.txtFirstAppearance.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstAppearance.Location = new System.Drawing.Point(223, 274);
			this.txtFirstAppearance.Name = "txtFirstAppearance";
			this.txtFirstAppearance.ReadOnly = true;
			this.txtFirstAppearance.Size = new System.Drawing.Size(100, 22);
			this.txtFirstAppearance.TabIndex = 9;
			// 
			// txtHair
			// 
			this.txtHair.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHair.Location = new System.Drawing.Point(262, 218);
			this.txtHair.Name = "txtHair";
			this.txtHair.ReadOnly = true;
			this.txtHair.Size = new System.Drawing.Size(100, 22);
			this.txtHair.TabIndex = 11;
			// 
			// txtEye
			// 
			this.txtEye.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEye.Location = new System.Drawing.Point(102, 218);
			this.txtEye.Name = "txtEye";
			this.txtEye.ReadOnly = true;
			this.txtEye.Size = new System.Drawing.Size(100, 22);
			this.txtEye.TabIndex = 12;
			// 
			// txtAppearances
			// 
			this.txtAppearances.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAppearances.Location = new System.Drawing.Point(102, 274);
			this.txtAppearances.Name = "txtAppearances";
			this.txtAppearances.ReadOnly = true;
			this.txtAppearances.Size = new System.Drawing.Size(100, 22);
			this.txtAppearances.TabIndex = 13;
			// 
			// lblpage_id
			// 
			this.lblpage_id.AutoSize = true;
			this.lblpage_id.BackColor = System.Drawing.Color.Transparent;
			this.lblpage_id.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblpage_id.ForeColor = System.Drawing.SystemColors.Window;
			this.lblpage_id.Location = new System.Drawing.Point(46, 86);
			this.lblpage_id.Name = "lblpage_id";
			this.lblpage_id.Size = new System.Drawing.Size(50, 16);
			this.lblpage_id.TabIndex = 14;
			this.lblpage_id.Text = "Page ID";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.SystemColors.Window;
			this.lblName.Location = new System.Drawing.Point(46, 127);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(40, 16);
			this.lblName.TabIndex = 15;
			this.lblName.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Window;
			this.label1.Location = new System.Drawing.Point(56, 167);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 16);
			this.label1.TabIndex = 16;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Window;
			this.label2.Location = new System.Drawing.Point(220, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 16);
			this.label2.TabIndex = 17;
			this.label2.Text = "Align";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Window;
			this.label3.Location = new System.Drawing.Point(60, 224);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 16);
			this.label3.TabIndex = 18;
			this.label3.Text = "Eye";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Window;
			this.label4.Location = new System.Drawing.Point(220, 221);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 16);
			this.label4.TabIndex = 19;
			this.label4.Text = "Hair";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.Window;
			this.label5.Location = new System.Drawing.Point(314, 89);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 16);
			this.label5.TabIndex = 20;
			this.label5.Text = "Alive";
			// 
			// lblAppearances
			// 
			this.lblAppearances.AutoSize = true;
			this.lblAppearances.BackColor = System.Drawing.Color.Transparent;
			this.lblAppearances.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppearances.ForeColor = System.Drawing.SystemColors.Window;
			this.lblAppearances.Location = new System.Drawing.Point(113, 255);
			this.lblAppearances.Name = "lblAppearances";
			this.lblAppearances.Size = new System.Drawing.Size(77, 16);
			this.lblAppearances.TabIndex = 21;
			this.lblAppearances.Text = "Appearances";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.Window;
			this.label6.Location = new System.Drawing.Point(224, 255);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 16);
			this.label6.TabIndex = 22;
			this.label6.Text = "First Appearance";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.Window;
			this.label7.Location = new System.Drawing.Point(372, 255);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 16);
			this.label7.TabIndex = 23;
			this.label7.Text = "Year";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Window;
			this.label8.Location = new System.Drawing.Point(372, 200);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(27, 16);
			this.label8.TabIndex = 47;
			this.label8.Text = "Sex";
			// 
			// txtSex
			// 
			this.txtSex.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSex.Location = new System.Drawing.Point(405, 197);
			this.txtSex.Name = "txtSex";
			this.txtSex.ReadOnly = true;
			this.txtSex.Size = new System.Drawing.Size(100, 22);
			this.txtSex.TabIndex = 46;
			// 
			// MarvelCharactersDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(550, 380);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtSex);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblAppearances);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblpage_id);
			this.Controls.Add(this.txtAppearances);
			this.Controls.Add(this.txtEye);
			this.Controls.Add(this.txtHair);
			this.Controls.Add(this.txtFirstAppearance);
			this.Controls.Add(this.txtAlive);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtAlign);
			this.Controls.Add(this.txtPageID);
			this.Controls.Add(this.picViewCharacter);
			this.Controls.Add(this.pictureBox1);
			this.DoubleBuffered = true;
			this.Name = "MarvelCharactersDisplay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MarvelCharactersDisplay";
			this.Load += new System.EventHandler(this.MarvelCharactersDisplay_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picViewCharacter)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox picViewCharacter;
		private System.Windows.Forms.TextBox txtPageID;
		private System.Windows.Forms.TextBox txtAlign;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtYear;
		private System.Windows.Forms.TextBox txtAlive;
		private System.Windows.Forms.TextBox txtFirstAppearance;
		private System.Windows.Forms.TextBox txtHair;
		private System.Windows.Forms.TextBox txtEye;
		private System.Windows.Forms.TextBox txtAppearances;
		private System.Windows.Forms.Label lblpage_id;
		public System.Windows.Forms.Label lblName;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label lblAppearances;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.Label label7;
		public System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtSex;
	}
}