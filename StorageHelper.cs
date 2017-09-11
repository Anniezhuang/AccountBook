using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//用于存储数据
namespace AccountBook
{
    public class StorageHelper
    {
        //以下三个分别用于存储支出数据、收入数据和预算数据
        public static string CostReminderDat = "Costreminder.dat";
        public static string GetReminderDat = "Getreminder.dat";
        public static string GuessReminderDat = "Guessreminder.dat";

        public static bool Serialization<T>(List<T> list, string path)
        {
            FileStream fs = null;

            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, list);
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static List<T> Deserialization<T>(string path)
        {
            FileStream fs = null;

            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                List<T> list = (List<T>)formatter.Deserialize(fs);

                return list;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
