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
    public partial class Ventana3 : Form
    {

        public void cambiaMovimiento01(String movimiento1)
        {
            Movimiento01.Text = movimiento1;

        }

        public void cambiaMovimiento02(String movimiento2)
        {
            movimiento02.Text = movimiento2;

        }

        public void cambiaMovimiento03(String movimiento3)
        {
            movimiento03.Text = movimiento3;

        }

        public void cambiaMovimiento04(String movimiento4)
        {
            movimiento04.Text = movimiento4;

        }

        public void cambiaHabitatPokemon(String habitat)
        {
            cajaHabitat.Text = habitat;

        }



        public Ventana3()
        {
            InitializeComponent();
        }

        private void botonAtrasDatos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Movimiento01_Click(object sender, EventArgs e)
        {

        }

        
    }
}
