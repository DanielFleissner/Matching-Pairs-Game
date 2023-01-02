using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace MatchingPairsGame
{   
    public class Profiles
    {
        public List<Profile> ProfileList = new List<Profile>();

        public bool Exists(string name)
        {
            return ProfileList.Exists(x => x.Name == name);
        }
        
        public void Add(Profile profile)
        {
            ProfileList.Add(profile);
        }

        public void Remove(Profile profile)
        {
            ProfileList.RemoveAll(x => x.Name == profile.Name);
        }

        public Profile Find(string name)
        {
            return ProfileList.Find(x => x.Name == name);
        }

        public class Profile
        {
            
            public string Name;

            public HighScores highScores = new HighScores();
            public Profile(string name)
            {
                Name = name;
            }
            public class HighScores
            {
                public Level1 level1 = new Level1();

                public Level2 level2 = new Level2();

                public Level3 level3 = new Level3();
                public void Update(LevelPeformanceSpecs level, int turns, TimeSpan time)
                {
                    level.Turns = turns;
                    level.Time = time;
                }

                public class Level1 : LevelPeformanceSpecs
                {

                }

                public class Level2 : LevelPeformanceSpecs
                {

                }
                public class Level3 : LevelPeformanceSpecs
                {

                }
            }
        }
    }
    public class LevelPeformanceSpecs
    {
        public int Turns;
        public TimeSpan Time;
    }

    class JsonMethods
    {
        static string pathExe = System.Reflection.Assembly.GetEntryAssembly().Location;
        static string path = new FileInfo(pathExe).Directory.FullName + "\\Profiles.txt";
        public static Profiles Profiles()
        {
            Profiles profiles;

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                profiles = JsonConvert.DeserializeObject<Profiles>(json);
            }
            else
            {
                profiles = null;
            }
            if (profiles == null)
            {
                profiles = new Profiles();
            }
            return profiles;
        }

        public static void UpdateSaveFile(Profiles profiles)
        {
            string json = JsonConvert.SerializeObject(profiles);
            File.WriteAllText(path, json);
        }
    }
}
