using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pokedex2022_CSharp
{
    //Clase para las conexiones a la Base de Datos con la info de los Pokemon.
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion() {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = listapokemons; Uid = root; Pwd =; Port = 3306;");
        }

        public DataTable getPokemonPorId(int id) //Con este método encontramos los Pokemon según su número.
        {
            try {
                conexion.Open();

                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon WHERE id='" + id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e) 
            {
                throw e;
            }
        }

        public DataTable getPokemonPreEV(int id) //Con este método encontramos si el Pokemon tiene Pre-Evolución.
        {
            try
            {
                conexion.Open();

                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon WHERE id = (SELECT preEvolucion FROM pokemon WHERE id='" + id + "')", conexion); 
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public DataTable getPokemonPosEV(int id) //Con este método encontramos si el Pokemon tiene Segunda Evolución.
        {
            try
            {
                conexion.Open();

                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon WHERE id = (SELECT posEvolucion FROM pokemon WHERE id='" + id + "')", conexion); 
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }


    }
}