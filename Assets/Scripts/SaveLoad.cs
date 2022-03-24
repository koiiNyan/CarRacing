using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Cars
{
    public class SaveLoad : MonoBehaviour
    {

        //Загрузить из PlayerPrefs результаты
        public Highscores LoadData()
        {
            string jsonString = PlayerPrefs.GetString("highscoreTable");
            Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);
            if (highscores == null)
            {
                highscores = new Highscores()
                {
                    saveDataList = new List<SaveData>()
                };
            }

            return highscores;
        }



        //Сохранить результаты в PlayerPrefs
        public void SaveData(string name, float time)
        {
            SaveData highscoreEntry = new SaveData { username = name, finishTime = time };

            string jsonString = PlayerPrefs.GetString("highscoreTable");
            Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

            if (highscores == null)
            {
                highscores = new Highscores()
                {
                    saveDataList = new List<SaveData>()
                };
            }

            highscores.saveDataList.Add(highscoreEntry);

            string json = JsonUtility.ToJson(highscores);
            PlayerPrefs.SetString("highscoreTable", json);
            PlayerPrefs.Save();
        }
    }
}
