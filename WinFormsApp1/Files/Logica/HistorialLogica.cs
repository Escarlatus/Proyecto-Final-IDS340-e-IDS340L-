﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using WinFormsApp1.Files;
using WinFormsApp1.Forms;
using WinFormsApp1.Files.Logica;

namespace WinFormsApp1.Files.Logica
{
    public class HistorialLogica
    {
        private string connectionString;

        public HistorialLogica(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertarHistorial(Historial historial)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO HistorialReservas (ReservaId, Usuario, Libro, FechaReserva, FechaRetorno, EntregaATiempo) " +  //  <--  Corrección aquí
                             "VALUES (@ReservaId, @Usuario, @Libro, @FechaReserva, @FechaRetorno, @EntregaATiempo)";  //  <--  Corrección aquí
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservaId", historial.ReservaId);
                    cmd.Parameters.AddWithValue("@Usuario", historial.Usuario);
                    cmd.Parameters.AddWithValue("@Libro", historial.Libro);
                    cmd.Parameters.AddWithValue("@FechaReserva", historial.FechaReserva.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@FechaRetorno", historial.FechaRetorno.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@EntregaATiempo", historial.EntregaATiempo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarHistorial(Historial historial)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE HistorialReservas SET FechaDevolucionReal = @FechaDevolucionReal, EntregaATiempo = @EntregaATiempo WHERE ReservaId = @ReservaId";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservaId", historial.ReservaId);
                    cmd.Parameters.AddWithValue("@FechaDevolucionReal", historial.FechaDevolucionReal?.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@EntregaATiempo", historial.EntregaATiempo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        




    }
}
