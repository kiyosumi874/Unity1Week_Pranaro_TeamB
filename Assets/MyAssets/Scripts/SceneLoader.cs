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

    private static Scene nowScene = Scene.None;

    public static Scene GetNowScene()
    {
        return nowScene;
    }

    public static void ChangeScene(Scene nextScene)
    {
        loadSceneActions[nextScene].Invoke();
    }

    private static void ChangeToTitle()
    {
        nowScene = Scene.Title;
        SceneManager.LoadScene("TitleScene");
    }

    private static void ChangeToSelect()
    {
        nowScene = Scene.Select;
        SceneManager.LoadScene("SelectScene");
    }

    private static void ChangeToEasy()
    {
        nowScene = Scene.Easy;
        SceneManager.LoadScene("EasyScene");
    }

    private static void ChangeToNormal()
    {
        nowScene = Scene.Normal;
        SceneManager.LoadScene("EasyScene");
    }

    private static void ChangeToHard()
    {
        nowScene = Scene.Hard;
        SceneManager.LoadScene("EasyScene");
    }

    private static void ChangeToFailed()
    {
        nowScene = Scene.Failed;
        SceneManager.LoadScene("Failed", LoadSceneMode.Additive);
    }

    private static void ChangeToSuccess()
    {
        nowScene = Scene.Success;
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(100);
    }

    private static void ChangeToInstruction()
    {
        nowScene = Scene.Instruction;
        SceneManager.LoadScene("Instruction", LoadSceneMode.Additive);
    }

    private static void Error()
    {
        nowScene = Scene.None;
        Debug.LogAssertion("SceneChangerÇ≈éüÇÃÉVÅ[ÉìÇ™ëIÇŒÇÍÇƒÇ¢Ç‹ÇπÇÒ");
    }

}