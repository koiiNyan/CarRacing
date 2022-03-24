using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cars
{
    public class TriggerComponent : MonoBehaviour
    {
        [SerializeField]
        private ScorePanel _scorePanel;
        [SerializeField]
        private CarComponent _carComp;
        [SerializeField]
        private PlayerInputController _playComp;
        [SerializeField]
        private GameObject _trigWall;

        private void Awake()
        {
            _trigWall.SetActive(false);
        }
        
        //По триггеру показываем панель с результатами и блокируем движение машины
        private void OnTriggerEnter(Collider other)
        {
            _scorePanel.SetFinishTime(FormatTime(), Time.timeSinceLevelLoad);
            _scorePanel.gameObject.SetActive(true);
            _carComp.SetGamePaused(true);
            _playComp.SetGamePaused();
            _scorePanel.SetFinishScores();
            _trigWall.SetActive(true);
        }

        private string FormatTime()
        {
            int intTime = (int)Time.timeSinceLevelLoad;
            int minutes = intTime / 60;
            int seconds = intTime % 60;
            float fraction = Time.timeSinceLevelLoad * 1000;
            fraction = (fraction % 1000);
            string timeText = String.Format("{0:00}:{1:00}:{2:0}", minutes, seconds, fraction);
            return timeText;
        }
    }
}