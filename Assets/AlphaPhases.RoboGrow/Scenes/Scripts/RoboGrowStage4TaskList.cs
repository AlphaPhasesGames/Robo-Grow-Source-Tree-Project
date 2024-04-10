using UnityEngine;
using LoLSDK;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage4TaskList : MonoBehaviour
    {
        public Button speakTaskListStage4; // button for the TTS feature
        // Start is called before the first frame update
        void Start()
        {
            speakTaskListStage4.onClick.AddListener(SpeakTaskList4); // assign button click to SpeakTaskList3 function
        }

        public void SpeakTaskList4() // speak TTS feature
        {
            LOLSDK.Instance.SpeakText("tasksStage4"); // Speak TTS for tasksStage3
        }
    }
}
