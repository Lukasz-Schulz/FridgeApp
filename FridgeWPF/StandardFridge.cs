using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeWPF
{
    /// <summary>
    /// A sample fridge with no additional features.
    /// </summary>
    public class StandardFridge : AbstractFridge//przykładowa lodówka, bez dodatkowych właściwości
    {
        public StandardFridge(MainWindow window) 
            : base(window) { }
    }
}
