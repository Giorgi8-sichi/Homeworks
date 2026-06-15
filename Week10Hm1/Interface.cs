namespace Week10Hm1;

public class Interface
{
    interface IPlayer
    {
        void Play();
        void Stop();
        void Pause(int minutes);
    }

    interface IRecorder
    {
        void Record();       
        void Download(string excetion);
    }
    
    
}