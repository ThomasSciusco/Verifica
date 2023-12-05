using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verifica;

namespace Verifica
{
    public class immobili
    {
        class immobile
        {
            public int superficie { get; set; }
            public int numero { get; set; }
            public int cateegoria { get; set; }

            public virtual double calcolavalorelocale()
            {
                return superficie * cateegoria;
            }
        }

        class terreno : immobile
        {
            public bool fabbricabile { get; set; }

            public override double calcolavalorelocale()
            {
                double valorelocale = base.calcolavalorelocale();

                if (fabbricabile)
                {
                    valorelocale *= 1.3; 
                }
                else
                {
                    valorelocale *= 0.9; 
                }

                return valorelocale;
            }
        }

        class casa: immobile
        {
            public int numerovani { get; set; }

            public override double calcolavalorelocale()
            {
                return base.calcolavalorelocale() * numerovani;
            }
        }

        class attico : casa
        {
            public int areaterrazzo { get; set; }

            public override double calcolavalorelocale()
            {
                return base.calcolavalorelocale() + (areaterrazzo * 2); 
            }
        }
    }
}
