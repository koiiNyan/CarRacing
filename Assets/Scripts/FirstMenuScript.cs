using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Cars
{
    public class FirstMenuScript : MonoBehaviour
    {
        [SerializeField]
        private Button startGameButton;

        [SerializeField]
        private Button exitGameButton;

        public void OnStartPanel_EditorEvent()
        {
            SceneManager.LoadSceneAsync(1);
        }


        public void OnExitPanel_EditorEvent()
        {
        #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
        }
    }


}

