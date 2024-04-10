using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LoLSDK;
using SimpleJSON;
using System.IO;
using UnityEngine.UI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowEndGameFade : MonoBehaviour
    {
        public RoboGrowStage5TextBoxManager rgTextman5;
        public Animator fadeAnim;
        public GameObject fadeImage;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void FadeScreen()
        {
            fadeImage.gameObject.SetActive(true);
            fadeAnim.SetTrigger("endOfGameFade");
        }
    }
}