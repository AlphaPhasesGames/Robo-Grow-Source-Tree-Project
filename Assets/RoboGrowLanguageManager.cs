using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SimpleJSON;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowLanguageManager : MonoBehaviour
    {

		 // This script assigns all JSON text to text variables in the editor and harness
		public RoboGrowMain rgMain;

		public RoboGrowTextBoxManager rgTextMan1;
		public RoboGrowTextBoxManagerStage2 rgTextMan2;
		public RoboGrowTextBoxManagerStage3 rgTextman3;
		public RoboGrowTextManagerStage4 rgTextMan4;
		public RoboGrowStage5TextBoxManager rgTextMan5;
		public RoboGrowStage1FlowersStartTrigger rgStage1ExamFlows;
		//public GardenData gardenData;

		public TextMeshProUGUI autoSavingMessage;

		public TextMeshProUGUI stage1LevelTitle;
		public TextMeshProUGUI stage2LevelTitle;
		public TextMeshProUGUI stage3LevelTitle;
		public TextMeshProUGUI stage4LevelTitle;
		public TextMeshProUGUI stage5LevelTitle;

		public TextMeshProUGUI mg1Stage1LevelAssText;
		public TextMeshProUGUI mg1Stage2LevelAssText;
		public TextMeshProUGUI mg1Stage3LevelAssText;
		public TextMeshProUGUI mg1Stage4LevelAssText;

		public TextMeshProUGUI asses1BESAnswer;
		public TextMeshProUGUI asses1BESWrong;
		public TextMeshProUGUI asses1BESWrong2;

		public TextMeshProUGUI asses1LimaAnswer;
		public TextMeshProUGUI asses1LimaWrong;
		public TextMeshProUGUI asses1LimaWrong2;

		public TextMeshProUGUI remindersTitle;
		public TextMeshProUGUI reminder1;
		public TextMeshProUGUI reminder2;
		public TextMeshProUGUI reminder3;
		public TextMeshProUGUI reminder4;
		public TextMeshProUGUI reminder5;
		public TextMeshProUGUI reminder6;
		public TextMeshProUGUI reminder7;
		public TextMeshProUGUI reminder8;
		public TextMeshProUGUI reminder9;
		public TextMeshProUGUI reminder10;
		public TextMeshProUGUI reminder11;
		public TextMeshProUGUI reminder12;
		public TextMeshProUGUI reminder13;

		public TextMeshProUGUI stage3CompleteText;

		public RoboGrowWaterPlantsStage2Asses stage2WaterplantsAsses; // susan 1
		public RoboGrowWaterplantsstageasses1 stage2WaterplantsAsses1; // susan 2
		public RoboGrowWaterPlantsStagesAsses2 stage2WaterplantsAsses2; // lima 1
		public RoboGrowWaterPlantsStagesAsses3 stage2WaterplantsAsses3; // lima2
		public RoboGrowWaterPlantsStagesAsses4 stage2WaterplantsAsses4; // daisy 2
		public RoboGrowWaterplantsstageasses5 stage2WaterplantsAsses5; // radish 1
		public RoboGrowWaterplantsstageasses6 stage2WaterplantsAsses6; // daisy  2
		public RoboGrowWaterplantsstageasses7 stage2WaterplantsAsses7; // daisy  2
		public TextMeshProUGUI stage2PlantsAnagram;

		public TextMeshProUGUI stage2PlantsCorrecGuess;
		public TextMeshProUGUI stage2PlantsGuess1;
		public TextMeshProUGUI stage2PlantsGuess2;
		public TextMeshProUGUI stage2PlantsGuess3;
		public TextMeshProUGUI stage2PlantsGuess4;
		public TextMeshProUGUI stage2PlantsGuess5;
		public TextMeshProUGUI stage2PlantsGuess6;
		public TextMeshProUGUI stage2PlantsGuess7;
		public TextMeshProUGUI stage2PlantsGuess8;
		public TextMeshProUGUI stage2PlantsGuess9;

		public TextMeshProUGUI asses1DaisyAnswer;
		public TextMeshProUGUI asses1DaisyWrong;
		public TextMeshProUGUI asses1DaisyWrong2;

		public TextMeshProUGUI asses1RadishAnswer;
		public TextMeshProUGUI asses1RadishWrong;
		public TextMeshProUGUI asses1RadishWrong2;

		public TextMeshProUGUI asses1BESCollSeeds1;
		public TextMeshProUGUI asses1BESCollSeeds2;
		public TextMeshProUGUI asses1BESCollSeeds3;

		public TextMeshProUGUI asses1LimaAnswerCollSeeds1;
		public TextMeshProUGUI asses1LimaWrongCollSeeds2;
		public TextMeshProUGUI asses1LimaWrongCollSeeds3;

		public TextMeshProUGUI asses1DaisyAnswerCollSeeds1;
		public TextMeshProUGUI asses1DaisyWrongCollSeeds2;
		public TextMeshProUGUI asses1DaisyWrongCollSeeds3;

		public TextMeshProUGUI asses1RadishAnswerCollSeeds1;
		public TextMeshProUGUI asses1RadishWrongCollSeeds2;
		public TextMeshProUGUI asses1RadishWrongCollSeeds3;



		public RoboGrowStage1MiniGameStart rgMG1Start;
		public RoboGrowStage1EndMG rgMG1End;
		public RoboGrowExaminePond rgPondExam;

		public TextMeshProUGUI eggObjectMG1Text;
		public TextMeshProUGUI larvaObjectMG1Text;
		public TextMeshProUGUI pupaObjectMG1Text;
		public TextMeshProUGUI adultObjectMG1Text;

		public TextMeshProUGUI fullTitleAndName;
		public TextMeshProUGUI taskPanal;
		//public TextMeshProUGUI seedBag;
		public TextMeshProUGUI collectSeedsButtonText;
		public TextMeshProUGUI removeDeadPlants;
		//public TextMeshProUGUI backButtonText;


		public TextMeshProUGUI newgameBUttonText;
		public TextMeshProUGUI continegameBUttonText;

		public TextMeshProUGUI day1TaskListPartA;
		public TextMeshProUGUI day1TaskListPartB;
		public TextMeshProUGUI day1TaskListPartC;
		public TextMeshProUGUI day1TaskListPartD;

		public TextMeshProUGUI day2TaskListPartA;
		public TextMeshProUGUI day2TaskListPartB;
		public TextMeshProUGUI day2TaskListPartC;
		public TextMeshProUGUI day2TaskListPartD;


		public TextMeshProUGUI day3TaskListPartA;
		public TextMeshProUGUI day3TaskListPartB;
		public TextMeshProUGUI day3TaskListPartC;
		public TextMeshProUGUI day3TaskListPartD;

		public TextMeshProUGUI day4TaskListPartA;
		public TextMeshProUGUI day4TaskListPartB;
		public TextMeshProUGUI day4TaskListPartC;
		public TextMeshProUGUI day4TaskListPartD;

		public TextMeshProUGUI day5TaskListPartA;
		public TextMeshProUGUI day5TaskListPartB;
		//public TextMeshProUGUI day5TaskListPartC;
		public TextMeshProUGUI day5TaskListPartD;

		public TextMeshProUGUI stage1IntroText1;
		public TextMeshProUGUI endOFStage1Text;

	//	public TextMeshProUGUI growthMeterStage1;

		public TextMeshProUGUI susanSeedName;
		public TextMeshProUGUI limaBeanSeedName;
		public TextMeshProUGUI daisySeedName;
		public TextMeshProUGUI radishSeedName;

		public TextMeshProUGUI eggText;
		public TextMeshProUGUI larvaText;
		public TextMeshProUGUI pupaText;
		public TextMeshProUGUI adultText;

		public TextMeshProUGUI eggTextMG;
		public TextMeshProUGUI larvaTextMG;
		public TextMeshProUGUI pupaTextMG;
		public TextMeshProUGUI adultTextMG;

		public RoboGrowStage2TreeTrigger rgTreeTriggerStage2;
		public RoboGrowStartMiniGame2 rgPondTriggerStage2;
		//public RoboGrowStage2MiniGameEnd rgPondEndStage2;


		public TextMeshProUGUI pondMG1CorrectAnswer;
		public TextMeshProUGUI pondMG1IncorrectAnswer1;
		public TextMeshProUGUI pondMG1IncorrectAnswer2;
		public TextMeshProUGUI pondMG1IncorrectAnswer3;
		public TextMeshProUGUI pondMG1IncorrectAnswer4;
		public TextMeshProUGUI pondMG1IncorrectAnswer6;
		public TextMeshProUGUI pondMG1IncorrectAnswer7;
		public TextMeshProUGUI pondMG1IncorrectAnswer8;
		public TextMeshProUGUI pondMG1IncorrectAnswer9;

		public TextMeshProUGUI stage2Water1;
		public TextMeshProUGUI stage2Water2;
		public TextMeshProUGUI stage2Water3;
		public TextMeshProUGUI stage2Water4;
		public TextMeshProUGUI stage2Water5;
		public TextMeshProUGUI stage2Water6;
		public TextMeshProUGUI stage2Water7;
		public TextMeshProUGUI stage2Water8;

		public TextMeshProUGUI stage3Water1;
		public TextMeshProUGUI stage3Water2;
		public TextMeshProUGUI stage3Water3;
		public TextMeshProUGUI stage3Water4;
		public TextMeshProUGUI stage3Water5;
		public TextMeshProUGUI stage3Water6;
		public TextMeshProUGUI stage3Water7;
		public TextMeshProUGUI stage3Water8;

		public TextMeshProUGUI stage4Water1;
		public TextMeshProUGUI stage4Water2;
		public TextMeshProUGUI stage4Water3;
		public TextMeshProUGUI stage4Water4;
		public TextMeshProUGUI stage4Water5;
		public TextMeshProUGUI stage4Water6;
		public TextMeshProUGUI stage4Water7;
		public TextMeshProUGUI stage4Water8;

		//	public TextMeshProUGUI stage2Back;
		public TextMeshProUGUI resetPlantsButton;

		public TextMeshProUGUI birthTextStage4Assesment;
		public TextMeshProUGUI deathTextStage4Assesment;
		public TextMeshProUGUI adulthoodTextStage4Assesment;
		public TextMeshProUGUI childhoodTextStage4Assesment;
		public TextMeshProUGUI startTextStage4Assesment;

		public TextMeshProUGUI birthTextStage4Assesment1;
		public TextMeshProUGUI deathTextStage4Assesment1;
		public TextMeshProUGUI adulthoodTextStage4Assesment1;
		public TextMeshProUGUI childhoodTextStage4Assesment1;
		public TextMeshProUGUI startTextStage4Assesment1;

		public TextMeshProUGUI birthTextStage4Assesment2;
		public TextMeshProUGUI deathTextStage4Assesment2;
		public TextMeshProUGUI adulthoodTextStage4Assesment2;
		public TextMeshProUGUI childhoodTextStage4Assesment2;
		public TextMeshProUGUI startTextStage4Assesment2;

		public TextMeshProUGUI birthTextStage4Assesment3;
		public TextMeshProUGUI deathTextStage4Assesment3;
		public TextMeshProUGUI adulthoodTextStage4Assesment3;
		public TextMeshProUGUI childhoodTextStage4Assesment3;
		public TextMeshProUGUI startTextStage4Assesment3;

		public TextMeshProUGUI birthTextStage4Assesment4;
		public TextMeshProUGUI deathTextStage4Assesment4;
		public TextMeshProUGUI adulthoodTextStage4Assesment4;
		public TextMeshProUGUI childhoodTextStage4Assesment4;
		public TextMeshProUGUI startTextStage4Assesment4;

		public TextMeshProUGUI birthTextStage4Assesment6;
		public TextMeshProUGUI deathTextStage4Assesment6;
		public TextMeshProUGUI adulthoodTextStage4Assesment6;
		public TextMeshProUGUI childhoodTextStage4Assesment6;
		public TextMeshProUGUI startTextStage4Assesment6;

		public TextMeshProUGUI birthTextStage4Assesment5;
		public TextMeshProUGUI deathTextStage4Assesment5;
		public TextMeshProUGUI adulthoodTextStage4Assesment5;
		public TextMeshProUGUI childhoodTextStage4Assesment5;
		public TextMeshProUGUI startTextStage4Assesment5;


		public TextMeshProUGUI birthTextStage4Assesment7;
		public TextMeshProUGUI deathTextStage4Assesment7;
		public TextMeshProUGUI adulthoodTextStage4Assesment7;
		public TextMeshProUGUI childhoodTextStage4Assesment7;
		public TextMeshProUGUI startTextStage4Assesment7;

		public RoboGrowPlant1Manager rgPlantManSusan;
		public RoboGrowPlant2Manager rgPlantManLima;
		public RoboGrowPlant3Manager rgPLantManDaisy;
		public RoboGrowPlant4Manager rgPlantManRadish;

		public RoboGrowStartMinigame3 rgTreeTriggerStage3;
		public Stage3PondTrigger rgpondTriggerStage3;
		


		public TextMeshProUGUI stage3MGSusanPollen;
		public TextMeshProUGUI stage3MGLimaPollen;
		public TextMeshProUGUI stage3MGDaisyPollen;
		public TextMeshProUGUI stage3MGRadishPollen;


		public TextMeshProUGUI stage4FrogMiniGameWrongAnswer1;
		public TextMeshProUGUI stage4FrogMiniGameWrongAnswer2;
		public TextMeshProUGUI stage4FrogMiniGameWrongAnswer3;
		public TextMeshProUGUI stage4FrogMiniGameCorrectAnswer;
		//susan 1 stage 3 assesment letters

		public TextMeshProUGUI letter1L;
		public TextMeshProUGUI letter2A;
		public TextMeshProUGUI letter3R;
		public TextMeshProUGUI letter4G;
		public TextMeshProUGUI letter5E;
		public TextMeshProUGUI letter6X;
		public TextMeshProUGUI letter7S;
		public TextMeshProUGUI letter8T;
		public TextMeshProUGUI letter9K;
		public TextMeshProUGUI letter10N;
		public TextMeshProUGUI letter11D;



		//susan 3 stage 3 assesment letters

		public TextMeshProUGUI letter1LSusan2;
		public TextMeshProUGUI letter2ASusan2;
		public TextMeshProUGUI letter3RSusan2;
		public TextMeshProUGUI letter4GSusan2;
		public TextMeshProUGUI letter5ESusan2;
		public TextMeshProUGUI letter6XSusan2;
		public TextMeshProUGUI letter7SSusan2;
		public TextMeshProUGUI letter8TSusan2;
		public TextMeshProUGUI letter9KSusan2;
		public TextMeshProUGUI letter10NSusan2;
		public TextMeshProUGUI letter11DSusan2;
		//	public TextMeshProUGUI growthMeterStage3;

		// Lima 1 letters assesment hangman
		public TextMeshProUGUI letter1LLima;
		public TextMeshProUGUI letter2ALima;
		public TextMeshProUGUI letter3RLima;
		public TextMeshProUGUI letter4GLima;
		public TextMeshProUGUI letter5ELima;
		public TextMeshProUGUI letter6XLima;
		public TextMeshProUGUI letter7SLima;
		public TextMeshProUGUI letter8TLima;
		public TextMeshProUGUI letter9KLima;
		public TextMeshProUGUI letter10NLima;
		public TextMeshProUGUI letter11DLima;

		// Lima 2 letters assesment hangman
		public TextMeshProUGUI letter1LLima2;
		public TextMeshProUGUI letter2ALima2;
		public TextMeshProUGUI letter3RLima2;
		public TextMeshProUGUI letter4GLima2;
		public TextMeshProUGUI letter5ELima2;
		public TextMeshProUGUI letter6XLima2;
		public TextMeshProUGUI letter7SLima2;
		public TextMeshProUGUI letter8TLima2;
		public TextMeshProUGUI letter9KLima2;
		public TextMeshProUGUI letter10NLima2;
		public TextMeshProUGUI letter11DLima2;

		// Daisy 1 letters assesment hangman
		public TextMeshProUGUI letter1LDaisy;
		public TextMeshProUGUI letter2ADaisy;
		public TextMeshProUGUI letter3RDaisy;
		public TextMeshProUGUI letter4GDaisy;
		public TextMeshProUGUI letter5EDaisy;
		public TextMeshProUGUI letter6XDaisy;
		public TextMeshProUGUI letter7SDaisy;
		public TextMeshProUGUI letter8TDaisy;
		public TextMeshProUGUI letter9KDaisy;
		public TextMeshProUGUI letter10NDaisy;
		public TextMeshProUGUI letter11DDaisy;

		// Daisy 2 letters assesment hangman
		public TextMeshProUGUI letter1LDaisy2;
		public TextMeshProUGUI letter2ADaisy2;
		public TextMeshProUGUI letter3RDaisy2;
		public TextMeshProUGUI letter4GDaisy2;
		public TextMeshProUGUI letter5EDaisy2;
		public TextMeshProUGUI letter6XDaisy2;
		public TextMeshProUGUI letter7SDaisy2;
		public TextMeshProUGUI letter8TDaisy2;
		public TextMeshProUGUI letter9KDaisy2;
		public TextMeshProUGUI letter10NDaisy2;
		public TextMeshProUGUI letter11DDaisy2;

		// radish 1  letters assesment hangman
		public TextMeshProUGUI letter1LRadish;
		public TextMeshProUGUI letter2ARadish;
		public TextMeshProUGUI letter3RRadish;
		public TextMeshProUGUI letter4GRadish;
		public TextMeshProUGUI letter5ERadish;
		public TextMeshProUGUI letter6XRadish;
		public TextMeshProUGUI letter7SRadish;
		public TextMeshProUGUI letter8TRadish;
		public TextMeshProUGUI letter9KRadish;
		public TextMeshProUGUI letter10NRadish;
		public TextMeshProUGUI letter11DRadish;

		// radish 2 letters assesment hangman
		public TextMeshProUGUI letter1LRadish2;
		public TextMeshProUGUI letter2ARadish2;
		public TextMeshProUGUI letter3RRadish2;
		public TextMeshProUGUI letter4GRadish2;
		public TextMeshProUGUI letter5ERadish2;
		public TextMeshProUGUI letter6XRadish2;
		public TextMeshProUGUI letter7SRadish2;
		public TextMeshProUGUI letter8TRadish2;
		public TextMeshProUGUI letter9KRadish2;
		public TextMeshProUGUI letter10NRadish2;
		public TextMeshProUGUI letter11DRadish2;

		public TextMeshProUGUI diagramStage3Stamen;
		public TextMeshProUGUI diagramStage3Stigma;

		public TextMeshProUGUI stage5AssesPlantComplete;
		public RoboGrowStage4ButterflyMG rgStage4MGTree;
		public TextMeshProUGUI correctRingStage5Text;

		public RoboGrowStage4FrogMiniGame rgStage4MG2Pond;
		public RoboGrowStage4FrogMiniGameEnd rgStage4MG2PondEnd;

		public RoboGrowStage5MiniGame2Tree rgStage5TreeMG;

		public TextMeshProUGUI stage5ButtCorrectAnswer;
		public TextMeshProUGUI stage5Buttincorrect1;
		public TextMeshProUGUI stage5ButtIncorrect2;
		//public RoboGrowStage5FrogMinigameStart rgStage5PondMG;

		void Awake()
		{
			JSONNode defs = SharedState.LanguageDefs;

			rgMain.newGameText.text = defs["newGame"];
			rgMain.continueText.text = defs["continue"];

			taskPanal.text = defs["taskList"];
			//seedBag.text = defs["seedBag"];
			autoSavingMessage.text = defs["autoSave"];

			//fullTitleAndName.text = defs["robotID" + rgMain.robot_first_name];

			stage1LevelTitle.text = defs["stage1IntroLogo"];
			stage2LevelTitle.text = defs["stage2IntroLogo"];
			stage3LevelTitle.text = defs["stage3IntroLogo"];
			stage4LevelTitle.text = defs["stage4IntroLogo"];
			stage5LevelTitle.text = defs["stage5IntroLogo"];

			newgameBUttonText.text = defs["newGame"];
			continegameBUttonText.text = defs["continue"];

			collectSeedsButtonText.text = defs["collectSeeds"];
			removeDeadPlants.text = defs["collectSeeds"];
			//backButtonText.text = defs["backButtonText"];

			//stage 2 water buttons text

			//stage2Back.text = defs["backButtonText"];
			stage2Water1.text = defs["waterSeeds"];
			stage2Water2.text = defs["waterSeeds"];
			stage2Water3.text = defs["waterSeeds"];
			stage2Water4.text = defs["waterSeeds"];
			stage2Water5.text = defs["waterSeeds"];
			stage2Water6.text = defs["waterSeeds"];
			stage2Water7.text = defs["waterSeeds"];
			stage2Water8.text = defs["waterSeeds"];

			stage3Water1.text = defs["waterSeeds"];
			stage3Water2.text = defs["waterSeeds"];
			stage3Water3.text = defs["waterSeeds"];
			stage3Water4.text = defs["waterSeeds"];
			stage3Water5.text = defs["waterSeeds"];
			stage3Water6.text = defs["waterSeeds"];
			stage3Water7.text = defs["waterSeeds"];
			stage3Water8.text = defs["waterSeeds"];

			stage4Water1.text = defs["waterSeeds"];
			stage4Water2.text = defs["waterSeeds"];
			stage4Water3.text = defs["waterSeeds"];
			stage4Water4.text = defs["waterSeeds"];
			stage4Water5.text = defs["waterSeeds"];
			stage4Water6.text = defs["waterSeeds"];
			stage4Water7.text = defs["waterSeeds"];
			stage4Water8.text = defs["waterSeeds"];

			susanSeedName.text = defs["blackEyedSusanSeedName"];
			limaBeanSeedName.text = defs["limaBeanSeedName"];
			daisySeedName.text = defs["daisySeedName"];
			radishSeedName.text = defs["radishSeedName"];
			//robotName.text = defs["robotID"];

			remindersTitle.text = defs["HintsPageTitle"];
			reminder1.text = defs["Hint1"];
			reminder2.text = defs["Hint2"];
			reminder3.text = defs["Hint3"];
			reminder4.text = defs["Hint4"];
			reminder5.text = defs["Hint5"];
			reminder6.text = defs["Hint6"];
			reminder7.text = defs["Hint7"];
			reminder8.text = defs["Hint8"];
			reminder9.text = defs["Hint9"];
			reminder10.text = defs["Hint10"];
			reminder11.text = defs["Hint11"];
			reminder12.text = defs["Hint12"];
			reminder13.text = defs["Hint13"];

			asses1BESAnswer.text = defs["assesmentSection1Answer"];
			asses1BESWrong.text = defs["assesmentSection1Incorrect1"];
			asses1BESWrong2.text = defs["assesmentSection1Incorrect2"];

			asses1LimaAnswer.text = defs["assesmentSection1Answer"];
			asses1LimaWrong.text = defs["assesmentSection1Incorrect1"];
			asses1LimaWrong2.text = defs["assesmentSection1Incorrect2"];

			asses1DaisyAnswer.text = defs["assesmentSection1Answer"];
			asses1DaisyWrong.text = defs["assesmentSection1Incorrect1"];
			asses1DaisyWrong2.text = defs["assesmentSection1Incorrect2"];

			asses1RadishAnswer.text = defs["assesmentSection1Answer"];
			asses1RadishWrong.text = defs["assesmentSection1Incorrect1"];
			asses1RadishWrong2.text = defs["assesmentSection1Incorrect2"];

			asses1BESCollSeeds1.text = defs["collectSeeds"];
			asses1BESCollSeeds2.text = defs["collectSeeds"];
			asses1BESCollSeeds3.text = defs["collectSeeds"];

			eggObjectMG1Text.text = defs["stage1MiniGameItemText1"];
			larvaObjectMG1Text.text = defs["stage1MiniGameItemText2"];
			pupaObjectMG1Text.text = defs["stage1MiniGameItemText3"];
			adultObjectMG1Text.text = defs["stage1MiniGameItemText4"];

			asses1LimaAnswerCollSeeds1.text = defs["collectSeeds"];
			asses1LimaWrongCollSeeds2.text = defs["collectSeeds"];
			asses1LimaWrongCollSeeds3.text = defs["collectSeeds"];

			asses1DaisyAnswerCollSeeds1.text = defs["collectSeeds"];
			asses1DaisyWrongCollSeeds2.text = defs["collectSeeds"];
			asses1DaisyWrongCollSeeds3.text = defs["collectSeeds"];

			asses1RadishAnswerCollSeeds1.text = defs["collectSeeds"];
			asses1RadishWrongCollSeeds2.text = defs["collectSeeds"];
			asses1RadishWrongCollSeeds3.text = defs["collectSeeds"];

			stage3CompleteText.text = defs["jobotStage3CompletePanal"];

			//stage 1 tesk list

			day1TaskListPartA.text = defs["tasksStage1parta"];
			day1TaskListPartB.text = defs["tasksStage1partb"];
			day1TaskListPartC.text = defs["tasksStage1partc"];
			day1TaskListPartD.text = defs["tasksStage1partd"];

			day2TaskListPartA.text = defs["tasksStage2parta"];
			day2TaskListPartB.text = defs["tasksStage2partb"];
			day2TaskListPartC.text = defs["tasksStage2partc"];
			day2TaskListPartD.text = defs["tasksStage2partd"];

			day3TaskListPartA.text = defs["tasksStage3parta"];
			day3TaskListPartB.text = defs["tasksStage3partb"];
			day3TaskListPartC.text = defs["tasksStage3partc"];
			day3TaskListPartD.text = defs["tasksStage3partd"];

			day4TaskListPartA.text = defs["tasksStage4parta"];
			day4TaskListPartB.text = defs["tasksStage4partb"];
			day4TaskListPartC.text = defs["tasksStage4partc"];
			day4TaskListPartD.text = defs["tasksStage4partd"];

			day5TaskListPartA.text = defs["tasksStage5parta"];
			day5TaskListPartB.text = defs["tasksStage5partb"];
			//day5TaskListPartC.text = defs["tasksStage5partc"];
			day5TaskListPartD.text = defs["tasksStage5partd"];




			// Stage 1 intro text

			rgTextMan1.jobotIntroStage1Section1.text = defs["jobotIntroStage1"];
			rgTextMan1.jobotIntroStage1Section1a.text = defs["jobotIntroStage1a"];
			rgTextMan1.jobotIntroStage1Section1b.text = defs["jobotIntroStage1b"];
			rgTextMan1.jobotIntroStage1Section1c.text = defs["jobotIntroStage1c"];
			rgTextMan1.jobotIntroStage1Section1d.text = defs["jobotIntroStage1d"];
			rgTextMan1.jobotIntroStage1Section1e.text = defs["jobotIntroStage1e"];
			rgTextMan1.jobotIntroStage1Section1f.text = defs["jobotIntroStage1f"];
			rgTextMan1.jobotIntroStage1Section1g.text = defs["jobotIntroStage1g"];
			rgTextMan1.jobotIntroStage1Section1h.text = defs["jobotIntroStage1h"];
			rgTextMan1.jobotIntroStage1Section1i.text = defs["jobotIntroStage1i"];
			rgTextMan1.jobotIntroStage1Section1j.text = defs["jobotIntroStage1jChooseName"];

			// name choice 
			rgMain.nameChoice1Text.text = defs["jobotNameChoice1"] ;
			rgMain.nameChoice2Text.text = defs["jobotNameChoice2"];
			rgMain.nameChoice3Text.text = defs["jobotNameChoice3"];
			rgMain.nameChoice4Text.text = defs["jobotNameChoice4"];
			rgMain.nameChoice5Text.text = defs["jobotNameChoice5"];
			rgMain.nameChoice6Text.text = defs["jobotNameChoice6"];
			rgMain.nameChoice7Text.text = defs["jobotNameChoice7"];
			rgMain.nameChoice8Text.text = defs["jobotNameChoice8"];
			rgMain.nameChoice9Text.text = defs["jobotNameChoice9"];
			rgMain.nameChoice10Text.text = defs["jobotNameChoice10"];
			rgMain.nameChoice11Text.text = defs["jobotNameChoice11"];
			rgMain.nameChoice12Text.text = defs["jobotNameChoice12"];
			rgMain.nameChoice13Text.text = defs["jobotNameChoice13"];
			rgMain.nameChoice14Text.text = defs["jobotNameChoice14"];
			rgMain.nameChoice15Text.text = defs["jobotNameChoice15"];
			rgMain.nameChoice16Text.text = defs["jobotNameChoice16"];
			rgTextMan1.jobotIntroStage1Section1k.text = defs["jobotIntroStage1k"];
			rgTextMan1.jobotIntroStage1Section1l.text = defs["jobotIntroStage1l"];
			rgTextMan1.jobotIntroStage1Section1m.text = defs["jobotIntroStage1m"];
			rgTextMan1.jobotIntroStage1Section1n.text = defs["jobotIntroStage1n"];
			rgTextMan1.jobotIntroStage1Section1o.text = defs["jobotIntroStage1o"];
			rgTextMan1.jobotIntroStage1Section1p.text = defs["jobotIntroStage1p"];
			rgTextMan1.jobotIntroStage1Section1q.text = defs["jobotIntroStage1q"];
			rgTextMan1.jobotIntroStage1Section1r.text = defs["jobotIntroStage1r"];

			rgTextMan1.jobotIntroStage1Section1Rock.text = defs["stage1NonOrganicItemRock"];
		//	rgTextMan1.jobotIntroStage1Section1GreenHouse.text = defs["stage1NonOrganicItemGreenHouse"];
		//	rgTextMan1.jobotIntroStage1Section1Pond.text = defs["stage1NonOrganicItemPond"];
			rgTextMan1.jobotIntroStage1Section1Tree.text = defs["stage1OrganicItemTree"];

			eggText.text = defs["stage1MiniGameItemText1"];
			larvaText.text = defs["stage1MiniGameItemText2"];
			pupaText.text = defs["stage1MiniGameItemText3"];
			adultText.text = defs["stage1MiniGameItemText4"];

			eggTextMG.text = defs["stage1MiniGameItemText1"];
			larvaTextMG.text = defs["stage1MiniGameItemText2"];
			pupaTextMG.text = defs["stage1MiniGameItemText3"];
			adultTextMG.text = defs["stage1MiniGameItemText4"];

			rgStage1ExamFlows.jobotIntroStage1Flower.text = defs["stage1PlantIntroInfo"];
			rgStage1ExamFlows.jobotIntroStage1Flower1a.text = defs["stage1PlantIntroInfoa"];
			rgStage1ExamFlows.jobotIntroStage1Flower1b.text = defs["stage1PlantIntroInfob"];

			rgPlantManSusan.jobotIntroStage1FlowerBlackEyedSusan1.text = defs["stage1Plant1SusanText1"];
			rgPlantManSusan.jobotIntroStage1FlowerBlackEyedSusan2.text = defs["stage1Plant1SusanText1a"];
			rgPlantManSusan.jobotIntroStage1FlowerBlackEyedSusan3.text = defs["stage1Plant1SusanText1b"];
			rgPlantManSusan.jobotFlowerAssesmentAnswerCorrect.text = defs["assesmentSection1AnswerCorrect"];
			rgPlantManSusan.jobotFlowerAssesmentAnswerIncorrect.text = defs["assesmentSection1AnswerIncorrect"];

			rgPlantManLima.jobotIntroStage1FlowerLimaBean1.text = defs["stage1Plant3LimaBText1"];
			rgPlantManLima.jobotIntroStage1FlowerLimaBean2.text = defs["stage1Plant3LimaBText1a"];
			rgPlantManLima.jobotIntroStage1FlowerLimaBean3.text = defs["stage1Plant1SusanText1b"];
			rgPlantManLima.jobotFlowerAssesmentAnswerCorrect.text = defs["assesmentSection1AnswerCorrect"];
			rgPlantManLima.jobotFlowerAssesmentAnswerIncorrect.text = defs["assesmentSection1AnswerIncorrect"];

			rgPLantManDaisy.jobotIntroStage1Flower3DaisyPlant1.text = defs["stage1Plant2DaisyText1"];
			rgPLantManDaisy.jobotIntroStage1Flower3DaisyPlant2.text = defs["stage1Plant2DaisyText1a"];
			rgPLantManDaisy.jobotIntroStage1Flower3DaisyPlant3.text = defs["stage1Plant1SusanText1b"];
			rgPLantManDaisy.jobotFlowerAssesmentAnswerCorrect.text = defs["assesmentSection1AnswerCorrect"];
			rgPLantManDaisy.jobotFlowerAssesmentAnswerIncorrect.text = defs["assesmentSection1AnswerIncorrect"];

			rgPlantManRadish.jobotIntroStage1Flower3RadishPlant1.text = defs["stage1Plant4RadishText1"];
			rgPlantManRadish.jobotIntroStage1Flower3RadishPlant2.text = defs["stage1Plant4RadishTextb"];
			rgPlantManRadish.jobotIntroStage1Flower3RadishPlant3.text = defs["stage1Plant1SusanText1b"];
			rgPlantManRadish.jobotFlowerAssesmentAnswerCorrect.text = defs["assesmentSection1AnswerCorrect"];
			rgPlantManRadish.jobotFlowerAssesmentAnswerIncorrect.text = defs["assesmentSection1AnswerIncorrect"];

			rgMG1Start.jobotIntroStage1Tree.text = defs["stage1MiniGameInfo"];
			rgMG1Start.jobotIntroStage1Tree1a.text = defs["stage1MiniGameInfoa"];
			rgMG1Start.jobotIntroStage1Tree1b.text = defs["stage1MiniGameInfob"];
			rgMG1Start.jobotIntroStage1Tree1c.text = defs["stage1MiniGameInfoc"];
			rgMG1Start.jobotIntroStage1Tree1d.text = defs["stage1MiniGameInfod"];
			rgMG1Start.jobotIntroStage1Tree1e.text = defs["stage1MiniGameInfoe"];
			rgMG1Start.jobotIntroStage1Tree1f.text = defs["stage1MiniGameInfof"];
		//	rgMG1Start.jobotIntroStage1Tree1g.text = defs["stage1MiniGameInfog"];
		//	rgMG1Start.jobotIntroStage1Tree1ga.text = defs["stage1MiniGameInfoh"];
		//	rgMG1Start.jobotIntroStage1Tree1h.text = defs["stage1MiniGameInfoi"];
		//  rgMG1Start.jobotIntroStage1Tree1i.text = defs["stage1MiniGameInfoPlayerEaten"];
			rgMG1Start.jobotIntroStage1Tree1j.text = defs["stage1MiniGameInfoPlayerEatena"];
			rgMG1Start.jobotIntroStage1Tree1Proceed.text = defs["stage1MiniGameInfoProceedToEnd"];
			rgMG1Start.IncorrectGuessPanal.text = defs["stage1MiniGameInfoIncorrectGuess"];

			rgMG1End.MGEndText.text = defs["stage1MiniGameCompleteInfo"];
			rgMG1End.MGEndText1.text = defs["stage1MiniGameCompleteInfoa"];
			rgMG1End.MGEndText2.text = defs["stage1MiniGameCompleteInfob"];
			rgMG1End.MGNotBigEnough.text = defs["stage1MiniGameInfoNotBigEnough"];
			rgMG1End.MGAssesment.text = defs["stage1MiniGameAssesmentSection"];
			

			mg1Stage1LevelAssText.text = defs["stage1IntroLogo"];
			mg1Stage2LevelAssText.text = defs["stage2IntroLogo"];
			mg1Stage3LevelAssText.text = defs["stage3IntroLogo"];
			mg1Stage4LevelAssText.text = defs["stage4IntroLogo"];

			//growthMeterStage1.text = defs["growthMeterUIForMG1And3"];

			rgPondExam.jobotIntroStage1Pond.text = defs["stage1PondFrogSpawnInfo"];
			rgPondExam.jobotIntroStage1Pond1a.text = defs["stage1PondFrogSpawnInfoa"];
			rgPondExam.jobotIntroStage1Pond1b.text = defs["stage1PondFrogSpawnInfob"];
			rgPondExam.jobotIntroStage1Pond1e.text = defs["stage1PondFrogSpawnInfoe"];

			endOFStage1Text.text = defs["stage1Complete"];

			// -------- Stage 2 text -----------

			rgTextMan2.jobotIntroStage1Section1.text = defs["jobotIntroStage2"];
			rgTextMan2.jobotIntroStage1Section1a.text = defs["jobotIntroStage2a"];
		//	rgTextMan2.jobotIntroStage1Section1b.text = defs["jobotIntroStage2b"];
			rgTextMan2.jobotIntroStage1Section1c.text = defs["jobotIntroStage2c"];
			rgTextMan2.jobotIntroStage1Section1d.text = defs["jobotIntroStage2d"];
		//	rgTextMan2.jobotIntroStage1Section1e.text = defs["jobotIntroStage2e"];
			rgTextMan2.jobotIntroStage1Section1f.text = defs["jobotIntroStage2f"];
			rgTextMan2.jobotIntroStage1Section1g.text = defs["jobotIntroStage2g"];
			rgTextMan2.jobotIntroStage1Section1h.text = defs["jobotIntroStage2h"];
			rgTextMan2.jobotIntroStage1Section1i.text = defs["jobotIntroStage2i"];
			rgTextMan2.jobotStage2PlantSeed.text = defs["jobotStage2PlantSeed"];
			rgTextMan2.jobotStage2PlantSeeda.text = defs["jobotStage2PlantSeeda"];
			rgTextMan2.jobotStage2PlantSeedb.text = defs["jobotStage2PlantSeedb"];
		//	rgTextMan2.jobotStage2PlantSeedc.text = defs["jobotStage2PlantSeedc"];
		//	rgTextMan2.jobotStage2PlantSeedd.text = defs["jobotStage2PlantSeedd"];
			rgTextMan2.jobotStage2PlantSeede.text = defs["jobotStage2PlantSeede"];
			rgTextMan2.jobotSeedsPlanted.text = defs["jobotStage2PlantSeedComplete"];
			rgTextMan2.jobotSeedsWatered.text = defs["jobotStage2PlantSeedExamineWaterplantComplete"];
			rgTextMan2.stage2Complete.text = defs["jobotStage2Completeb"];
			//growthMeterStage3.text = defs["growthMeterUIForMG1And3"];

			resetPlantsButton.text = defs["resetPlantsButton"];

			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1.text = defs["jobotStage2PlantWaterAssesmentText"];
			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1a.text = defs["jobotStage2PlantWaterAssesmentText1"];
			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1b.text = defs["jobotStage2PlantWaterAssesmentText2"];
			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1c.text = defs["jobotStage2PlantWaterAssesmentText3"];
			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1d.text = defs["jobotStage2PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1IncorrectGuess.text = defs["jobotStage2PlantSeedExamineWaterplantWrong"];

			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1.text = defs["jobotStage2PlantWaterAssesmentText"];
			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1a.text = defs["jobotStage2PlantWaterAssesmentText1"];
			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1b.text = defs["jobotStage2PlantWaterAssesmentText2"];
			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1c.text = defs["jobotStage2PlantWaterAssesmentText3"];
			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1d.text = defs["jobotStage2PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1IncorrectGuess.text = defs["jobotStage2PlantSeedExamineWaterplantWrong"];


			stage2WaterplantsAsses2.jobotIntroStage2PlantAsses1.text = defs["jobotStage2PlantWaterAssesmentText"];
			stage2WaterplantsAsses2.jobotIntroStage2PlantAsses1a.text = defs["jobotStage2PlantWaterAssesmentText1"];
			stage2WaterplantsAsses2.jobotIntroStage2PlantAsses1b.text = defs["jobotStage2PlantWaterAssesmentText2"];
			stage2WaterplantsAsses2.jobotIntroStage2PlantAsses1c.text = defs["jobotStage2PlantWaterAssesmentText3"];
			stage2WaterplantsAsses2.jobotIntroStage2PlantAsses1d.text = defs["jobotStage2PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses2.jobotIntroStage2PlantAsses1IncorrectGuess.text = defs["jobotStage2PlantSeedExamineWaterplantWrong"];

			stage2WaterplantsAsses3.jobotIntroStage2PlantAsses1.text = defs["jobotStage2PlantWaterAssesmentText"];
			stage2WaterplantsAsses3.jobotIntroStage2PlantAsses1a.text = defs["jobotStage2PlantWaterAssesmentText1"];
			stage2WaterplantsAsses3.jobotIntroStage2PlantAsses1b.text = defs["jobotStage2PlantWaterAssesmentText2"];
			stage2WaterplantsAsses3.jobotIntroStage2PlantAsses1c.text = defs["jobotStage2PlantWaterAssesmentText3"];
			stage2WaterplantsAsses3.jobotIntroStage2PlantAsses1d.text = defs["jobotStage2PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses3.jobotIntroStage2PlantAsses1IncorrectGuess.text = defs["jobotStage2PlantSeedExamineWaterplantWrong"];

			stage2WaterplantsAsses4.jobotIntroStage2PlantAsses1.text = defs["jobotStage2PlantWaterAssesmentText"];
			stage2WaterplantsAsses4.jobotIntroStage2PlantAsses1a.text = defs["jobotStage2PlantWaterAssesmentText1"];
			stage2WaterplantsAsses4.jobotIntroStage2PlantAsses1b.text = defs["jobotStage2PlantWaterAssesmentText2"];
			stage2WaterplantsAsses4.jobotIntroStage2PlantAsses1c.text = defs["jobotStage2PlantWaterAssesmentText3"];
			stage2WaterplantsAsses4.jobotIntroStage2PlantAsses1d.text = defs["jobotStage2PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses4.jobotIntroStage2PlantAsses1IncorrectGuess.text = defs["jobotStage2PlantSeedExamineWaterplantWrong"];

			stage2WaterplantsAsses5.jobotIntroStage2PlantAsses1.text = defs["jobotStage2PlantWaterAssesmentText"];
			stage2WaterplantsAsses5.jobotIntroStage2PlantAsses1a.text = defs["jobotStage2PlantWaterAssesmentText1"];
			stage2WaterplantsAsses5.jobotIntroStage2PlantAsses1b.text = defs["jobotStage2PlantWaterAssesmentText2"];
			stage2WaterplantsAsses5.jobotIntroStage2PlantAsses1c.text = defs["jobotStage2PlantWaterAssesmentText3"];
			stage2WaterplantsAsses5.jobotIntroStage2PlantAsses1d.text = defs["jobotStage2PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses5.jobotIntroStage2PlantAsses1IncorrectGuess.text = defs["jobotStage2PlantSeedExamineWaterplantWrong"];

			stage2WaterplantsAsses6.jobotIntroStage2PlantAsses1.text = defs["jobotStage2PlantWaterAssesmentText"];
			stage2WaterplantsAsses6.jobotIntroStage2PlantAsses1a.text = defs["jobotStage2PlantWaterAssesmentText1"];
			stage2WaterplantsAsses6.jobotIntroStage2PlantAsses1b.text = defs["jobotStage2PlantWaterAssesmentText2"];
			stage2WaterplantsAsses6.jobotIntroStage2PlantAsses1c.text = defs["jobotStage2PlantWaterAssesmentText3"];
			stage2WaterplantsAsses6.jobotIntroStage2PlantAsses1d.text = defs["jobotStage2PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses6.jobotIntroStage2PlantAsses1IncorrectGuess.text = defs["jobotStage2PlantSeedExamineWaterplantWrong"];

			stage2WaterplantsAsses7.jobotIntroStage2PlantAsses1.text = defs["jobotStage2PlantWaterAssesmentText"];
			stage2WaterplantsAsses7.jobotIntroStage2PlantAsses1a.text = defs["jobotStage2PlantWaterAssesmentText1"];
			stage2WaterplantsAsses7.jobotIntroStage2PlantAsses1b.text = defs["jobotStage2PlantWaterAssesmentText2"];
			stage2WaterplantsAsses7.jobotIntroStage2PlantAsses1c.text = defs["jobotStage2PlantWaterAssesmentText3"];
			stage2WaterplantsAsses7.jobotIntroStage2PlantAsses1d.text = defs["jobotStage2PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses7.jobotIntroStage2PlantAsses1IncorrectGuess.text = defs["jobotStage2PlantSeedExamineWaterplantWrong"];

			stage2PlantsAnagram.text = defs["jobotStage2PlantWaterAssesmentAnagram"];
			stage2PlantsCorrecGuess.text = defs["jobotStage2PlantWaterAssesmentAnagramGuessAnswer"];
			
			stage2PlantsGuess1.text = defs["jobotStage2PlantWaterAssesmentAnagramGuess1"];
			stage2PlantsGuess2.text = defs["jobotStage2PlantWaterAssesmentAnagramGuess2"];
			stage2PlantsGuess3.text = defs["jobotStage2PlantWaterAssesmentAnagramGuess3"];
			stage2PlantsGuess4.text = defs["jobotStage2PlantWaterAssesmentAnagramGuess4"];
			stage2PlantsGuess5.text = defs["jobotStage2PlantWaterAssesmentAnagramGuess5"];
			stage2PlantsGuess6.text = defs["jobotStage2PlantWaterAssesmentAnagramGuess6"];
			stage2PlantsGuess7.text = defs["jobotStage2PlantWaterAssesmentAnagramGuess7"];
			stage2PlantsGuess8.text = defs["jobotStage2PlantWaterAssesmentAnagramGuess8"];
			stage2PlantsGuess9.text = defs["jobotStage2PlantWaterAssesmentAnagramGuess9"];

			rgTreeTriggerStage2.jobotIntroStage2Tree.text = defs["jobotStage2PlantSeedExamineCocoon"];
			rgTreeTriggerStage2.jobotIntroStage2Tree1a.text = defs["jobotStage2PlantSeedExamineCocoona"];
		//	rgTreeTriggerStage2.jobotIntroStage2Tree1b.text = defs["jobotStage2PlantSeedExamineCocoonb"];
		//	rgTreeTriggerStage2.jobotIntroStage2Tree1c.text = defs["jobotStage2PlantSeedExamineCocoonc"];
			rgTreeTriggerStage2.jobotIntroStage2Tree1d.text = defs["jobotStage2PlantSeedExamineCocoond"];
			rgTreeTriggerStage2.jobotIntroStage2Tree1e.text = defs["jobotStage2PlantSeedExamineCocoone"];
			rgTreeTriggerStage2.jobotIntroStage2Tree1f.text = defs["jobotStage2PlantSeedExamineCocoonf"];

			rgPondTriggerStage2.jobotIntroStage2Pond.text = defs["jobotStage2Pond"];
			rgPondTriggerStage2.jobotIntroStage2Pond1a.text = defs["jobotStage2Ponda"];
			rgPondTriggerStage2.jobotIntroStage2Pond1b.text = defs["jobotStage2Pondb"];
			rgPondTriggerStage2.jobotIntroStage2Pond1c.text = defs["jobotStage2Pondc"];
			rgPondTriggerStage2.jobotIntroStage2Pond1d.text = defs["jobotStage2Pondd"];
			rgPondTriggerStage2.jobotIntroStage2Pond1e.text = defs["jobotStage2PondeClue"];
			rgPondTriggerStage2.jobotIntroStage2Pond1f.text = defs["jobotStage2Pondf"];
			rgPondTriggerStage2.jobotIntroStage2Pond1Eaten.text = defs["jobotStage2PondgEaten"];
			rgPondTriggerStage2.jobotNotLargeEnough.text = defs["jobotStage2PondgNotBigEnough"];


			pondMG1CorrectAnswer.text = defs["jobotStage2PondCorrect1"];
			pondMG1IncorrectAnswer1.text = defs["jobotStage2PondIncorrect1"];
			pondMG1IncorrectAnswer2.text = defs["jobotStage2PondIncorrect2"];
			pondMG1IncorrectAnswer3.text = defs["jobotStage2PondIncorrect3"];
			pondMG1IncorrectAnswer4.text = defs["jobotStage2PondIncorrect4"];
			pondMG1IncorrectAnswer6.text = defs["jobotStage2PondIncorrect6"];
			pondMG1IncorrectAnswer7.text = defs["jobotStage2PondIncorrect7"];
			pondMG1IncorrectAnswer8.text = defs["jobotStage2PondIncorrect8"];
			pondMG1IncorrectAnswer9.text = defs["jobotStage2PondIncorrect9"];



			// -- Stage 3 Text -- 

			rgTextman3.jobotIntroStage1Section1.text = defs["jobotIntroStage3"];
		//	rgTextman3.jobotIntroStage1Section1a.text = defs["jobotIntroStage3a"];
			rgTextman3.jobotIntroStage1Section1b.text = defs["jobotIntroStage3b"];
			rgTextman3.jobotIntroStage1Section1c.text = defs["jobotIntroStage3c"];
			rgTextman3.jobotIntroStage1Section1d.text = defs["jobotIntroStage3d"];
			rgTextman3.jobotIntroStage1Section1e.text = defs["jobotIntroStage3e"];
			rgTextman3.jobotIntroStage1Section1f.text = defs["jobotIntroStage3f"];
			rgTextman3.jobotIntroStage1Section1g.text = defs["jobotIntroStage3g"];
			rgTextman3.jobotIntroStage1Section1h.text = defs["jobotIntroStage3h"];
			rgTextman3.jobotIntroStage1Section1i.text = defs["jobotIntroStage3i"];
		//	rgTextman3.jobotIntroStage1Section1j.text = defs["jobotIntroStage3j"];
			rgTextman3.jobotIntroStage1Section1k.text = defs["jobotIntroStage3k"];
		//	rgTextman3.jobotIntroStage1Section1l.text = defs["jobotIntroStage3l"];
			rgTextman3.jobotIntroStage1Section1m.text = defs["jobotIntroStage3m"];
			rgTextman3.jobotFlowersWatered.text = defs["jobotIntroStage3PWatered"];

			//rgTextman3.stageComplete.text = defs["jobotStage3CompletePanal"];

			rgTreeTriggerStage3.jobotJobotStage3TreeText.text = defs["jobotStage3Butterfly1"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTexta.text = defs["jobotStage3Butterfly1a"];
		//	rgTreeTriggerStage3.jobotJobotStage3TreeTextb.text = defs["jobotStage3Butterfly1b"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTextc.text = defs["jobotStage3Butterfly1c"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTextd.text = defs["jobotStage3Butterfly1d"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTextdControls.text = defs["jobotStage3Butterfly1dControls"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTextdGamePlayExplaination.text = defs["jobotStage3Butterfly1dGameplay"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTexte.text = defs["jobotStage3Butterfly1e"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTextf.text = defs["jobotStage3Butterfly1f"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTextg.text = defs["jobotStage3Butterfly1fa"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTexth.text = defs["jobotStage3Butterfly1g"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTexti.text = defs["jobotStage3Butterfly1h"];
		//	rgTreeTriggerStage3.jobotJobotStage3TreeTextj.text = defs["jobotStage3Butterfly1ha"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTextk.text = defs["jobotStage3Butterfly1i"];
		//	rgTreeTriggerStage3.jobotJobotStage3TreeTextl.text = defs["jobotStage3Butterfly1j"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTextm.text = defs["jobotStage3Butterfly1k"];
		//	rgTreeTriggerStage3.jobotJobotStage3TreeTextn.text = defs["jobotStage3Butterfly1WellDone"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTexto.text = defs["jobotStage3Butterfly1WellDoneSusanPollen"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTextp.text = defs["jobotStage3Butterfly1WellDoneLimaBeanPollen"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTextq.text = defs["jobotStage3Butterfly1WellDoneDaisyPollen"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTextr.text = defs["jobotStage3Butterfly1WellDoneRadishPollen"];
			rgTreeTriggerStage3.jobotJobotStage3TreeTexts.text = defs["jobotStage3ButterflyPlantsPollinated"];


			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1Stage3.text = defs["jobotStage3PlantWaterAssesmentText"];
			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1aStage3.text = defs["jobotStage3PlantWaterAssesmentText1"];
			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1bStage3.text = defs["jobotStage3PlantWaterAssesmentText2"];
			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1cStage3.text = defs["jobotStage3PlantWaterAssesmentTextClue"];
			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1dStage3.text = defs["jobotStage3PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1IncorrectGuessStage3.text = defs["jobotStage3PlantWaterAssesmentLeavesGone"];

			stage2WaterplantsAsses.correctLetterToShow1L.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			stage2WaterplantsAsses.correctLetterToShow2A.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			stage2WaterplantsAsses.correctLetterToShow3R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			stage2WaterplantsAsses.correctLetterToShow4G.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			stage2WaterplantsAsses.correctLetterToShow5E.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			stage2WaterplantsAsses.correctLetterToShow6R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];

			//stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1Stage3.text = defs["jobotStage3PlantWaterAssesmentText"];
			// susan 2 assement text
			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1Stage3.text = defs["jobotStage3PlantWaterAssesmentText"];
			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1aStage3.text = defs["jobotStage3PlantWaterAssesmentText1"];
			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1bStage3.text = defs["jobotStage3PlantWaterAssesmentText2"];
			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1cStage3.text = defs["jobotStage3PlantWaterAssesmentTextClue"];
			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1dStage3.text = defs["jobotStage3PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1IncorrectGuessStage3.text = defs["jobotStage3PlantWaterAssesmentLeavesGone"];

			stage2WaterplantsAsses1.correctLetterToShow1L.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			stage2WaterplantsAsses1.correctLetterToShow2A.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			stage2WaterplantsAsses1.correctLetterToShow3R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			stage2WaterplantsAsses1.correctLetterToShow4G.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			stage2WaterplantsAsses1.correctLetterToShow5E.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			stage2WaterplantsAsses1.correctLetterToShow6R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];

			// lima 1 assement text

			stage2WaterplantsAsses2.jobotIntroStage3PlantAsses2Stage3.text = defs["jobotStage3PlantWaterAssesmentText"];
			stage2WaterplantsAsses2.jobotIntroStage3PlantAsses2aStage3.text = defs["jobotStage3PlantWaterAssesmentText1"];
			stage2WaterplantsAsses2.jobotIntroStage3PlantAsses2bStage3.text = defs["jobotStage3PlantWaterAssesmentText2"];
			stage2WaterplantsAsses2.jobotIntroStage3PlantAsses2cStage3.text = defs["jobotStage3PlantWaterAssesmentTextClue"];
			stage2WaterplantsAsses2.jobotIntroStage3PlantAsses2dStage3.text = defs["jobotStage3PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses2.jobotIntroStage3PlantAsses2IncorrectGuessStage3.text = defs["jobotStage3PlantWaterAssesmentLeavesGone"];

			stage2WaterplantsAsses2.correctLetterToShow1L.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			stage2WaterplantsAsses2.correctLetterToShow2A.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			stage2WaterplantsAsses2.correctLetterToShow3R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			stage2WaterplantsAsses2.correctLetterToShow4G.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			stage2WaterplantsAsses2.correctLetterToShow5E.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			stage2WaterplantsAsses2.correctLetterToShow6R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];

			//Lima 2 assesment text
			stage2WaterplantsAsses3.jobotIntroStage3PlantAsses3Stage3.text = defs["jobotStage3PlantWaterAssesmentText"];
			stage2WaterplantsAsses3.jobotIntroStage3PlantAsses3aStage3.text = defs["jobotStage3PlantWaterAssesmentText1"];
			stage2WaterplantsAsses3.jobotIntroStage3PlantAsses3bStage3.text = defs["jobotStage3PlantWaterAssesmentText2"];
			stage2WaterplantsAsses3.jobotIntroStage3PlantAsses3cStage3.text = defs["jobotStage3PlantWaterAssesmentTextClue"];
			stage2WaterplantsAsses3.jobotIntroStage3PlantAsses3dStage3.text = defs["jobotStage3PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses3.jobotIntroStage3PlantAsses3IncorrectGuessStage3.text = defs["jobotStage3PlantWaterAssesmentLeavesGone"];

			stage2WaterplantsAsses3.correctLetterToShow1L.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			stage2WaterplantsAsses3.correctLetterToShow2A.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			stage2WaterplantsAsses3.correctLetterToShow3R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			stage2WaterplantsAsses3.correctLetterToShow4G.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			stage2WaterplantsAsses3.correctLetterToShow5E.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			stage2WaterplantsAsses3.correctLetterToShow6R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];


			//Daisy assesment text
			stage2WaterplantsAsses4.jobotIntroStage3PlantAsses4Stage3.text = defs["jobotStage3PlantWaterAssesmentText"];
			stage2WaterplantsAsses4.jobotIntroStage3PlantAsses4aStage3.text = defs["jobotStage3PlantWaterAssesmentText1"];
			stage2WaterplantsAsses4.jobotIntroStage3PlantAsses4bStage3.text = defs["jobotStage3PlantWaterAssesmentText2"];
			stage2WaterplantsAsses4.jobotIntroStage3PlantAsses4cStage3.text = defs["jobotStage3PlantWaterAssesmentTextClue"];
			stage2WaterplantsAsses4.jobotIntroStage3PlantAsses4dStage3.text = defs["jobotStage3PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses4.jobotIntroStage3PlantAsses4IncorrectGuessStage3.text = defs["jobotStage3PlantWaterAssesmentLeavesGone"];

			stage2WaterplantsAsses4.correctLetterToShow1L.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			stage2WaterplantsAsses4.correctLetterToShow2A.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			stage2WaterplantsAsses4.correctLetterToShow3R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			stage2WaterplantsAsses4.correctLetterToShow4G.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			stage2WaterplantsAsses4.correctLetterToShow5E.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			stage2WaterplantsAsses4.correctLetterToShow6R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];


			//Daisy 2 assesment text
			stage2WaterplantsAsses6.jobotIntroStage3PlantAsses6Stage3.text = defs["jobotStage3PlantWaterAssesmentText"];
			stage2WaterplantsAsses6.jobotIntroStage3PlantAsses6aStage3.text = defs["jobotStage3PlantWaterAssesmentText1"];
			stage2WaterplantsAsses6.jobotIntroStage3PlantAsses6bStage3.text = defs["jobotStage3PlantWaterAssesmentText2"];
			stage2WaterplantsAsses6.jobotIntroStage3PlantAsses6cStage3.text = defs["jobotStage3PlantWaterAssesmentTextClue"];
			stage2WaterplantsAsses6.jobotIntroStage3PlantAsses6dStage3.text = defs["jobotStage3PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses6.jobotIntroStage3PlantAsses6IncorrectGuessStage3.text = defs["jobotStage3PlantWaterAssesmentLeavesGone"];

			stage2WaterplantsAsses6.correctLetterToShow1L.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			stage2WaterplantsAsses6.correctLetterToShow2A.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			stage2WaterplantsAsses6.correctLetterToShow3R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			stage2WaterplantsAsses6.correctLetterToShow4G.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			stage2WaterplantsAsses6.correctLetterToShow5E.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			stage2WaterplantsAsses6.correctLetterToShow6R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];

			//Radish assesment text
			stage2WaterplantsAsses5.jobotIntroStage3PlantAsses5Stage3.text = defs["jobotStage3PlantWaterAssesmentText"];
			stage2WaterplantsAsses5.jobotIntroStage3PlantAsses5aStage3.text = defs["jobotStage3PlantWaterAssesmentText1"];
			stage2WaterplantsAsses5.jobotIntroStage3PlantAsses5bStage3.text = defs["jobotStage3PlantWaterAssesmentText2"];
			stage2WaterplantsAsses5.jobotIntroStage3PlantAsses5cStage3.text = defs["jobotStage3PlantWaterAssesmentTextClue"];
			stage2WaterplantsAsses5.jobotIntroStage3PlantAsses5dStage3.text = defs["jobotStage3PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses5.jobotIntroStage3PlantAsses5IncorrectGuessStage3.text = defs["jobotStage3PlantWaterAssesmentLeavesGone"];

			stage2WaterplantsAsses5.correctLetterToShow1L.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			stage2WaterplantsAsses5.correctLetterToShow2A.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			stage2WaterplantsAsses5.correctLetterToShow3R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			stage2WaterplantsAsses5.correctLetterToShow4G.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			stage2WaterplantsAsses5.correctLetterToShow5E.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			stage2WaterplantsAsses5.correctLetterToShow6R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];

			//Radish assesment text
			stage2WaterplantsAsses7.jobotIntroStage3PlantAsses7Stage3.text = defs["jobotStage3PlantWaterAssesmentText"];
			stage2WaterplantsAsses7.jobotIntroStage3PlantAsses7aStage3.text = defs["jobotStage3PlantWaterAssesmentText1"];
			stage2WaterplantsAsses7.jobotIntroStage3PlantAsses7bStage3.text = defs["jobotStage3PlantWaterAssesmentText2"];
			stage2WaterplantsAsses7.jobotIntroStage3PlantAsses7cStage3.text = defs["jobotStage3PlantWaterAssesmentTextClue"];
			stage2WaterplantsAsses7.jobotIntroStage3PlantAsses7dStage3.text = defs["jobotStage3PlantWaterAssesmentCorrectText"];
			stage2WaterplantsAsses7.jobotIntroStage3PlantAsses7IncorrectGuessStage3.text = defs["jobotStage3PlantWaterAssesmentLeavesGone"];

			stage2WaterplantsAsses7.correctLetterToShow1L.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			stage2WaterplantsAsses7.correctLetterToShow2A.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			stage2WaterplantsAsses7.correctLetterToShow3R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			stage2WaterplantsAsses7.correctLetterToShow4G.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			stage2WaterplantsAsses7.correctLetterToShow5E.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			stage2WaterplantsAsses7.correctLetterToShow6R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];


			// stage 3 susan 1 letters

			letter1L.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			letter2A.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			letter3R.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			letter4G.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			letter5E.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			letter6X.text = defs["jobotStage3PlantWaterAssesmentHangLetter6"];
			letter7S.text = defs["jobotStage3PlantWaterAssesmentHangLetter7"];
			letter8T.text = defs["jobotStage3PlantWaterAssesmentHangLetter8"];
			letter9K.text = defs["jobotStage3PlantWaterAssesmentHangLetter9"];
			letter10N.text = defs["jobotStage3PlantWaterAssesmentHangLetter10"];
			letter11D.text = defs["jobotStage3PlantWaterAssesmentHangLetter11"];

			// stage 3 susan 2 letters

			letter1LSusan2.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			letter2ASusan2.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			letter3RSusan2.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			letter4GSusan2.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			letter5ESusan2.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			letter6XSusan2.text = defs["jobotStage3PlantWaterAssesmentHangLetter6"];
			letter7SSusan2.text = defs["jobotStage3PlantWaterAssesmentHangLetter7"];
			letter8TSusan2.text = defs["jobotStage3PlantWaterAssesmentHangLetter8"];
			letter9KSusan2.text = defs["jobotStage3PlantWaterAssesmentHangLetter9"];
			letter10NSusan2.text = defs["jobotStage3PlantWaterAssesmentHangLetter10"];
			letter11DSusan2.text = defs["jobotStage3PlantWaterAssesmentHangLetter11"];

			//stage 3 lima letters


			letter1LLima.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			letter2ALima.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			letter3RLima.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			letter4GLima.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			letter5ELima.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			letter6XLima.text = defs["jobotStage3PlantWaterAssesmentHangLetter6"];
			letter7SLima.text = defs["jobotStage3PlantWaterAssesmentHangLetter7"];
			letter8TLima.text = defs["jobotStage3PlantWaterAssesmentHangLetter8"];
			letter9KLima.text = defs["jobotStage3PlantWaterAssesmentHangLetter9"];
			letter10NLima.text = defs["jobotStage3PlantWaterAssesmentHangLetter10"];
			letter11DLima.text = defs["jobotStage3PlantWaterAssesmentHangLetter11"];

			//stage 3 lima 2 letters


			letter1LLima2.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			letter2ALima2.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			letter3RLima2.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			letter4GLima2.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			letter5ELima2.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			letter6XLima2.text = defs["jobotStage3PlantWaterAssesmentHangLetter6"];
			letter7SLima2.text = defs["jobotStage3PlantWaterAssesmentHangLetter7"];
			letter8TLima2.text = defs["jobotStage3PlantWaterAssesmentHangLetter8"];
			letter9KLima2.text = defs["jobotStage3PlantWaterAssesmentHangLetter9"];
			letter10NLima2.text = defs["jobotStage3PlantWaterAssesmentHangLetter10"];
			letter11DLima2.text = defs["jobotStage3PlantWaterAssesmentHangLetter11"];

			//stage 3 daisy letters


			letter1LDaisy.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			letter2ADaisy.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			letter3RDaisy.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			letter4GDaisy.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			letter5EDaisy.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			letter6XDaisy.text = defs["jobotStage3PlantWaterAssesmentHangLetter6"];
			letter7SDaisy.text = defs["jobotStage3PlantWaterAssesmentHangLetter7"];
			letter8TDaisy.text = defs["jobotStage3PlantWaterAssesmentHangLetter8"];
			letter9KDaisy.text = defs["jobotStage3PlantWaterAssesmentHangLetter9"];
			letter10NDaisy.text = defs["jobotStage3PlantWaterAssesmentHangLetter10"];
			letter11DDaisy.text = defs["jobotStage3PlantWaterAssesmentHangLetter11"];

			//stage 3 daisy 2 letters


			letter1LDaisy2.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			letter2ADaisy2.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			letter3RDaisy2.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			letter4GDaisy2.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			letter5EDaisy2.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			letter6XDaisy2.text = defs["jobotStage3PlantWaterAssesmentHangLetter6"];
			letter7SDaisy2.text = defs["jobotStage3PlantWaterAssesmentHangLetter7"];
			letter8TDaisy2.text = defs["jobotStage3PlantWaterAssesmentHangLetter8"];
			letter9KDaisy2.text = defs["jobotStage3PlantWaterAssesmentHangLetter9"];
			letter10NDaisy2.text = defs["jobotStage3PlantWaterAssesmentHangLetter10"];
			letter11DDaisy2.text = defs["jobotStage3PlantWaterAssesmentHangLetter11"];

			//stage 3 radish 1 letters


			letter1LRadish.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			letter2ARadish.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			letter3RRadish.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			letter4GRadish.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			letter5ERadish.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			letter6XRadish.text = defs["jobotStage3PlantWaterAssesmentHangLetter6"];
			letter7SRadish.text = defs["jobotStage3PlantWaterAssesmentHangLetter7"];
			letter8TRadish.text = defs["jobotStage3PlantWaterAssesmentHangLetter8"];
			letter9KRadish.text = defs["jobotStage3PlantWaterAssesmentHangLetter9"];
			letter10NRadish.text = defs["jobotStage3PlantWaterAssesmentHangLetter10"];
			letter11DRadish.text = defs["jobotStage3PlantWaterAssesmentHangLetter11"];

			//stage 3 radish 2 letters


			letter1LRadish2.text = defs["jobotStage3PlantWaterAssesmentHangLetter1"];
			letter2ARadish2.text = defs["jobotStage3PlantWaterAssesmentHangLetter2"];
			letter3RRadish2.text = defs["jobotStage3PlantWaterAssesmentHangLetter3"];
			letter4GRadish2.text = defs["jobotStage3PlantWaterAssesmentHangLetter4"];
			letter5ERadish2.text = defs["jobotStage3PlantWaterAssesmentHangLetter5"];
			letter6XRadish2.text = defs["jobotStage3PlantWaterAssesmentHangLetter6"];
			letter7SRadish2.text = defs["jobotStage3PlantWaterAssesmentHangLetter7"];
			letter8TRadish2.text = defs["jobotStage3PlantWaterAssesmentHangLetter8"];
			letter9KRadish2.text = defs["jobotStage3PlantWaterAssesmentHangLetter9"];
			letter10NRadish2.text = defs["jobotStage3PlantWaterAssesmentHangLetter10"];
			letter11DRadish2.text = defs["jobotStage3PlantWaterAssesmentHangLetter11"];

			stage3MGSusanPollen.text = defs["blackEyedSusanSeedName"];
			stage3MGLimaPollen.text = defs["limaBeanSeedName"];
			stage3MGDaisyPollen.text = defs["daisySeedName"];
			stage3MGRadishPollen.text = defs["radishSeedName"];

			diagramStage3Stamen.text = defs["stage3DiagramStamen"];
			diagramStage3Stigma.text = defs["stage3DiagramStigma"];
			rgpondTriggerStage3.jobotIntroStage3Pond.text = defs["jobotStage3Pond1"];
			rgpondTriggerStage3.jobotIntroStage3Pond1a.text = defs["jobotStage3Pond1a"];
			rgpondTriggerStage3.jobotIntroStage3Pond1b.text = defs["jobotStage3Pond1b"];
			rgpondTriggerStage3.jobotIntroStage3Pond1c.text = defs["jobotStage3Pond1c"];
			rgpondTriggerStage3.jobotIntroStage3Pond1d.text = defs["jobotStage3Pond1d"];


			// ---------- Stage 4 text ------------

			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1Stage4.text = defs["jobotStage4WaterPlantsAsessement"];
			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1aStage4.text = defs["jobotStage4WaterPlantsAsessement1"];
			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1bStage4.text = defs["jobotStage4WaterPlantsAsessement2"];
			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1cCorrectStage4.text = defs["jobotStage4WaterPlantsAsessement3Correct"];
			stage2WaterplantsAsses.jobotIntroStage2PlantAsses1IncorrectGuessStage4.text = defs["jobotStage4WaterPlantsAsessement3Incorrect"];

			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1Stage4.text = defs["jobotStage4WaterPlantsAsessement"];
			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1aStage4.text = defs["jobotStage4WaterPlantsAsessement1"];
			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1bStage4.text = defs["jobotStage4WaterPlantsAsessement2"];
			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1cCorrectStage4.text = defs["jobotStage4WaterPlantsAsessement3Correct"];
			stage2WaterplantsAsses1.jobotIntroStage2PlantAsses1IncorrectGuessStage4.text = defs["jobotStage4WaterPlantsAsessement3Incorrect"];

			stage2WaterplantsAsses2.jobotIntroStage2PlantAsses2Stage4.text = defs["jobotStage4WaterPlantsAsessement"];
			stage2WaterplantsAsses2.jobotIntroStage2PlantAsses2aStage4.text = defs["jobotStage4WaterPlantsAsessement1"];
			stage2WaterplantsAsses2.jobotIntroStage2PlantAsses2bStage4.text = defs["jobotStage4WaterPlantsAsessement2"];
			stage2WaterplantsAsses2.jobotIntroStage2PlantAsses2cCorrectStage4.text = defs["jobotStage4WaterPlantsAsessement3Correct"];
			stage2WaterplantsAsses2.jobotIntroStage2PlantAsses2IncorrectGuessStage4.text = defs["jobotStage4WaterPlantsAsessement3Incorrect"];


			stage2WaterplantsAsses3.jobotIntroStage2PlantAsses3Stage4.text = defs["jobotStage4WaterPlantsAsessement"];
			stage2WaterplantsAsses3.jobotIntroStage2PlantAsses3aStage4.text = defs["jobotStage4WaterPlantsAsessement1"];
			stage2WaterplantsAsses3.jobotIntroStage2PlantAsses3bStage4.text = defs["jobotStage4WaterPlantsAsessement2"];
			stage2WaterplantsAsses3.jobotIntroStage2PlantAsses3cCorrectStage4.text = defs["jobotStage4WaterPlantsAsessement3Correct"];
			stage2WaterplantsAsses3.jobotIntroStage2PlantAsses3IncorrectGuessStage4.text = defs["jobotStage4WaterPlantsAsessement3Incorrect"];


			stage2WaterplantsAsses4.jobotIntroStage2PlantAsses4Stage4.text = defs["jobotStage4WaterPlantsAsessement"];
			stage2WaterplantsAsses4.jobotIntroStage2PlantAsses4aStage4.text = defs["jobotStage4WaterPlantsAsessement1"];
			stage2WaterplantsAsses4.jobotIntroStage2PlantAsses4bStage4.text = defs["jobotStage4WaterPlantsAsessement2"];
			stage2WaterplantsAsses4.jobotIntroStage2PlantAsses4cCorrectStage4.text = defs["jobotStage4WaterPlantsAsessement3Correct"];
			stage2WaterplantsAsses4.jobotIntroStage2PlantAsses4IncorrectGuessStage4.text = defs["jobotStage4WaterPlantsAsessement3Incorrect"];

			stage2WaterplantsAsses6.jobotIntroStage2PlantAsses6Stage4.text = defs["jobotStage4WaterPlantsAsessement"];
			stage2WaterplantsAsses6.jobotIntroStage2PlantAsses6aStage4.text = defs["jobotStage4WaterPlantsAsessement1"];
			stage2WaterplantsAsses6.jobotIntroStage2PlantAsses6bStage4.text = defs["jobotStage4WaterPlantsAsessement2"];
			stage2WaterplantsAsses6.jobotIntroStage2PlantAsses6cCorrectStage4.text = defs["jobotStage4WaterPlantsAsessement3Correct"];
			stage2WaterplantsAsses6.jobotIntroStage2PlantAsses6IncorrectGuessStage4.text = defs["jobotStage4WaterPlantsAsessement3Incorrect"];

			stage2WaterplantsAsses5.jobotIntroStage2PlantAsses5Stage4.text = defs["jobotStage4WaterPlantsAsessement"];
			stage2WaterplantsAsses5.jobotIntroStage2PlantAsses5aStage4.text = defs["jobotStage4WaterPlantsAsessement1"];
			stage2WaterplantsAsses5.jobotIntroStage2PlantAsses5bStage4.text = defs["jobotStage4WaterPlantsAsessement2"];
			stage2WaterplantsAsses5.jobotIntroStage2PlantAsses5cCorrectStage4.text = defs["jobotStage4WaterPlantsAsessement3Correct"];
			stage2WaterplantsAsses5.jobotIntroStage2PlantAsses5IncorrectGuessStage4.text = defs["jobotStage4WaterPlantsAsessement3Incorrect"];

			stage2WaterplantsAsses7.jobotIntroStage2PlantAsses7Stage4.text = defs["jobotStage4WaterPlantsAsessement"];
			stage2WaterplantsAsses7.jobotIntroStage2PlantAsses7aStage4.text = defs["jobotStage4WaterPlantsAsessement1"];
			stage2WaterplantsAsses7.jobotIntroStage2PlantAsses7bStage4.text = defs["jobotStage4WaterPlantsAsessement2"];
			stage2WaterplantsAsses7.jobotIntroStage2PlantAsses7cCorrectStage4.text = defs["jobotStage4WaterPlantsAsessement3Correct"];
			stage2WaterplantsAsses7.jobotIntroStage2PlantAsses7IncorrectGuessStage4.text = defs["jobotStage4WaterPlantsAsessement3Incorrect"];


			birthTextStage4Assesment.text = defs["jobotStage4WaterPlantsAsessementButtonText1Birth"];
			deathTextStage4Assesment.text = defs["jobotStage4WaterPlantsAsessementButtonText2Death"];
			adulthoodTextStage4Assesment.text = defs["jobotStage4WaterPlantsAsessementButtonText3AdultHood"];
			childhoodTextStage4Assesment.text = defs["jobotStage4WaterPlantsAsessementButtonText4Childhood"];
			startTextStage4Assesment.text = defs["jobotStage4WaterPlantsAsessementButtonText5Start"];

			birthTextStage4Assesment1.text = defs["jobotStage4WaterPlantsAsessementButtonText1Birth"];
			deathTextStage4Assesment1.text = defs["jobotStage4WaterPlantsAsessementButtonText2Death"];
			adulthoodTextStage4Assesment1.text = defs["jobotStage4WaterPlantsAsessementButtonText3AdultHood"];
			childhoodTextStage4Assesment1.text = defs["jobotStage4WaterPlantsAsessementButtonText4Childhood"];
			startTextStage4Assesment1.text = defs["jobotStage4WaterPlantsAsessementButtonText5Start"];

			birthTextStage4Assesment2.text = defs["jobotStage4WaterPlantsAsessementButtonText1Birth"];
			deathTextStage4Assesment2.text = defs["jobotStage4WaterPlantsAsessementButtonText2Death"];
			adulthoodTextStage4Assesment2.text = defs["jobotStage4WaterPlantsAsessementButtonText3AdultHood"];
			childhoodTextStage4Assesment2.text = defs["jobotStage4WaterPlantsAsessementButtonText4Childhood"];
			startTextStage4Assesment2.text = defs["jobotStage4WaterPlantsAsessementButtonText5Start"];

			birthTextStage4Assesment3.text = defs["jobotStage4WaterPlantsAsessementButtonText1Birth"];
			deathTextStage4Assesment3.text = defs["jobotStage4WaterPlantsAsessementButtonText2Death"];
			adulthoodTextStage4Assesment3.text = defs["jobotStage4WaterPlantsAsessementButtonText3AdultHood"];
			childhoodTextStage4Assesment3.text = defs["jobotStage4WaterPlantsAsessementButtonText4Childhood"];
			startTextStage4Assesment3.text = defs["jobotStage4WaterPlantsAsessementButtonText5Start"];

			birthTextStage4Assesment4.text = defs["jobotStage4WaterPlantsAsessementButtonText1Birth"];
			deathTextStage4Assesment4.text = defs["jobotStage4WaterPlantsAsessementButtonText2Death"];
			adulthoodTextStage4Assesment4.text = defs["jobotStage4WaterPlantsAsessementButtonText3AdultHood"];
			childhoodTextStage4Assesment4.text = defs["jobotStage4WaterPlantsAsessementButtonText4Childhood"];
			startTextStage4Assesment4.text = defs["jobotStage4WaterPlantsAsessementButtonText5Start"];

			birthTextStage4Assesment6.text = defs["jobotStage4WaterPlantsAsessementButtonText1Birth"];
			deathTextStage4Assesment6.text = defs["jobotStage4WaterPlantsAsessementButtonText2Death"];
			adulthoodTextStage4Assesment6.text = defs["jobotStage4WaterPlantsAsessementButtonText3AdultHood"];
			childhoodTextStage4Assesment6.text = defs["jobotStage4WaterPlantsAsessementButtonText4Childhood"];
			startTextStage4Assesment6.text = defs["jobotStage4WaterPlantsAsessementButtonText5Start"];

			birthTextStage4Assesment5.text = defs["jobotStage4WaterPlantsAsessementButtonText1Birth"];
			deathTextStage4Assesment5.text = defs["jobotStage4WaterPlantsAsessementButtonText2Death"];
			adulthoodTextStage4Assesment5.text = defs["jobotStage4WaterPlantsAsessementButtonText3AdultHood"];
			childhoodTextStage4Assesment5.text = defs["jobotStage4WaterPlantsAsessementButtonText4Childhood"];
			startTextStage4Assesment6.text = defs["jobotStage4WaterPlantsAsessementButtonText5Start"];


			birthTextStage4Assesment7.text = defs["jobotStage4WaterPlantsAsessementButtonText1Birth"];
			deathTextStage4Assesment7.text = defs["jobotStage4WaterPlantsAsessementButtonText2Death"];
			adulthoodTextStage4Assesment7.text = defs["jobotStage4WaterPlantsAsessementButtonText3AdultHood"];
			childhoodTextStage4Assesment7.text = defs["jobotStage4WaterPlantsAsessementButtonText4Childhood"];
			startTextStage4Assesment7.text = defs["jobotStage4WaterPlantsAsessementButtonText5Start"];

			rgTextMan4.jobotIntroStage1Section1.text = defs["jobotStage4IntroText1"];
			rgTextMan4.jobotIntroStage1Section1a.text = defs["jobotStage4IntroText1a"];
			rgTextMan4.jobotIntroStage1Section1b.text = defs["jobotStage4IntroText1b"];
			rgTextMan4.jobotIntroStage1Section1c.text = defs["jobotStage4IntroText1c"];
			rgTextMan4.jobotIntroStage1Section1d.text = defs["jobotStage4IntroText1d"];
		//	rgTextMan4.jobotIntroStage1Section1e.text = defs["jobotStage4IntroText1e"];
			rgTextMan4.jobotIntroStage1Section1f.text = defs["jobotStage4IntroText1f"];
		//	rgTextMan4.jobotIntroStage1Section1g.text = defs["jobotStage4IntroText1g"];
		//	rgTextMan4.jobotIntroStage1Section1h.text = defs["jobotStage4IntroText1h"];
			rgTextMan4.jobotIntroStage1Section1i.text = defs["jobotStage4IntroText1i"];

			rgTextMan4.jobotIntroStagejobotStage4PlantWatered1.text = defs["jobotStage4PlantWatered"];
			rgTextMan4.jobotIntroStagejobotStage4PlantWatered2.text = defs["jobotStage4PlantWatereda"];

			rgTextMan4.jobotStageComplete.text = defs["jobotStage4TasksComplete"];

			rgStage4MGTree.jobotIntroStage4Tree.text = defs["jobotStage4BFlyMiniGame"];
			rgStage4MGTree.jobotIntroStage4Tree1a.text = defs["jobotStage4BFlyMiniGamea"];
			rgStage4MGTree.jobotIntroStage4Tree1b.text = defs["jobotStage4BFlyMiniGameb"];
		//	rgStage4MGTree.jobotIntroStage4Tree1c.text = defs["jobotStage4BFlyMiniGamec"];
		//	rgStage4MGTree.jobotIntroStage4Tree1d.text = defs["jobotStage4BFlyMiniGamed"];
			rgStage4MGTree.jobotIntroStage4Tree1e.text = defs["jobotStage4BFlyMiniGamee"];
			rgStage4MGTree.jobotIntroStage4Tree1f.text = defs["jobotStage4BFlyMiniGamef"];
		//	rgStage4MGTree.jobotIntroStage4Tree1g.text = defs["jobotStage4BFlyMiniGameg"];
			rgStage4MGTree.jobotIntroStage4Tree1h.text = defs["jobotStage4BFlyMiniGameh"];
			rgStage4MGTree.jobotIntroStage4Tree1i.text = defs["jobotStage4BFlyMiniGamei"];
			rgStage4MGTree.jobotIntroStage4Tree1j.text = defs["jobotStage4BFlyMiniGamej"];


			rgStage4MG2Pond.jobotJobotStage4FrogText.text = defs["jobotStage4FrogMiniGame"];
			rgStage4MG2Pond.jobotJobotStage4FrogTexta.text = defs["jobotStage4FrogMiniGamea"];
			rgStage4MG2Pond.jobotJobotStage4FrogTextaControls.text = defs["jobotStage4FrogMiniGameaControls"];
			rgStage4MG2Pond.jobotJobotStage4FrogTextb.text = defs["jobotStage4FrogMiniGameb"];
			rgStage4MG2Pond.jobotJobotStage4FrogTextc.text = defs["jobotStage4FrogMiniGamec"];
			rgStage4MG2Pond.jobotJobotStage4FrogTextd.text = defs["jobotStage4FrogMiniGamed"];
			rgStage4MG2Pond.jobotJobotStage4FrogTextdCloser.text = defs["jobotStage4FrogMiniGamedCloser"];
			rgStage4MG2Pond.jobotJobotStage4FrogTexte.text = defs["jobotStage4FrogMiniGamee"];
			rgStage4MG2Pond.jobotJobotStage4FrogTextf.text = defs["jobotStage4FrogMiniGamef"];
			rgStage4MG2Pond.jobotJobotStage4Eaten.text = defs["jobotStage4FrogMiniGameEaten"];

			stage4FrogMiniGameWrongAnswer1.text = defs["jobotStage4FrogMiniGameIncorrectAnswer1"];
			stage4FrogMiniGameWrongAnswer2.text = defs["jobotStage4FrogMiniGameIncorrectAnswer2"];
			stage4FrogMiniGameWrongAnswer3.text = defs["jobotStage4FrogMiniGameIncorrectAnswer3"];
			stage4FrogMiniGameCorrectAnswer.text = defs["jobotStage4FrogMiniGameCorrectAnswer"];
			// ----------- Stage 5 text from Json listeners -------------
			rgTextMan5.jobotIntroStage5Section1.text = defs["jobotStage5Intro1"];
		//	rgTextMan5.jobotIntroStage5Section1a.text = defs["jobotStage5Intro1a"];
			rgTextMan5.jobotIntroStage5Section1b.text = defs["jobotStage5Intro1b"];
		//	rgTextMan5.jobotIntroStage5Section1c.text = defs["jobotStage5Intro1c"];
		//	rgTextMan5.jobotIntroStage5Section1d.text = defs["jobotStage5Intro1d"];
			rgTextMan5.jobotIntroStage5Section1e.text = defs["jobotStage5Intro1e"];
		//	rgTextMan5.jobotIntroStage5Section1f.text = defs["jobotStage5Intro1f"];
			rgTextMan5.jobotIntroStage5Section1g.text = defs["jobotStage5Intro1g"];
			rgTextMan5.jobotIntroStage5Section1h.text = defs["jobotStage5Intro1h"];
		///	rgTextMan5.jobotIntroStage5Section1i.text = defs["jobotStage5Intro1i"];
			rgTextMan5.jobotIntroStage5Section1j.text = defs["jobotStage5Intro1j"];
		//	rgTextMan5.jobotIntroStage5Section1k.text = defs["jobotStage5Intro1k"];
		//	rgTextMan5.jobotIntroStage5Section1l.text = defs["jobotStage5Intro1l"];
		//	rgTextMan5.jobotIntroStage5Section1m.text = defs["jobotStage5Intro1m"];
			rgTextMan5.jobotIntroStage5Section1n.text = defs["jobotStage5Intro1n"];

			rgTextMan5.jobotIntroStage5PlantRemovalComplete1.text = defs["jobotStage5PlantComplete1"];
			rgTextMan5.jobotIntroStage5PlantRemovalComplete1a.text = defs["jobotStage5PlantComplete1a"];
			rgTextMan5.jobotIntroStage5PlantRemovalComplete1b.text = defs["jobotStage5PlantComplete1b"];
			rgTextMan5.jobotIntroStage5PlantRemovalComplete1c.text = defs["jobotStage5PlantComplete1c"];
			//rgTextMan5.jobotIntroStage5PlantRemovalComplete1d.text = defs["jobotStage5PlantComplete1d"];


			rgStage5TreeMG.jobotIntroStage5Tree.text = defs["jobotStage5ButterflyMiniGame"];
			rgStage5TreeMG.jobotIntroStage5Tree1a.text = defs["jobotStage5ButterflyMiniGamea"];
			rgStage5TreeMG.jobotIntroStage5Tree1b.text = defs["jobotStage5ButterflyMiniGameb"];
			rgStage5TreeMG.jobotIntroStage5Tree1c.text = defs["jobotStage5ButterflyMiniGamec"];
			rgStage5TreeMG.jobotIntroStage5Tree1d.text = defs["jobotStage5ButterflyMiniGamed"];
			rgStage5TreeMG.jobotIntroStage5Tree1e.text = defs["jobotStage5ButterflyMiniGamee"];
			rgStage5TreeMG.jobotIntroStage5Tree1f.text = defs["jobotStage5ButterflyMiniGamef"];
			rgStage5TreeMG.jobotIntroStage5Tree1g.text = defs["jobotStage5ButterflyMiniGameg"];
			rgStage5TreeMG.jobotIntroStage5Tree1h.text = defs["jobotStage5ButterflyMiniGameh"];
			rgStage5TreeMG.jobotIntroStage5Tree1i.text = defs["jobotStage5ButterflyMiniGamei"];
			rgStage5TreeMG.jobotIntroStage5Tree1j.text = defs["jobotStage5ButterflyMiniGamej"];
			rgStage5TreeMG.jobotIntroStage5Tree1k.text = defs["jobotStage5ButterflyMiniGamek"];

			stage5ButtCorrectAnswer.text = defs["jobotStage5ButterflyMiniGameCorrect"];
			stage5Buttincorrect1.text = defs["jobotStage5ButterflyMiniGameIncorrect"];
			stage5ButtIncorrect2.text = defs["jobotStage5ButterflyMiniGameIncorrect2"];

			correctRingStage5Text.text = defs["jobotStage5ButterflyMiniGameWellDone"];

			rgTextMan5.stage5AllTasksComplete.text = defs["jobotStage5StageCompleteMessage"];

			stage5AssesPlantComplete.text = defs["jobotStage5PlantAsses5"];

			rgTextMan5.jobotEndOFGame1.text = defs["jobotStage5EndOfGameText"];
			rgTextMan5.jobotEndOFGame1a.text = defs["jobotStage5EndOfGameTexta"];
			rgTextMan5.jobotEndOFGame1b.text = defs["jobotStage5EndOfGameTextb"];
			rgTextMan5.jobotEndOFGame1c.text = defs["jobotStage5EndOfGameTextc"];
			rgTextMan5.jobotEndOFGame1d.text = defs["jobotStage5EndOfGameTextd"];
			rgTextMan5.jobotEndOFGame1e.text = defs["jobotStage5EndOfGameTexte"];
			rgTextMan5.jobotEndOFGame1f.text = defs["jobotStage5EndOfGameTextf"];


		}
	}
}
