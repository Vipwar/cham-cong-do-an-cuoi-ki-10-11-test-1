using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace _4_ChamCong_DeTaiCuoiKi.utils
{
    public static class FileHelper
    {
        public static void SaveToFile<T>(string filename, T data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream fs = null;
            try
            {
                fs = new FileStream(filename, FileMode.Create);
                serializer.Serialize(fs, data);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }


        public static T LoadFromFile<T>(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream fs = null;
            T obj = default(T);
            try
            {
                fs = new FileStream(filename, FileMode.Open);
                obj = (T)serializer.Deserialize(fs);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }


            return obj;
        }
    }
}
