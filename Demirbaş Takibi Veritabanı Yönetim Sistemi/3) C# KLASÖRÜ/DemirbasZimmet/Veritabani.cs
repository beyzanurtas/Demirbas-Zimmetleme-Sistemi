﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemirbasZimmet
{
    class Veritabani
    {
        static string connectionString = "Data Source=.;Initial Catalog=Demirbas;Integrated Security=true;";
        static SqlConnection sunucuBaglantisi = new SqlConnection(connectionString);

        static public DataTable ProsedurCalistir_TabloGelir(string prosedurAdi, ArrayList parametreler)
        {
            DataTable f_table = new DataTable();
            sunucuBaglantisi.Open();
            SqlCommand komut = sunucuBaglantisi.CreateCommand();
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = prosedurAdi;
            if (parametreler != null)
            {
                foreach (DictionaryEntry parametre in parametreler)
                {
                    komut.Parameters.Add(new SqlParameter(parametre.Key.ToString(), parametre.Value));
                }
            }
            SqlDataReader dr = komut.ExecuteReader();
            f_table.Load(dr);
            sunucuBaglantisi.Close();
            return f_table;
        }
        static public bool ProsedurCalistir_MesajDegerlendir(string prosedurAdi, ArrayList parametreler)
        {
            DataTable f_table = ProsedurCalistir_TabloGelir(prosedurAdi, parametreler);
            if (Convert.ToInt32(f_table.Rows[0]["Sonuc"]) == 0)
            {
                System.Windows.Forms.MessageBox.Show(f_table.Rows[0]["Mesaj"].ToString());
                return true;
            }
            System.Windows.Forms.MessageBox.Show(f_table.Rows[0]["Mesaj"].ToString());
            return false;
        }
        static public DataTable SELECTCalistir(string SQLKomutu)
        {
            DataTable f_table = new DataTable();
            sunucuBaglantisi.Open();
            SqlCommand komut = sunucuBaglantisi.CreateCommand();
            komut.CommandType = CommandType.Text;
            komut.CommandText = SQLKomutu;
            SqlDataReader dr = komut.ExecuteReader();
            f_table.Load(dr);
            sunucuBaglantisi.Close();
            return f_table;
        }
    }
}
