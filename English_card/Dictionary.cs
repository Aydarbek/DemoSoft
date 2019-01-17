using System.IO;

namespace English_card
{
    class Dictionary
    {
        int total = 0;

        string[] english; //apple
        string[] russian; //яблоко
        string[] audio_eng; // english/apple.mp3
        string[] audio_rus; // russian/apple.mp3
        string[] image; // image/apple.jpg
        string[] video; //video/apple.mp4 либо ""

       public Dictionary ()
        {
            Init();
        }

        public string English (int nr)
        {
            if (nr < 0 || nr > total) return "";
            return english[nr];
        }
        public string Russian(int nr)
        {
            if (nr < 0 || nr > total) return "";
            return russian[nr];

        }
        public string Audio_eng(int nr)
        {
            if (nr < 0 || nr > total) return "";
            return audio_eng[nr];

        }
        public string Audio_rus(int nr)
        {
            if (nr < 0 || nr > total) return "";
            return audio_rus[nr];

        }
        public string Image(int nr)
        {
            if (nr < 0 || nr >= total) return "";
            return image[nr];

        }
        public string Video(int nr)
        {
            if (nr < 0 || nr > total) return "";
            return video[nr];

        }

        public int Total()
        {
            return total;
        }

            

        private void Init ()
        {
            total = 0;
            DirectoryInfo di = new DirectoryInfo("data\\text\\");                 //устанавливаем директорию, в которой будем работать.
            FileInfo[] info = di.GetFiles("*.txt", SearchOption.TopDirectoryOnly); //загружаем в массив типа FileInfo наши файлы
            total = info.Length;

            english = new string[total];
            russian = new string[total];
            audio_eng = new string[total];
            audio_rus = new string[total];
            image = new string[total];
            video = new string[total];
            int j=0;

            foreach (FileInfo file in info)
            {
                string filename = file.FullName; // data\\apple.txt
                string name = file.Name.Replace(".txt", ""); // apple
                string[] lines = File.ReadAllLines(filename);
                english[j] = lines[0];
                russian[j] = lines[1];
                audio_eng[j] = "data\\english\\" + name + ".mp3";
                audio_rus[j] = "data\\russian\\" + name + ".mp3";
                if (!File.Exists(audio_eng[j])) audio_eng [j] = "";
                if (!File.Exists(audio_rus[j])) audio_rus[j] = "";

                image[j] = "data\\images\\" + name + ".jpg";
                video[j] = "data\\video\\" + name + ".mp4";
                if (!File.Exists(image[j])) image[j] = "";
                if (!File.Exists(video[j])) video[j] = "";
                j++;
            }


        }
    }


}
