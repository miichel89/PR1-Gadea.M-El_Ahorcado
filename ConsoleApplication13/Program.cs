using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ahorcado
{
    public static void Main()
{
        //Declaramos la variable palabra_ que sera nuestra palabra a encontrar
        string palabra_ = "";
 
       // El jugador 2 introduce la palabra mientras el jugador 1 no mira
      

    
    Console.WriteLine("El Ahorcado Multijugador");
        Console.Write("Jugador 1 introduce la palabra con la que deseas jugar:");
    palabra_ = Console.ReadLine();
        //Si la palabra tiene
    if (palabra_.Length > 15)
    {
        Console.Write("La palabra no pude tener mas de 15 letras, intentalo con otra");
        Console.ReadLine();
    }
    Console.Clear();
// Cambiamos la palabra por guiones o espacio
string palabraoculta = ""; 
for (int i=0; i< palabra_.Length; i++)
// Ponesmos las comillas con espacio por si la palabra que quremos adivinar tiene algun espacio
if (palabra_[i] == ' ')
palabraoculta += " ";
else
// Si no hay espacio las letras seran guiones
palabraoculta += "-";
// Metemos las variables
int Intentos = 5;
char letra;
bool fin = false;
// Aqui es donde se hace que funcione el juego
do
{
// Sale la palabra oculta en guiones
Console.WriteLine( "Palabra oculta: {0}", palabraoculta);
// Sale el numero de intentos que nos quedan
Console.WriteLine( "Fallos restantes: {0}", Intentos);
// Interactuamos por primera vez con el juego metiendo una letra.
Console.Write( "Introduzca una letra: ");
letra = Convert.ToChar( Console.ReadLine() );
// Si la letra no esta nos restara un intento
if( palabra_.IndexOf( letra ) == -1 )
Intentos--;
// Si acertamos con la letra la pondra en la palabra
string siguienteMostrar = "";
for( int i = 0; i < palabra_.Length; i++)
{
if( letra == palabra_[i] )
siguienteMostrar += letra;
else
siguienteMostrar += palabraoculta[i];
}
palabraoculta = siguienteMostrar;
//Al terminar el juego comprobar si ganas
// Cuando ganas tienes mas intentos de 0
if( palabraoculta.IndexOf("-") < 0 )
{
Console.WriteLine("ENORABUENA GANASTE! {0}", "La palabra era", palabra_ );
fin = true;
}
    //Si pierdes es porque tienes 0 intentos y te muestra la palabra
if( Intentos == 0 )
{
Console.WriteLine("Lo siento. La palabra era {0}", palabra_);
fin = true;
}
}
while ( ! fin );

Console.ReadKey();
}
}