using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NufusMudurluguUygulamasi.DL
{
    internal static class DataLayer
    {
       static MySqlConnection conn = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                Database = "nvi_db",
                UserID = "root",
                Password = "21015222019Pass",
            }.ConnectionString
            );

    
        public static int VatandasEkle(Vatandas m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("sp_AddVatandas", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_tc", m.Tc);
                komut.Parameters.AddWithValue("@p_ad", m.Ad);
                komut.Parameters.AddWithValue("@p_soyad", m.Soyad);
                komut.Parameters.AddWithValue("@p_tel", m.Telefon);
                komut.Parameters.AddWithValue("@p_cinsiyet", m.Cinsiyet);
                komut.Parameters.AddWithValue("@p_dogumtarihi", m.DogumTarihi);
                komut.Parameters.AddWithValue("@p_dogumyeri", m.DogumYeri);
                komut.Parameters.AddWithValue("@p_annead", m.AnaAdı);
                komut.Parameters.AddWithValue("@p_babaad", m.BabaAdı);
                komut.Parameters.AddWithValue("@p_annetc", m.AnaTc);
                komut.Parameters.AddWithValue("@p_babatc", m.BabaTc);
                komut.Parameters.AddWithValue("@p_medenihal", m.MedeniHali);
                komut.Parameters.AddWithValue("@p_adres", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally 
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
                
            }
          
        }

        internal static int EhliyetEkle(Ehliyet e)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("sp_AddEhliyet", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_sahiptc", e.VatandasTc);
                komut.Parameters.AddWithValue("@p_sinif", e.Sınıflar);

                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }

            }
        }

        internal static DataSet EhliyetGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("sp_GetAllEhliyetler", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("sp_EhliyetBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }

            }
        }

        internal static int EhliyetGüncelle(Ehliyet e)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("sp_EhliyetGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ehliyetID", e.Id);
                komut.Parameters.AddWithValue("@ehliyetSahipTC", e.VatandasTc);
                komut.Parameters.AddWithValue("@ehliyetSinif", e.Sınıflar);
            

                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }

            }
        }

        internal static int EhliyetSil(string ıd)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("sp_EhliyetSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ehliyetID", ıd);

                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }

            }
        }

        internal static string EhliyetVKontrol(string tc)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("sp_GetVatandasAdSoyad", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@input_vatandas_tc", tc);

                MySqlDataReader reader = komut.ExecuteReader();
                string adSoyad = "";
                if (reader.Read())
                {
                    adSoyad = reader.GetString(0);
                }

                reader.Close();
                return adSoyad;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }

            }
        }

        internal static DataSet VatandasGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("sp_VatandasHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("sp_VatandasBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }

            }
        }

        internal static int VatandasGüncelle(Vatandas m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("sp_VatandasGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@tc", m.Tc);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soyad", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@cinsiyet", m.Cinsiyet);
                komut.Parameters.AddWithValue("@dogumTarihi", m.DogumTarihi);
                komut.Parameters.AddWithValue("@dogumYeri", m.DogumYeri);
                komut.Parameters.AddWithValue("@anneAd", m.AnaAdı);
                komut.Parameters.AddWithValue("@babaAd", m.BabaAdı);
                komut.Parameters.AddWithValue("@anneTC", m.AnaTc);
                komut.Parameters.AddWithValue("@babaTC", m.BabaTc);
                komut.Parameters.AddWithValue("@medeniHal", m.MedeniHali);
                komut.Parameters.AddWithValue("@adres", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }

            }
        }

        internal static int VatandasSil(string tc)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("sp_DeleteVatandas", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_tc", tc);

                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }

            }
        }
    }
}
