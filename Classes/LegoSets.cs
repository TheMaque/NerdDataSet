using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
using System.Data;

namespace NerdDataSet
{
	class LegoSets
	{
		//Accessors
		public int SetID { get; set; }
		public string Number { get; set; }
		public int Variant { get; set; }
		public string Theme { get; set; }
		public string SubTheme { get; set; }
		public int Year { get; set; }
		public string Name { get; set; }
		public int Minifigs { get; set; }
		public int Pieces { get; set; }
		public decimal UKPrice { get; set; }
		public decimal USPrice { get; set; }
		public decimal CAPrice { get; set; }
		public decimal EUPrice { get; set; }
		public string ImageURL { get; set; }
		public bool Owned { get; set; }
		public bool Wanted { get; set; }
		public int QtyOwned { get; set; }


		public LegoSets() { }

		/// <summary>
		/// parses data and splits each line of data.
		/// </summary>
		/// <param name="linesofData"></param>
		public LegoSets(string linesofData)
		{
			Regex csvParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
			string[] dataFields = csvParser.Split(linesofData);


			SetID = int.Parse(dataFields[0]);
			Number = dataFields[1];
			Variant = int.Parse(dataFields[2]);
			Theme = dataFields[3];
			SubTheme = dataFields[4];
			Year = int.Parse(dataFields[5]);
			Name = dataFields[6];
			if (dataFields[7] != "") Minifigs = int.Parse(dataFields[7]);
			if (dataFields[8] != "") Pieces = int.Parse(dataFields[8]);
			if (dataFields[9] != "") UKPrice = decimal.Parse(dataFields[9]);
			if (dataFields[10] != "") USPrice = decimal.Parse(dataFields[10]);
			if (dataFields[11] != "") CAPrice = decimal.Parse(dataFields[11]);
			if (dataFields[12] != "") CAPrice = decimal.Parse(dataFields[12]);

			ImageURL = dataFields[13];
			if (dataFields[14] == "NO")
				Owned = false;
			else
				Owned = true;
			if (dataFields[15] == "NO")
				Owned = false;
			else
				Owned = true;
			QtyOwned = int.Parse(dataFields[16]);
		}

		/// <summary>
		/// Fill row colums to be named corresponding to what dataset they are in. 
		/// </summary>
		/// <param name="rowToFill"></param>
		/// <returns></returns>
		public DataRow FillDataRow(DataRow rowToFill)
		{
			rowToFill["SetID"] = SetID;
			rowToFill["Number"] = Number;
			rowToFill["Variant"] = Variant;
			rowToFill["Theme"] = Theme;
			rowToFill["SubTheme"] = SubTheme;
			rowToFill["Year"] = Year;
			rowToFill["Name"] = Name;
			rowToFill["Minifigs"] = Minifigs;
			rowToFill["Pieces"] = Pieces;
			rowToFill["UKPrice"] = UKPrice;
			rowToFill["USPrice"] = USPrice;
			rowToFill["CAPrice"] = CAPrice;
			rowToFill["EUPRice"] = EUPrice;
			rowToFill["ImageURL"] = ImageURL;
			rowToFill["Owned"] = Owned;
			rowToFill["Wanted"] = Wanted;
			rowToFill["QtyOwned"] = QtyOwned;

			return rowToFill;
		}
	}
}