using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TemizlikTeknikServisGuncel
{
    internal class Komutlar
    {
        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        SqlCommand CMD;
        SqlDataAdapter sqlDataAdapter;
        public void KomutCalistir(string sorgu)
        {
            if (sorgu != null)
            {
                try
                {
                    SqlConnection.Open();
                    CMD = new SqlCommand(sorgu, SqlConnection);
                    sqlDataAdapter = new SqlDataAdapter(CMD);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CMD.Parameters.Clear();
                    SqlConnection.Close();
                }

            }
        }
        public DataTable VeriDoldur(string sorgu)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu, SqlConnection);
            sqlDataAdapter.Fill(tablo);
            return tablo;
        }
    }
}
