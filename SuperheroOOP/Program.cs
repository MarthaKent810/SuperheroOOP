using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Superhero batman = new Superhero(80, true, false, "Bruce Wayne");
                batman.Run("Clark Kent");
                Console.WriteLine(batman.SecretIdentity);
            
        }
    }
}
