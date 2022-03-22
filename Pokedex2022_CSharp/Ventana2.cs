using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex2022_CSharp
{
    public partial class Ventana2 : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        
        public void cambiaDescripcionPokemon(String descripcion) 
        {
            cajaDescripcion.Text = descripcion;           
        }

        public void cambiaNombrePokemon(String nombre)
        {     
            cajaNombre.Text = nombre; 
        }
        public void cambiaAlturaPokemon(String altura)
        {
            cajaAltura.Text = altura + " M" ;
        }

        public void cambiaPesoPokemon(String peso)
        {
            cajaPeso.Text = peso + " KG";
        }


        public void cambiaEspeciePokemon(String especie)
        {
            cajaEspecie.Text = especie;
        }

        public void cambiaTipo01Pokemon(String tipo1)
        {
            cajaTipo01.Text = tipo1;

            if(tipo1.Equals("Planta"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/planta.png");
            }
            if (tipo1.Equals("Veneno"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/veneno.png");
            }
            if (tipo1.Equals("Fuego"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/fuego.png");
            }
            if (tipo1.Equals("Agua"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/agua.png");
            }
            if (tipo1.Equals("Bicho"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/bicho.png");
            }
            if (tipo1.Equals("Volador"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/volador.png");
            }
            if (tipo1.Equals("Electrico"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/electrico.png");
            }
            if (tipo1.Equals("Tierra"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/tierra.png");
            }
            if (tipo1.Equals("Normal"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/normal.png");
            }
            if (tipo1.Equals("Dragon"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/dragon.png");
            }
            if (tipo1.Equals("Lucha"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/lucha.png");
            }
            if (tipo1.Equals("Psiquico"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/psiquico.png");
            }
            if (tipo1.Equals("Roca"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/roca.png");
            }
            if (tipo1.Equals("Acero"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/acero.png");
            }
            if (tipo1.Equals("Hielo"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/hielo.png");
            }
            if (tipo1.Equals("Fantasma"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/fantasma.png");
            }
            if (tipo1.Equals("Siniestro"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/xp/Downloads/siniestro.png");
            }
            else
            {
                
            }
        }

        public void cambiaTipo02Pokemon(String tipo2)
        {
            cajaTipo02.Text = tipo2;

            if (tipo2.Equals("Planta"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/planta.png");
            }
            if (tipo2.Equals("Veneno"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/veneno.png");
            }
            if (tipo2.Equals("Fuego"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/fuego.png");
            }
            if (tipo2.Equals("Agua"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/agua.png");
            }
            if (tipo2.Equals("Bicho"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/bicho.png");
            }
            if (tipo2.Equals("Volador"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/volador.png");
            }
            if (tipo2.Equals("Electrico"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/electrico.png");
            }
            if (tipo2.Equals("Tierra"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/tierra.png");
            }
            if (tipo2.Equals("Normal"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/normal.png");
            }
            if (tipo2.Equals("Dragon"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/dragon.png");
            }
            if (tipo2.Equals("Lucha"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/lucha.png");
            }
            if (tipo2.Equals("Psiquico"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/psiquico.png");
            }
            if (tipo2.Equals("Roca"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/roca.png");
            }
            if (tipo2.Equals("Acero"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/acero.png");
            }
            if (tipo2.Equals("Hielo"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/hielo.png");
            }
            if (tipo2.Equals("Fantasma"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/fantasma.png");
            }
            if (tipo2.Equals("Siniestro"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/xp/Downloads/siniestro.png");
            }
            else
            {

            }
        }

        public void cambiaNumeroPokemon(String numero)
        {
            cajaNumero.Text = numero;
        }

        public void cambiaHabilidadPokemon(String habilidad)
        {
            cajaHabilidad.Text = habilidad;
        }


    public Ventana2()
        {
            InitializeComponent();        
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonMasDatos_Click(object sender, EventArgs e)
        {

            Ventana3 v3 = new Ventana3(); 
            v3.cambiaMovimiento01(misPokemons.Rows[0]["movimiento1"].ToString());
            v3.cambiaMovimiento02(misPokemons.Rows[0]["movimiento2"].ToString());
            v3.cambiaMovimiento03(misPokemons.Rows[0]["movimiento3"].ToString());
            v3.cambiaMovimiento04(misPokemons.Rows[0]["movimiento4"].ToString());
            v3.cambiaHabitatPokemon(misPokemons.Rows[0]["habitat"].ToString());
            
        }

        private void cajaTipo01_Click(object sender, EventArgs e)
        {

        }
    }
}
