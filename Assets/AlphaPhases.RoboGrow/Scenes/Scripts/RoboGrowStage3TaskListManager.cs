using UnityEngine;
using LoLSDK;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage3TaskListManager : MonoBehaviour
    {
        // script to setup the TTS button on the task list of day 3

        public Button speakTaskListStage3; // button for the TTS feature
        // Start is called before the first frame update
        void Start()
        {
            speakTaskListStage3.onClick.AddListener(SpeakTaskList3); // assign button click to SpeakTaskList3 function
        }

        public void SpeakTaskList3() // speak TTS feature
        {
            LOLSDK.Instance.SpeakText("tasksStage3"); // Speak TTS for tasksStage3
        }
    }
}
