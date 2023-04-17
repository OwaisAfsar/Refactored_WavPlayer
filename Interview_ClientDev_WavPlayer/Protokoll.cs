using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_ClientDev_WavPlayer
{
    class Protokoll
    {
        private static string filename = "C:\\temp\\simpleplayerprotokoll.txt";

        public static void WriteToProtokoll(string message)
        {
            FileStream fs = new FileStream(filename, FileMode.Append);
            TextWriter writer = new StreamWriter(fs);
            writer.WriteLine(message);
            writer.Close();
            fs.Close();
        }
    }
}
