using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoader
{
    public enum Scene
    {
        Title,
        Select,
        Easy,
        Normal,
        Hard,
        Failed,
        Success,
        Instruction,
        None
    }

    private static Dictionary<Scene, Action> loadSceneActions
        = new Dictionary<Scene, Action>()
        {
            {Scene.Title, ChangeToTitle },
            {Scene.Select, ChangeToSelect },
            {Scene.Easy, ChangeToEasy },
            {Scene.Normal, ChangeToNormal },
            {Scene.Hard, ChangeToHard },
            {Scene.Failed, ChangeToFailed },
            {Scene.Success, ChangeToSuccess },
            {Scene.Instruction, ChangeToInstruction },
            {Scene.None, Error }
        };

    public static void ChangeScene(Scene nextScene)
    {
        loadSceneActions[nextScene].Invoke();
    }

    private static void ChangeToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    private static void ChangeToSelect()
    {
        SceneManager.LoadScene("SelectScene");
    }

    private static void ChangeToEasy()
    {
        SceneManager.LoadScene("EasyScene");
    }

    private static void ChangeToNormal()
    {
        SceneManager.LoadScene("NormalScene");
    }

    private static void ChangeToHard()
    {
        SceneManager.LoadScene("HardScene");
    }

    private static void ChangeToFailed()
    {
        SceneManager.LoadScene("Failed", LoadSceneMode.Additive);
    }

    private static void ChangeToSuccess()
    {
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(100);
    }

    private static void ChangeToInstruction()
    {
        SceneManager.LoadScene("Instruction", LoadSceneMode.Additive);
    }

    private static void Error()
    {
        Debug.LogAssertion("SceneChangerÇ≈éüÇÃÉVÅ[ÉìÇ™ëIÇŒÇÍÇƒÇ¢Ç‹ÇπÇÒ");
    }

}