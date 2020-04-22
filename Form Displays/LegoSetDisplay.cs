using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NerdDataSet
{
	public partial class LegoSetDisplay : Form
	{
		// Creating of a data row.
		DataRow displayRow;
		
		// Global Variable
		string setURL;

		public LegoSetDisplay()
		{
			InitializeComponent();
		}

		public LegoSetDisplay(DataRow rowToDisplay)
		{
			displayRow = rowToDisplay;

			InitializeComponent();
		}

		/// <summary>
		/// Load of sets data and putting them into each textbox to display items from data set. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LegoSetDisplay_Load(object sender, EventArgs e)
		{
			txtSetID.Text = displayRow.ItemArray[0].ToString();
			txtNumber.Text = displayRow.ItemArray[1].ToString();
			txtVariant.Text = displayRow.ItemArray[2].ToString();
			txtTheme.Text = displayRow.ItemArray[3].ToString();
			txtSubTheme.Text = displayRow.ItemArray[4].ToString();
			txtYear.Text = displayRow.ItemArray[5].ToString();
			txtName.Text = displayRow.ItemArray[6].ToString();
			txtMiniFigs.Text = displayRow.ItemArray[7].ToString();
			txtPieces.Text = displayRow.ItemArray[8].ToString();

			txtUKPrice.Text = "\u00A3 " + string.Format("{0:N2}", displayRow.ItemArray[9]);
			txtUSPrice.Text = "$ " + string.Format("{0:N2}", displayRow.ItemArray[10]);
			txtCAPrice.Text = "$ " + string.Format("{0:N2}", displayRow.ItemArray[11]);
			txtEUPrice.Text = "\u20AC " + string.Format("{0:N2}", displayRow.ItemArray[12]);

			setURL = displayRow.ItemArray[13].ToString();

			SetCheckBox(displayRow.ItemArray[14].ToString(), chkOwned);
			SetCheckBox(displayRow.ItemArray[15].ToString(), chkWanted);

			txtQtyOwned.Text = displayRow.ItemArray[16].ToString();

			txtSetID.Select(0, 0);
			
		}

		/// <summary>
		/// Setting Checkbox to be checked when value is true or false.
		/// </summary>
		/// <param name="value"></param>
		/// <param name="checkBoxToSet"></param>
		private void SetCheckBox(string value, CheckBox checkBoxToSet)
		{
			if (value == "true")
				checkBoxToSet.Checked = true;
			else
				checkBoxToSet.Checked = false;
		}

		/// <summary>
		/// sets URL when view character button is clicked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pbxDisplaySet_Click(object sender, EventArgs e)
		{
			Process.Start(setURL);
		}
	}
}
