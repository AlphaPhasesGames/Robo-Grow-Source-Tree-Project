using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SimpleJSON;
using LoLSDK;

public class MainMenuManager : MonoBehaviour {
	public Button commandButton;
	public Button languageButton;
	public Button soundButton;
	public Button speechButton;

	public Text langDataText;
	public Text subTitle;


	void Awake () {
		

		if (SharedState.LanguageDefs != null) {
			langDataText.text = "loaded.";
		}


		languageButton.onClick.AddListener(OnClickLanguage);
		commandButton.onClick.AddListener(OnClickCommands);
		soundButton.onClick.AddListener(OnClickSound);
		speechButton.onClick.AddListener(OnClickSpeech);

		subTitle.text = $"Game SDK Version {WebGL.SDK_VERSION}";
	}

	private void OnClickLanguage() {
		SceneManager.LoadScene("Language", LoadSceneMode.Single);
	}

	private void OnClickCommands () {
		SceneManager.LoadScene("Commands", LoadSceneMode.Single);
	}


	private void OnClickSound () {
		SceneManager.LoadScene("Sound", LoadSceneMode.Single);
	}

	private void OnClickSpeech () {
		SceneManager.LoadScene("Speech", LoadSceneMode.Single);
	}




	// Coming soon: Perfromance Debugging Tool
	// private void OnClickPerformance () {
	// 	SceneManager.LoadScene("Performance", LoadSceneMode.Single);
	// }
}
