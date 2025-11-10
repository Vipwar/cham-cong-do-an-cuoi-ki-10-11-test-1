using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _4_ChamCong_DeTaiCuoiKi.modal
{
    public static class DataStorage
    {
        private static string dataFile = "company.dat";

        public static void SaveData(Company company)
        {
            try
            {
                using (FileStream fs = new FileStream(dataFile, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, company);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
        }

        public static Company LoadData()
        {
            if (!File.Exists(dataFile))
                return new Company();

            try
            {
                using (FileStream fs = new FileStream(dataFile, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    return (Company)bf.Deserialize(fs);
                }
            }
            catch
            {
                return new Company();
            }
        }
    }
}
