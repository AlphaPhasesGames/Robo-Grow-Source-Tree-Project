using UnityEngine;
using LoLSDK;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage2TaskListManager : MonoBehaviour
    {
        // script to setup the TTS button on the task list of day 2
        public Button speakTaskListStage2; // button for the TTS feature

        // Start is called before the first frame update
        void Start()
        {
            speakTaskListStage2.onClick.AddListener(SpeakTaskList2); // assign button click to SpeakTaskList2 function
        }

        public void SpeakTaskList2() // speak TTS feature
        {
            LOLSDK.Instance.SpeakText("tasksStage2"); // Speak TTS for tasksStage2
        }
    }
}
