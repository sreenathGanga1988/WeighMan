using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeighMan.Model;

namespace WeighMan
{
   public class DataBaseRepository
    {
        public DataBaseRepository()
        {
            this.cnstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\data_dictionary;Persist Security Info=True;Jet OLEDB:Database Password=**********shiyas123*";
        }
        public string cnstr;
        public void InserttoDB(string query)
        {
            OleDbConnection connection = new OleDbConnection(this.cnstr);
            OleDbCommand command = new OleDbCommand(query, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public DataSet check(string query, string tab)
        {
            DataSet set2;
            OleDbConnection selectConnection = new OleDbConnection(this.cnstr);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, selectConnection);
            try
            {
                selectConnection.Open();
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, tab);
                set2 = dataSet;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (selectConnection.State == ConnectionState.Open)
                {
                    selectConnection.Close();
                }
            }
            return set2;
        }


        public  void RemoveConfig()
        {
             using (WeighManContext cntxt= new WeighManContext())
            {
                cntxt.WeighConfigMasters.RemoveRange(cntxt.WeighConfigMasters);
                cntxt.SaveChanges();
            }
        }

        public void InsertConfig(WeighConfigMaster weighConfigMaster)
        {
            using (WeighManContext cntxt = new WeighManContext())
            {
                cntxt.WeighConfigMasters.Add(weighConfigMaster);
                cntxt.SaveChanges();
            }
        }
        public void InsertWeightData(WeightData weightData)
        {
            using (WeighManContext cntxt = new WeighManContext())
            {
                cntxt.WeightDatas.Add(weightData);
                cntxt.SaveChanges();
            }
        }
        
        public List<WeighConfigMaster> GetConfigDet()
        {
        using (WeighManContext cntxt = new WeighManContext())
            {
                return cntxt.WeighConfigMasters.ToList ();
               
            }
          
        }


        public List<WeightData> GetWeightData()
        {
            using (WeighManContext cntxt = new WeighManContext())
            {
                return cntxt.WeightDatas.ToList();

            }

        }


        public String GetSavedConfig()
        {
            using (WeighManContext cntxt = new WeighManContext())
            {
                return cntxt.WeighConfigMasters.Select(u=>u.status ).FirstOrDefault ();

            }

        }
    }
}
