using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih15_Sekolahku.Kelas;

public class KelasModel
{
    public int KelasId { get; set; }
    public string KelasName { get; set; }
    public int Tingkat { get; set; }
    public string Flag{ get; set; }

    public int JurusanId { get; set; }
    public string JurusanName { get; set; }
    public string Code { get; set; }

}
