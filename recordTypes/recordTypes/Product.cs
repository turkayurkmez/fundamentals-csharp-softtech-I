using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recordTypes
{

    //Immutable: sadece çalışma zamanında initialize  et (değer ata). Onun dışında değişmez!
    public record Product(int Id, string Name, decimal Price, string Description);
    
}
