using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
        
        var go = GameObject.Find("DiaNumStr");
        int num = go.GetComponent<DiaNum>().GetDiaNum();
        var go2 = GameObject.Find("Full");
        int num2 = (int)(go2.GetComponent<Image>().fillAmount * 10.0f);
        int num3 = 1;
        switch (nowScene)
        {
            case Scene.Easy:
                num3 = 1;
                break;
            case Scene.Normal:
                num3 = 2;
                break;
            case Scene.Hard:
                num3 = 3;
                break;
            case Scene.None:
                num3 = 1;
                break;
            default:
                break;
        }
        nowScene = Scene.Success;
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking((num + num2)*num3);
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