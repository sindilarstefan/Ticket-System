﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ATM_Tiketing
{
    internal class IntroduInBD
    {
        SqlConnection bd = BazaDate.GetInstance().GetCon();

        public void set_bd(SqlConnection _bd)
        {
            bd = _bd;
        }

        public void insereazaUtilizator(string nume, string prenume, string mail, string nr_tel, string parola)
        {
            string query = $"INSERT INTO Utilizatori (nume, prenume, mail, nr_tel, parola) VALUES ('{nume}', " +
                $"'{prenume}', '{mail}', '{nr_tel}', '{parola}')";
            using (SqlConnection con = bd)
            {
                try
                {
                    if (bd.State == System.Data.ConnectionState.Closed)
                    {
                        bd.Open();
                    }

                    SqlCommand cmd = new SqlCommand(query, con);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Datele au fost inserate cu succes.");
                    }
                    else
                    {
                        MessageBox.Show("Inserarea datelor a eșuat.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        public bool verificaUtilizator(string mail, string parola)
        {
            bool rezultatVerificare = false;
            string query = "SELECT COUNT(*) FROM Utilizatori WHERE mail = @mail AND parola = @parola";

            using (SqlCommand cmd = new SqlCommand(query, bd))
            {
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@parola", parola);
                try
                {
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        rezultatVerificare = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return rezultatVerificare;
        }

    }
}