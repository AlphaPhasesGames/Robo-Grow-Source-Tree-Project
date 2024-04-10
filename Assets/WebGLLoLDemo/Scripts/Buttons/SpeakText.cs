using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;

namespace Alpha.Phases.Robo.Grow
{
	public class SpeakText : MonoBehaviour
	{
		GardenData gardenData;

		

		public Button yourButton;
		public Button MMTTSButton;
		
		void Start()
		{
			Button btn = yourButton.GetComponent<Button>();
			btn.onClick.AddListener(OnClick);
			MMTTSButton.onClick.AddListener(MMTTS);
		}

		void OnClick()
		{
			LOLSDK.Instance.SpeakText("jobotIntroStage1");
		}

		void MMTTS()
        {
			LOLSDK.Instance.SpeakText("greetings");
		}
	}
}
