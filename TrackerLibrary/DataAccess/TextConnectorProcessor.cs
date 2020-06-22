using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using TrackerLibrary.Models;
// Load the textfile
// Convert the test to List<PrizeModel>
// Find the max ID
// Add the new recors with the new ID (max +1)
// Convert the prizes to list<string>
// Save the list<string> to the test file

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        //Returns the full file path of the file name
        public static string FullFilePath(this string fileName) // PrizeModels.csv
        {
           
            return $"{ConfigurationManager.AppSettings["filePath"]}\\ {fileName}";

        }
        // Takes the fullfilepath from FullFilePath(), Checks if the file exists(if not creates one) and load it 
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }
        //  Reads the contents(lines) of the file open by LoadFile() and then convert to prizeModel
        public static List<PrizeModel> ConvertToPrizeMode(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }
        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{ p.id },{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
