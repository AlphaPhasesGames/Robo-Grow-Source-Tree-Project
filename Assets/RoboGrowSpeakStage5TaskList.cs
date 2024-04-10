using UnityEngine;
using LoLSDK;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowSpeakStage5TaskList : MonoBehaviour
    {
        public Button speakTaskListStage5; // button for the TTS feature
        // Start is called before the first frame update
        void Start()
        {
            speakTaskListStage5.onClick.AddListener(SpeakTaskList5); // assign button click to SpeakTaskList3 function
        }

        public void SpeakTaskList5() // speak TTS feature
        {
            LOLSDK.Instance.SpeakText("tasksStage5"); // Speak TTS for tasksStage3
        }
    }
}
