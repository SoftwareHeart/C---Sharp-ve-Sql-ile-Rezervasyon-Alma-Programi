using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilim_mimarisi
{
    public abstract class AbstractRezervasyon
    {
        public abstract IUlasim ucak();
        public abstract IUlasim otobus();
        public abstract IKonaklama otel();
        public abstract IKonaklama cadir();
    }
 }
