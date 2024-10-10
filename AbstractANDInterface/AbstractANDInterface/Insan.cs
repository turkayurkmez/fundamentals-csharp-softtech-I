using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractANDInterface
{


    public interface IKiyafet
    {

    }

    public abstract class Giyim : IKiyafet
    {

    }
    public class UstGiyim : Giyim
    {

    }
    public class Kazak : UstGiyim    {

    }
    public class KirmiziKazak : Kazak
    {

    }
    public class Insan
    {       
        public void Giy(IKiyafet kiyafet)
        {

        }
    }
}
