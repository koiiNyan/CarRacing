using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cars
{
    //Класс для сохранения/загрузки времени прохождения трассы
    [System.Serializable]
    public class SaveData
    {
       
        public string username;
        public float finishTime;

    }

    public class Highscores
    {
        public List<SaveData> saveDataList;
    }
}
