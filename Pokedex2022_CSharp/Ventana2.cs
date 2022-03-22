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
        public void cambiaNombrePokemon02(String nombre)
        {
            cajaNombre02.Text = nombre;
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
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/planta.png");
            }
            if (tipo1.Equals("Veneno"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/veneno.png");
            }
            if (tipo1.Equals("Fuego"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/fuego.png");
            }
            if (tipo1.Equals("Agua"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/agua.png");
            }
            if (tipo1.Equals("Bicho"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/bicho.png");
            }
            if (tipo1.Equals("Volador"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/volador.png");
            }
            if (tipo1.Equals("Electrico"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/electrico.png");
            }
            if (tipo1.Equals("Tierra"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/tierra.png");
            }
            if (tipo1.Equals("Normal"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/normal.png");
            }
            if (tipo1.Equals("Dragon"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/dragon.png");
            }
            if (tipo1.Equals("Lucha"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/lucha.png");
            }
            if (tipo1.Equals("Psiquico"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/psiquico.png");
            }
            if (tipo1.Equals("Roca"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/roca.png");
            }
            if (tipo1.Equals("Acero"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/acero.png");
            }
            if (tipo1.Equals("Hielo"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/hielo.png");
            }
            if (tipo1.Equals("Fantasma"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/fantasma.png");
            }
            if (tipo1.Equals("Siniestro"))
            {
                imagentipo1.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/siniestro.png");
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
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/planta.png");
            }
            if (tipo2.Equals("Veneno"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/veneno.png");
            }
            if (tipo2.Equals("Fuego"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/fuego.png");
            }
            if (tipo2.Equals("Agua"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/agua.png");
            }
            if (tipo2.Equals("Bicho"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/bicho.png");
            }
            if (tipo2.Equals("Volador"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/volador.png");
            }
            if (tipo2.Equals("Electrico"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/electrico.png");
            }
            if (tipo2.Equals("Tierra"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/tierra.png");
            }
            if (tipo2.Equals("Normal"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/normal.png");
            }
            if (tipo2.Equals("Dragon"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/dragon.png");
            }
            if (tipo2.Equals("Lucha"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/lucha.png");
            }
            if (tipo2.Equals("Psiquico"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/psiquico.png");
            }
            if (tipo2.Equals("Roca"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/roca.png");
            }
            if (tipo2.Equals("Acero"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/acero.png");
            }
            if (tipo2.Equals("Hielo"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/hielo.png");
            }
            if (tipo2.Equals("Fantasma"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/fantasma.png");
            }
            if (tipo2.Equals("Siniestro"))
            {
                imagentipo2.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/siniestro.png");
            }
            else
            {

            }
        }
        public void cambiaNumeroPokemon(String numero)
        {
            cajaNumero.Text = numero;
        }
        public void cambiaNumeroPokemon02(String numero)
        {
            cajaNumero02.Text = numero;
        }
        public void cambiaHabilidadPokemon(String habilidad)
        {
            cajaHabilidad.Text = habilidad;
        }
        public void cambiaMovimiento01(String movimiento01)
        {
            cajaMovimiento01.Text = movimiento01;
        }
        public void cambiaMovimiento02(String movimiento02)
        {
            cajaMovimiento02.Text = movimiento02;
        }
        public void cambiaMovimiento03(String movimiento03)
        {
            cajaMovimiento03.Text = movimiento03;
        }
        public void cambiaMovimiento04(String movimiento04)
        {
            cajaMovimiento04.Text = movimiento04;
        }
        public void cambiaHabitat(String habitat)
        {
            if (habitat.Equals("Agua Dulce"))
            {
                cajaHabitat.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/aguadulce.png");
            }
            if (habitat.Equals("Agua Salada"))
            {
                cajaHabitat.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/aguasalada.png");
            }
            if (habitat.Equals("Bosque"))
            {
                cajaHabitat.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/bosque.png");
            }
            if(habitat.Equals("Campo"))
            {
                cajaHabitat.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/campo.png");
            }
            if (habitat.Equals("Bosque"))
            {
                cajaHabitat.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/bosque.png");
            }
            if (habitat.Equals("Ciudad"))
            {
                cajaHabitat.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/ciudad.png");
            }
            if (habitat.Equals("Montaña"))
            {
                cajaHabitat.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/montania.png");
            }
            if (habitat.Equals("Pradera"))
            {
                cajaHabitat.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/pradera.png");
            }
            if (habitat.Equals("RARO"))
            {
                cajaHabitat.Image = Image.FromFile("C:/Users/curri/Desktop/Pokedex2022-master/Pokedex2022_CSharp/imagenes/raro.png");
            }
        }


        public Ventana2()
        {
            InitializeComponent();
            
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
