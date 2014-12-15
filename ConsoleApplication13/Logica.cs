using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Logica
    {
        
        public  string AhorcadoMultijugador(string palabra_)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("*      El Ahorcado        *");
            Console.WriteLine("*      Multijugador       *");
            Console.WriteLine("*                         *");
            Console.WriteLine("***************************");
            Console.Write("Jugador uno introduce la palabra con la que deseas comenzar a jugar:");
            // El jugador 2 introduce la palabra mientras el jugador 1 no mira
            palabra_ = Console.ReadLine();
            //Si la palabra tiene mas de 15 letras no sera validad
            if (palabra_.Length > 15)
            {
                Console.Write("La palabra no pude tener mas de 15 letras, intentalo con otra");
                Console.ReadLine();
            }
            //limpia la pantalla para que nose vea la palabra que emos puesto
            Console.Clear();
            return palabra_;
        }
        public void Titulo()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("*      El Ahorcado        *");
            Console.WriteLine("*      Multijugador       *");
            Console.WriteLine("*                         *");
            Console.WriteLine("***************************");
        }

        public  int Fallo(string palabra_, int Intentos, char letra)
        {

            // Si la letra no esta nos restara un intento
            if (palabra_.IndexOf(letra) == -1)
                Intentos--;
            return Intentos;
        }

        public string Acierto(string palabra_, string palabraoculta, char letra)
        {
            // Si acertamos con la letra la pondra en la palabra
            string siguienteMostrar = "";
            for (int i = 0; i < palabra_.Length; i++)
            {
                if (letra == palabra_[i])
                    siguienteMostrar += letra;
                else
                    siguienteMostrar += palabraoculta[i];
            }
            return siguienteMostrar;
        }

        public bool Ganar(string palabra_, string palabraoculta, bool fin)
        {
            //Al terminar el juego comprobar si ganas
            // Cuando ganas tienes mas intentos de 0
            if (palabraoculta.IndexOf("-") < 0)
            {
                Console.WriteLine("ENORABUENA GANASTE! {0}", "La palabra era", palabra_);
                fin = true;
            }
            return fin;
        }

        public bool Perder(string palabra_, int Intentos, bool fin)
        {
            //Si pierdes es porque tienes 0 intentos y te muestra la palabra
            if (Intentos == 0)
            {
                Console.WriteLine("Perdiste, la palabra era {0}", palabra_);
                fin = true;
            }
            return fin;
        }
    }
}
