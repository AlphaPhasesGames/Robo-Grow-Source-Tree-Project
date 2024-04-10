using UnityEngine;
using LoLSDK;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage1TaskListManager : MonoBehaviour
    {
        // script to setup the TTS button on the task list of day 1
        public Button speakTaskListStage1; // button for the TTS feature
        // Start is called before the first frame update
        void Start()
        {
            speakTaskListStage1.onClick.AddListener(SpeakTaskList1);  // assign button click to SpeakTaskList1 function
        }

        public void SpeakTaskList1()  // speak TTS feature
        {
            LOLSDK.Instance.SpeakText("tasksStage1"); // Speak TTS for tasksStage1
        }
    }
}