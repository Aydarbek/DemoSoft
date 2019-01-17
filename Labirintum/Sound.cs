using System.Media;

namespace Labirintum
{
    public static class Sound
    {
        static SoundPlayer sound_fail = new SoundPlayer(Properties.Resources.Sound_fail);
        static SoundPlayer sound_start = new SoundPlayer(Properties.Resources.Sound_Start);
        static SoundPlayer sound_you_win = new SoundPlayer(Properties.Resources.Sound_You_win);
        static SoundPlayer sound_key = new SoundPlayer(Properties.Resources.Sound_Key);
        static bool Sound_enabled = true;

        public static void Sound_On()
        {
            Sound_enabled = true;
        }

        public static void Sound_Off ()
        {
            Sound_enabled = false;
        }


        public static void play_fail()
        {
            if (Sound_enabled)
                sound_fail.Play();
        }
        public static void play_you_win()
        {
            if (Sound_enabled)
                sound_you_win.Play();
        }
        public static void play_start()
        {
            if (Sound_enabled)
                sound_start.Play();
        }
        public static void play_key()
        {
            if (Sound_enabled)
                sound_key.Play();
        }
    }
}
