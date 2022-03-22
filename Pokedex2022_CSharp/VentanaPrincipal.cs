using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex2022_CSharp
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        public int idActual = 0; //guarda el id del pokemon que se está viendo
        public VentanaPrincipal()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/logo.png");

        }

        
    

    private void izquierda_Click(object sender, EventArgs e)
        {
            idActual--;
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
        }

        public Image convierteBlobAImagen(byte[] img) {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void derecha_Click(object sender, EventArgs e)
        {
            idActual++;
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void botonInfo_Click(object sender, EventArgs e)
        {
            
            Ventana2 v = new Ventana2();
            v.pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            v.cambiaNombrePokemon(misPokemons.Rows[0]["nombre"].ToString());
            v.cambiaNombrePokemon02(misPokemons.Rows[0]["nombre"].ToString());
            v.cambiaAlturaPokemon(misPokemons.Rows[0]["altura"].ToString());
            v.cambiaPesoPokemon(misPokemons.Rows[0]["peso"].ToString());
            v.cambiaEspeciePokemon(misPokemons.Rows[0]["especie"].ToString());
            v.cambiaTipo01Pokemon(misPokemons.Rows[0]["tipo1"].ToString());
            v.cambiaTipo02Pokemon(misPokemons.Rows[0]["tipo2"].ToString());
            v.cambiaDescripcionPokemon(misPokemons.Rows[0]["descripcion"].ToString() );
            v.cambiaNumeroPokemon(misPokemons.Rows[0]["id"].ToString());
            v.cambiaNumeroPokemon02(misPokemons.Rows[0]["id"].ToString());
            v.cambiaHabilidadPokemon(misPokemons.Rows[0]["habilidad"].ToString());
            v.cambiaMovimiento01(misPokemons.Rows[0]["movimiento1"].ToString());
            v.cambiaMovimiento02(misPokemons.Rows[0]["movimiento2"].ToString());
            v.cambiaMovimiento03(misPokemons.Rows[0]["movimiento3"].ToString());
            v.cambiaMovimiento04(misPokemons.Rows[0]["movimiento4"].ToString());
            v.cambiaHabitat(misPokemons.Rows[0]["habitat"].ToString());

            v.Show();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
