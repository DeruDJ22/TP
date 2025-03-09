using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static tpmodul4_103022300101.Kodepos;

namespace tpmodul4_103022300101
{
    class Kodepos
    {
        public enum kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja };

        // Metode untuk mendapatkan kode pos berdasarkan kelurahan
        public static int GetKodePos(kelurahan Kelurahan)
        {
            int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            return kodePos[(int)Kelurahan];
        }
    }
}
