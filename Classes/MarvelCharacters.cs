using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
using System.Data;

namespace NerdDataSet
{
	class MarvelCharacters
	{
		//Accessors
		public int page_id { get; set; }
		public string name { get; set; }
		public string urlslug { get; set; }
		public string ID { get; set; }
		public string Align { get; set; }
		public string Eye { get; set; }
		public string Hair { get; set; }
		public string Sex { get; set; }
		public string Alive { get; set; }
		public int Appereances { get; set; }
		public  string FirstAppearance { get; set; }
		public int Year { get; set; }
	

		public MarvelCharacters() { }

		/// <summary>
		/// parses data and splits each line of data.
		/// </summary>
		/// <param name="linesofData"></param>
		public MarvelCharacters(string linesofData)
		{
			Regex csvParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
			string[] dataFields = csvParser.Split(linesofData);

			page_id = int.Parse(dataFields[0]);
			name = (dataFields[1]);
			urlslug = (dataFields[2]);
			ID = (dataFields[3]);
			if (dataFields[4] != "") Align = (dataFields[4]);
			Eye = (dataFields[5]);
			Hair = (dataFields[6]);
			if (dataFields[7] != "") Sex = (dataFields[7]);
			Alive = (dataFields[8]);
			if (dataFields[9] != "") Appereances = int.Parse(dataFields[9]);
			if (dataFields[10] != "") FirstAppearance = (dataFields[10]);
			if (dataFields[11] != "") Year = int.Parse(dataFields[11]);

		}

		/// <summary>
		/// Fill row colums to be named corresponding to what dataset they are in. 
		/// </summary>
		/// <param name="rowToFill"></param>
		/// <returns></returns>
		public DataRow FillDataRow(DataRow rowToFill)
		{
			rowToFill["page_id"] = page_id;
			rowToFill["name"] = name;
			rowToFill["urlslug"] = urlslug;
			rowToFill["ID"] = ID;
			rowToFill["ALIGN"] = Align;
			rowToFill["EYE"] = Eye;
			rowToFill["HAIR"] = Hair;
			rowToFill["SEX"] = Sex;
			rowToFill["ALIVE"] = Alive;
			rowToFill["Appereances"] = Appereances;
			rowToFill["FirstAppearance"] = FirstAppearance;
			rowToFill["YEAR"] = Year;
			
			return rowToFill;
		}
	}
}
