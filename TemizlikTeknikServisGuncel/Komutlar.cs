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

        public static bool ValidateTCNumber(string tcNumber)
        {
            if (tcNumber.Length != 11 || !tcNumber.All(char.IsDigit)) return false;

            int[] digits = tcNumber.Select(c => c - '0').ToArray();
            int evenSum = digits.Where((x, i) => i % 2 == 0 && i < 9).Sum();
            int oddSum = digits.Where((x, i) => i % 2 == 1 && i < 9).Sum();

            return (evenSum * 7 - oddSum) % 10 == digits[9] && digits.Take(10).Sum() % 10 == digits[10];
        }
    }
}
