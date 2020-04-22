using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using System.IO;
using System.Data.SQLite;

/* Name: Reggie Telemaque
* Date: 4/20/2020
* 
* Program: Nerd DataSet: Data Viewer
* 
* Purpose: A program that allows a user to view data in a datatable that was accessed by way of a dataset. 
* 
*/

namespace NerdDataSet
{
	public partial class NerdDataSet : Form
	{
		// DataTables
		DataTable starwarsLegoSet;
		DataTable marvelCharacters;
		DataTable dcCharacters;

		string currentTable;

		// Data set
		DataSet allData = new DataSet("All Data Sets:");

		public NerdDataSet()
		{
			InitializeComponent();
		}

		//private DataTable QueryDatabase(string sqlQueryCommand)
		//{
		//	SQLiteConnection dbConnection = new SQLiteConnection(@"Data Source=Database\NerdDataSet.db");
		//	dbConnection.Open();

		//	SQLiteCommand sqlCommand = new SQLiteCommand();

		//	sqlCommand.Connection = dbConnection;
		//	sqlCommand.CommandText = sqlQueryCommand;


		//	SQLiteDataReader dataReader = sqlCommand.ExecuteReader();

		//	DataTable databaseTable = new DataTable();
		//	databaseTable.Load(dataReader);


		//	dataReader.Close();
		//	dbConnection.Close();

		//	return databaseTable;



		//}

		//private void LoadComboBox()
		//{
		//	string query = "select name from sqlite_master where type = 'table' and name not like 'sqlite+_%'";

		//	DataTable queryResults = QueryDatabase(query);

		//	for (int index = 0; index < queryResults.Rows.Count; index++)
		//	{
		//		cbxDataTables.Items.Add(queryResults.Rows[index].ItemArray[0].ToString());
		//	}
		//}

		/// <summary>
		/// Created a generic data table. 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		private DataTable CreateTable<T>()
		{
			DataTable genericDataTable = new DataTable();

			Type type = typeof(T);

			foreach (PropertyInfo proepertyData in type.GetProperties())
			{
				genericDataTable.Columns.Add(proepertyData.Name, proepertyData.PropertyType);
			}

			return genericDataTable;
		}

		/// <summary>
		/// Method to open file from stream reader to display rows in the data grid view. 
		/// </summary>
		/// <param name="fileToLoad"></param>
		private void LoadTable(/*DataTable tableToLoad*/ string fileToLoad)
		{
			StreamReader inputFile = File.OpenText(@"Data\" + fileToLoad);

			inputFile.ReadLine();
			while (!inputFile.EndOfStream)

			{
				if (fileToLoad.ToString().Contains("Star"))
				{
					DataRow rowToAdd = starwarsLegoSet.NewRow();

					LegoSets legoSet = new LegoSets(inputFile.ReadLine());

					starwarsLegoSet.Rows.Add(legoSet.FillDataRow(rowToAdd));


				}
				else if (fileToLoad.ToString().Contains("Marvel"))
				{
					DataRow rowToAdd = marvelCharacters.NewRow();

					MarvelCharacters marvelCharacter = new MarvelCharacters(inputFile.ReadLine());

					marvelCharacters.Rows.Add(marvelCharacter.FillDataRow(rowToAdd));

					
				}
				else if (fileToLoad.ToString().Contains("DC"))
				{
					DataRow rowToAdd = dcCharacters.NewRow();

					DCCharacters dcCharacter = new DCCharacters(inputFile.ReadLine());

					dcCharacters.Rows.Add(dcCharacter.FillDataRow(rowToAdd));
				}
			}

		}
	
		/// <summary>
		/// Change of selected item. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbxDataTables_SelectedIndexChanged(object sender, EventArgs e)
		{
			//string query;
			dgvInformation.DataSource = null;

			dgvInformation.DataSource = allData.Tables[cbxDataTables.SelectedItem.ToString()];

			currentTable = cbxDataTables.SelectedItem.ToString();

			//if (cbxDataTables.SelectedItem.ToString().Contains("-"))
			//{
			//	query = "select * from '" + cbxDataTables.SelectedItem.ToString() + "'";
			//}
			//else
			//{
			//	query = "select * from " + cbxDataTables.SelectedItem.ToString();
			//}

			//dgvInformation.DataSource = QueryDatabase(query);
		}

		/// <summary>
		/// Load event for creating tables, and added names to the combo box. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NerdDataSet_Load(object sender, EventArgs e)
		{

			starwarsLegoSet = CreateTable<LegoSets>();
			starwarsLegoSet.TableName = "Star Wars Lego Sets";

			marvelCharacters = CreateTable<MarvelCharacters>();
			marvelCharacters.TableName = "Marvel Characters";

			dcCharacters = CreateTable<MarvelCharacters>();
			dcCharacters.TableName = "DC Characters";

			LoadTable("LegoStarWars.csv");
			cbxDataTables.Items.Add(starwarsLegoSet.TableName);

			LoadTable("Marvel-Characters.csv");
			cbxDataTables.Items.Add(marvelCharacters.TableName);

			LoadTable("DC-Characters.csv");
			cbxDataTables.Items.Add(dcCharacters.TableName);

			cbxDataTables.Enabled = true;

			allData.Tables.Add(starwarsLegoSet);
			allData.Tables.Add(marvelCharacters);
			allData.Tables.Add(dcCharacters);

			cbxDataTables.Enabled = true;

			cbxDataTables.SelectedIndex = 0;

			dgvInformation.DefaultCellStyle.BackColor = Color.DarkGray;
			dgvInformation.DefaultCellStyle.ForeColor = Color.Black;
			dgvInformation.DefaultCellStyle.SelectionBackColor = Color.DimGray;
			
			

			//LoadComboBox();
		}
		
		/// <summary>
		/// Double click event to view characters and sets.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgvInformation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = dgvInformation.CurrentCell.RowIndex;

			DataGridViewRow rowClicked = dgvInformation.Rows[rowIndex];

			DataRowView rowView = (DataRowView)rowClicked.DataBoundItem;

			DataRow rowToDisplay = rowView.Row;

			// Switch statement to switch Displays
			switch (currentTable)
			{
				//Switch to Lego Sets Display
				case "Star Wars Lego Sets":
					LegoSetDisplay showLegoSet = new LegoSetDisplay(rowToDisplay);
					showLegoSet.Show();
					break;
				// Switch to Marvel Characters Display
				case "Marvel Characters":
					MarvelCharactersDisplay showMarvelCharacters = new MarvelCharactersDisplay(rowToDisplay);
					showMarvelCharacters.Show();
					break;
				// Switch to DC Characters Display
				case "DC Characters":
					DCCharactersDisplay showDCCharacters = new DCCharactersDisplay(rowToDisplay);
					showDCCharacters.Show();
					break;	

			}

		}


	}
}



