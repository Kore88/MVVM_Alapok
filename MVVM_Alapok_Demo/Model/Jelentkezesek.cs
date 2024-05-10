using MVVM_Alapok_Demo.DBCommand;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_Alapok_Demo.Model
{
    internal class Jelentkezesek
    {
        List<Jelentkezo> jelentkezok = new List<Jelentkezo>();

        MySqlConnection conn = new MySqlConnection(DBCommand.Kapcsolat.Conn);

        private void JelentkezokFeltoltese()
        {
            try
            {
                conn.Open();
                SQLCommands sQLCommands = new SQLCommands();

                MySqlCommand cmd = new MySqlCommand(sQLCommands.MindentCmd,conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string n = dr.GetString(0);
                    string o = dr.GetString(1);

                    Jelentkezo j = new Jelentkezo(n,o);
                    jelentkezok.Add(j);
                }

                conn.Close();
            }
            catch (Exception ex) {MessageBox.Show(ex.Message); }
            finally { conn.Close(); } 
        }

        public List<Jelentkezo> getJelentkezok()
        {
            JelentkezokFeltoltese();
            return jelentkezok;
        }

    }
}
