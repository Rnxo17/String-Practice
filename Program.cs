using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pregunta por el nombre y el usuario le da valor a la varible name
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            //Pregunta por el apellido y el usuario le da valor a la variable ltname
            Console.WriteLine("Enter Your LastName");
            string ltname = Console.ReadLine();
            //Pregunta por su profesion y el usuario le da valor a la variable profession
            Console.WriteLine("Enter Your Profession");
            string profession = Console.ReadLine();
            //Pide una frase corta y el usuario le da valor a la variable sentence
            Console.WriteLine("Say a short sentence");
            string sentence = Console.ReadLine();
            //Muestra en pantalla el nombre completo con concatenacion las comillas vacias simbolizan un espacio para que quede mas lindo
            Console.WriteLine("Full Name: " + name + " " + ltname);
            //Muestra en pantalla la profesion con interpolacion 
            Console.WriteLine($"Profesion: {profession}");
            //Muestra en pantalla la frase original con concatenacion
            Console.WriteLine("Original Sentence: " + sentence);
            //Muestra la frase en minusculas tambien se puede hacer esto sentence = sentence.ToLower(); pero decidi hacerlo de esa manera para ahorrar lineas de codigo
            Console.WriteLine("Lowercase Sentence: " + sentence.ToLower());
            //Creo una variable entera en la cual guarde el numero de caracteres de la frase y la muestra en pantalla con interpolacion 
            int sentencenumber = sentence.Length;
            Console.WriteLine($"The Phrase has {sentencenumber} characters");
            //Creo una variable string llamada firstlettername para guardar el primer caracter del nombre, si la variable es char no me deja usar el .Substring que es lo que estoy practicando. Muestra la variable en pantalla
            string firstlettername = name.Substring(0, 1);
            Console.WriteLine("First Letter of the Name: " + firstlettername);
            //Creo una variable string llamada firstletterltname para guardar el primer caracter del apellido y muestro en pantalla
            string firstletterltname = ltname.Substring(0, 1);
            Console.WriteLine($"First letter of the lastname: {firstletterltname}");
            //Se muestran en pantalla las iniciales del nombre completo
            Console.WriteLine($"Your initials: {firstlettername}.{firstletterltname}");
        }

    }
}