using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pokedex2022_CSharp
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion() {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = listapokemons; Uid = root; Pwd =; Port = 3306;");
        }

        public DataTable getPokemonPorId(int id) 
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

        public DataTable getEvolucion01()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon WHERE preEvolucion IS NULL;", conexion);
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

        public DataTable getEvolucion02()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon WHERE posEvolucion IS NULL;", conexion);
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

        public DataTable getEvolucion03()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT imagen FROM pokemon WHERE preEvolucion IS NOT NULL AND posEvolucion IS NOT NULL;'", conexion);
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