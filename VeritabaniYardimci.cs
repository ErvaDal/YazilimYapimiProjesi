using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ZueKelime
{
	public class VeritabaniYardimci
	{
		private string baglantiCumlesi = "Data Source=DESKTOP-3D472GQ\\SQLEXPRESS;Initial Catalog=ZueKelime;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

		private string sorgu;

		/*public DataTable VeriGetir(string sorgu)
		{
			try
			{
				using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
				{
					SqlDataAdapter adaptor = new SqlDataAdapter(sorgu, baglanti);
					DataTable tablo = new DataTable();
					adaptor.Fill(tablo);
					return tablo;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Veri çekme hatası:\n" + ex.Message);
				return null;
			}
		}*/

		public DataTable VeriGetir(string sql, Dictionary<string, object> parametreler = null)
		{
			using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
			{
				using (SqlCommand komut = new SqlCommand())
				{
					komut.Connection = baglanti;
					komut.CommandText = sql;

					if (parametreler != null)
					{
						foreach (var param in parametreler)
						{
							komut.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
						}
					}

					SqlDataAdapter adapter = new SqlDataAdapter(komut);
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					return dt;
				}
			}
		}

		public void KomutCalistir(string sorgu)
		{
			try
			{
				using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
				{
					SqlCommand komut = new SqlCommand(sorgu, baglanti);
					baglanti.Open();
					komut.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("SQL komut hatası:\n" + ex.Message);
			}
		}
	}
}
