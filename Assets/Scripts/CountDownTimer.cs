using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Cars
{
    public class CountDownTimer : MonoBehaviour
    {
        [SerializeField]
        private Text _timer;

        private float _endTime;

        public float _timeLeft;

        [SerializeField]
        private CarComponent _carComp;

        private void Start()
        {
            _endTime = Time.timeSinceLevelLoad + 5;
        }
        void Update()
        {
            _timeLeft  = _endTime - Time.timeSinceLevelLoad;

            if (_timeLeft <= 0.9)
            {
                if (_timeLeft < 0) _timeLeft = 0;
                _carComp.SetGamePaused(false);
                gameObject.SetActive(false);
            }
            _timer.text = _timeLeft.ToString();



        }
    }
}