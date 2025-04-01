
//Top level Statement, when I don't use main method
/* var MP = new MusicPlayer();
MP.Play();

var MP3 = new Mp3Player();
MP3.Play();

var Wav = new WavPlayer();
Wav.Play(); */

public class MusicPlayer
{
    public virtual void Play()
    {
        Console.WriteLine("Playing Music");
    }
}

public class Mp3Player : MusicPlayer
{
    public override void Play()
    {
        Console.WriteLine("Mp3 Music play.");
    }
}

public class WavPlayer : Mp3Player
{
    public override void Play()
    {
        Console.WriteLine("Wav Music Play.");
    }
}

class Program
{
    static void Main()
    {
        MusicPlayer player = new MusicPlayer();
        player.Play();

        MusicPlayer player1 = new Mp3Player();
        player1.Play();

        MusicPlayer player2 = new WavPlayer();
        player2.Play();

    }
}