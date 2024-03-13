using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.CoR
{
    public class ClientCode
    {
        public void Main()
        {
            var mp3 = new MP3Handler();
            var wav = new WavHandler();
            var mp4 = new MP4Handler();
            var unknown = new UnknownHandler();
            mp3.SetNext(wav).SetNext(mp4).SetNext(unknown);
            Console.WriteLine("Client: Who gets the file?");
            var result = mp3.Handle("one_republic-x_name.mp3");
            Console.WriteLine(result);
            result = mp3.Handle("Kingsman.mp4");
            Console.WriteLine(result);
            result = mp3.Handle("The Glory of Empire Trailer.wav");
            Console.WriteLine(result);
            result = mp3.Handle("Cv.docx");
            Console.WriteLine(result);
        }
    }
}
