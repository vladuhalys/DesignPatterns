using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.CoR
{
    public class MP3Handler : AbstractHandler
    {
        public override object Handle(object request) // one_republic-x_name.mp3
        {
            string getFileExtension = request.ToString().Split('.').Last();
            if (getFileExtension == "mp3")
            {
                return $"MP3Handler: I'll handle the {request.ToString()}. Start play music!";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    public class WavHandler : AbstractHandler
    {
        public override object Handle(object request) // one_republic-x_name.wav
        {
            string getFileExtension = request.ToString().Split('.').Last();
            if (getFileExtension == "wav")
            {
                return $"WavHandler: I'll handle the {request.ToString()}. Start play wav vidoe!";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    public class MP4Handler : AbstractHandler
    {
        public override object Handle(object request) // one_republic-x_name.wav
        {
            string getFileExtension = request.ToString().Split('.').Last();
            if (getFileExtension == "mp4")
            {
                return $"MP4Handler: I'll handle the {request.ToString()}. Start play mp4 vidoe!";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
    public class UnknownHandler : AbstractHandler
    {
        public override object Handle(object request) 
        {
            return $"UnknownHandler: I'll handle the {request.ToString()}. I don't know what to do!";
        }
    }
}
