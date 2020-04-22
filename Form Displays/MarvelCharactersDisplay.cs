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
	public partial class MarvelCharactersDisplay : Form
	{
		// Creating of a data row.
		DataRow displayRow;
		
		// Global Variable
		string setURL;

		public MarvelCharactersDisplay()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Initiazlized a displayRow dataField
		/// </summary>
		/// <param name="rowToDisplay"></param>
		public MarvelCharactersDisplay(DataRow rowToDisplay)
		{
			displayRow = rowToDisplay;

			InitializeComponent();
		}


		/// <summary>
		/// Load of character data and putting them into each textbox to display items from data set. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MarvelCharactersDisplay_Load(object sender, EventArgs e)
		{
			{
				txtPageID.Text = displayRow.ItemArray[0].ToString();
				txtName.Text = displayRow.ItemArray[1].ToString();
				setURL = displayRow.ItemArray[2].ToString();
				txtID.Text = displayRow.ItemArray[3].ToString();



				txtAlign.Text = displayRow.ItemArray[4].ToString();
				txtEye.Text = displayRow.ItemArray[5].ToString();
				txtHair.Text = displayRow.ItemArray[6].ToString();
				txtSex.Text = displayRow.ItemArray[7].ToString();
				txtAlive.Text = displayRow.ItemArray[8].ToString();
				txtAppearances.Text = displayRow.ItemArray[9].ToString();
				txtFirstAppearance.Text = displayRow.ItemArray[10].ToString();
				txtYear.Text = displayRow.ItemArray[11].ToString();

			}
		}

		/// <summary>
		/// sets URL when view character button is clicked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void picViewCharacter_Click(object sender, EventArgs e)
		{
			Process.Start("http://marvel.fandom.com/" + setURL);

		}


	}
}
