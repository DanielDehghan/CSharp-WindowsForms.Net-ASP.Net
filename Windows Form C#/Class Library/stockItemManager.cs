using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class stockItemManager
    {
        

        private List<Procedures>? _items = new List<Procedures>();
        private static string _filename = @"Beauty-shop-inventory.txt";
    public stockItemManager()
        {
            if (!File.Exists(_filename))
            {
                File.Create(_filename).Dispose();
            }
        }  
        
        public void AddNewItem(Procedures item)
        {
            //if (item == null)
            //{
            //    return;
            //}
            //foreach (Products stock in _items)
            //{
            //    if (item.name == stock.name)
            //    {
            //        throw new Exception("It already exists !");
            //    }
            //}

            _items.Add(item);
            WriteListToFile();
        }

        public void DeleteItem(Procedures procedure)
        {
            if(procedure != null)
            {
                _items.RemoveAll(a => a.name == procedure.name);
                WriteListToFile();
            }
        }

        private static string convertingItemsToString(Procedures item)
        {
            //string Result = "";
            //if(item.minutes != 0)
            //{
            //Result += item.name + "|" + item.description + "|" +"$"+item.price.ToString() + "|" + item.minutes.ToString()+" Minutes";

            //}
            //if (item.minutes == 0)
            //{
            //    Result += item.name + "|" + item.description + "|" + "$" + item.price.ToString();
            //}

            //return Result;

            return item.name + "|" + item.description + "|" + item.price.ToString() + "|" + item.minutes.ToString();


        }
        public List<Procedures> GetAllItems()
        {
            ReadListInFile();
            return _items;
        }
        private void ReadListInFile()
        {
            using(StreamReader reader = new StreamReader(_filename))
            {
                _items.Clear();
                while (!reader.EndOfStream)
                {
                    string? procedureRecord = reader.ReadLine();
                    if (procedureRecord != null)
                    {
                        Procedures procedure = convertingStringToItems(procedureRecord);
                        _items.Add(procedure);
                    }
                }
            }
        }
        public void UpdateItem(Procedures item)
        {
            if(item != null)
            {
                int procedureIndex = _items.FindIndex(a => a.name == item.name);
                if(procedureIndex != -1)
                {
                    _items[procedureIndex] = item;
                    WriteListToFile();
                }
            }
        }
         public Procedures? GetProductByName(string byName)
        {
            return _items.Where(a => a.name == byName).FirstOrDefault();
        }
        private static Procedures convertingStringToItems(string input)
        {
            string[] itemFields = input.Split('|');


            string[] _description = itemFields[1].Split(';');



            return new Procedures()
            {
                name = itemFields[0],
                description = String.Join(";", _description),
                price = double.Parse(itemFields[2]),
                minutes = int.Parse(itemFields[3])
            };


        }
            private void WriteListToFile()
          {
            using(StreamWriter writer = new StreamWriter(_filename))
            {
                foreach (var procedure in _items)
                {
                    writer.WriteLine(convertingItemsToString(procedure));
                }
            }
        }
       

    }
}