using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Pokedex2022_CSharp
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        DataTable misPokemons02 = new DataTable();
        SoundPlayer musicadeFondo = new SoundPlayer("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/sonidos/musicadefondo.wav"); //Declaramos la musica de fondo que sonara durante la aplicación.
        public int idActual = 0; //Guardamos el ID del pokemon que se está viendo.
         
        public VentanaPrincipal()
        {
            InitializeComponent();           
            musicadeFondo.Play(); //Iniciamos la música de fondo.
            pictureBox1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/logo.png"); //Colocamos el logo de la Pokedex en la PictureBox donde aparecerán los Pokemon.
        }

    private void izquierda_Click(object sender, EventArgs e) //Método que define que hace el botón izquierdo.
        {
            idActual--; //Como el boton Izquierdo actúa como atrás, restamos uno al ID del Pokemon en el que estemos.
            if(idActual < 152 && idActual > 0) //En la Base de Datos sólo hay 151 Pokemon, así que ese es el rango en el que puede haber datos.
            { 
                misPokemons = miConexion.getPokemonPorId(idActual);
                nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
                pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            }
            imagenPos.Image = null;  //Cuando pulsamos el Botón izquierdo, vaciamos las PictureBox de la línea evolutiva.
            imagenPre.Image = null;
        }

        private void derecha_Click(object sender, EventArgs e) // ↑↑↑ Ditto ↑↑↑
        {
            idActual++; 
            if (idActual < 152 && idActual > 0) 
            {
                misPokemons = miConexion.getPokemonPorId(idActual);
                nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
                pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            }
            imagenPos.Image = null; 
            imagenPre.Image = null;
        }

        public Image convierteBlobAImagen(byte[] img) //Método para convertir los archivos BIN de la Base de Datos a imágenes que se puedan usar.
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void botonInfo_Click(object sender, EventArgs e) //Método que define cómo se carga la Segunda Ventana al abrirla.
        {           
            //Llamamos a los métodos de la Segunda Ventana y les pasamos los valores de la Base de Datos del Pokemon elegido, usando su ID como guía.
            Ventana2 v = new Ventana2();
            v.pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);            
            v.cambiaNombrePokemon(misPokemons.Rows[0]["nombre"].ToString());
            v.cambiaNombrePokemon02(misPokemons.Rows[0]["nombre"].ToString());
            v.cambiaNombrePokemon03(misPokemons.Rows[0]["nombre"].ToString());       
            v.cambiaAlturaPokemon(misPokemons.Rows[0]["altura"].ToString());
            v.cambiaPesoPokemon(misPokemons.Rows[0]["peso"].ToString());
            v.cambiaEspeciePokemon(misPokemons.Rows[0]["especie"].ToString());
            v.cambiaTipo01Pokemon(misPokemons.Rows[0]["tipo1"].ToString());
            v.cambiaTipo02Pokemon(misPokemons.Rows[0]["tipo2"].ToString());
            v.cambiaDescripcionPokemon(misPokemons.Rows[0]["descripcion"].ToString() );
            v.cambiaNumeroPokemon(misPokemons.Rows[0]["id"].ToString());
            v.cambiaNumeroPokemon02(misPokemons.Rows[0]["id"].ToString());
            v.cambiaNumeroPokemon03(misPokemons.Rows[0]["id"].ToString());
            v.cambiaHabilidadPokemon(misPokemons.Rows[0]["habilidad"].ToString());
            v.cambiaMovimiento01(misPokemons.Rows[0]["movimiento1"].ToString());
            v.cambiaMovimiento02(misPokemons.Rows[0]["movimiento2"].ToString());
            v.cambiaMovimiento03(misPokemons.Rows[0]["movimiento3"].ToString());
            v.cambiaMovimiento04(misPokemons.Rows[0]["movimiento4"].ToString());
            v.cambiaHabitat(misPokemons.Rows[0]["habitat"].ToString());
            v.Show(); //Una vez definidos todos los elementos, enseñamos la Ventana al usuario.
        }

        private void botonEvoluciones_Click(object sender, EventArgs e) //Método que define que hace el botón que muestra la Linea Evolutiva.
        {
            if (idActual < 152 && idActual > 0)
            {
                misPokemons = miConexion.getPokemonPreEV(idActual);
                misPokemons02 = miConexion.getPokemonPorId(idActual);
                if (misPokemons02.Rows[0]["preEvolucion"].ToString() != "") //Comprobamos que la Pre-Evolución no es nula.
                {  
                    imagenPre.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]); //Mostramos sólo la Imagen de la Pre-Evolución, pero se pueden mostrar todos sus datos.
                }
                else //Si no existe Pre-Evolución para el Pokemon, cargamos una imagen en blanco a la PictureBox.
                {
                    imagenPre.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/transparente.png");
                }          
                misPokemons = miConexion.getPokemonPosEV(idActual);
                misPokemons02 = miConexion.getPokemonPorId(idActual);
                if (misPokemons02.Rows[0]["posEvolucion"].ToString() != "") //Comprobamos que la Segunda Evolución no es nula.
                {
                    imagenPos.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]); //Mostramos sólo la Imagen de la Segunda Evolución, pero se pueden mostrar todos sus datos.
                }
                else //Si no existe Segunda Evolución para el Pokemon, cargamos una imagen en blanco a la PictureBox.
                {
                    imagenPos.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/transparente.png");
                }
            }
        }
    }
}