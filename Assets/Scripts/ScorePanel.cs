using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

namespace Cars
{
    public class ScorePanel : MonoBehaviour
    {

        [SerializeField]
        private Button restartGameButton;

        [SerializeField]
        private Button saveResultsButton;

        [SerializeField]
        private InputField _username;
        [SerializeField]
        private Text _finishTime;
        [SerializeField]
        private TextMeshProUGUI _scores;
        private float _rawFinishTime;

        void Start()
        {
            // Скрываем панель при начале игры
            gameObject.SetActive(false);
        }


        //Кнопка меню Сохранить
        public void OnSavePanel_EditorEvent()
        {
            var _saveScript = GetComponent<SaveLoad>();

            _saveScript.SaveData(_username.text, _rawFinishTime);
            

        }


        //Кнопка меню Рестарт
        public void OnRestartPanel_EditorEvent()
        {
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(scene.name);
        }


        //Форматируем время для отображения и выставляем время прохождения
        public void SetFinishTime(string finishTime, float rawTime)
        {
            _finishTime.text = finishTime;
            _rawFinishTime = rawTime;
        }


        //Отображение данных по времени прохождения трассы
        public void SetFinishScores()
        {
            var _saveScript = GetComponent<SaveLoad>();
            var _savedData = _saveScript.LoadData();
            string result = "";


            //Формируем список для показа на панели 
            List<SaveData> scores = new List<SaveData>();
            int len = _savedData.saveDataList.Count > 9 ? _savedData.saveDataList.Count - 9 : _savedData.saveDataList.Count;
            if (_savedData.saveDataList.Count <= 9) //Берем все сохраненные данные, если их меньше 9
            {
                for (int i = 0; i < len; i++)
                {
                    scores.Add(_savedData.saveDataList[i]);
                }
            }
            else
            {
                // Если данных больше 9, забираем последние 9
                for (int i = _savedData.saveDataList.Count - 1; i > len; i--)
                {
                    scores.Add(_savedData.saveDataList[i]);
                }
            }


            // Сортируем данные
            for (int i = 0; i < scores.Count; i++)
  
            {
                for (int j = i + 1; j < scores.Count; j++)
    
                {
   ;
                    if (scores[j].finishTime < scores[i].finishTime)
                    {
                        SaveData tmp = scores[i];
                        scores[i] = scores[j];
                        scores[j] = tmp;
                    }
                }
            }



            for (int i = 0; i < scores.Count; i++)
            {
                result += scores[i].username + " : " + scores[i].finishTime + "\n";
            }

            _scores.text = result; // Отображаем на панели в поле с результатом
        }
    }
}