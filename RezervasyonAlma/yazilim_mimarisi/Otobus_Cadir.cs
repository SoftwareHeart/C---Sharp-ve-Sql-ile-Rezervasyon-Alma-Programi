using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilim_mimarisi
{
    public class Otobus_Cadir : AbstractRezervasyon
    {
        public override IKonaklama cadir()
        {
            throw new NotImplementedException();
        }

        public override IKonaklama otel()
        {
            throw new NotImplementedException();
        }

        public override IUlasim otobus()
        {
            throw new NotImplementedException();
        }

        public override IUlasim ucak()
        {
            throw new NotImplementedException();
        }
    }
}
