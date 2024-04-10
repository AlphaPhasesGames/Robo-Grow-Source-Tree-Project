using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using LoLSDK;

using System;

public static class SharedState
{

	// private static int score = 0;
	private static JSONNode startGameData;
	private static JSONNode languageDefs;

	// public static int Score
	// {
	// 	get
	// 	{
	// 		return score;
	// 	}
	// 	set
	// 	{
	// 		score = value;
	// 	}
	// }

	public static JSONNode StartGameData
	{
		get
		{
			return startGameData;
		}
		set
		{
			startGameData = value;
		}
	}

	public static JSONNode LanguageDefs
	{
		get
		{
			return languageDefs;
		}
		set
		{
			languageDefs = value;
		}
	}

}

