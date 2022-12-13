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
        Play,
        Failed,
        Success,
        None
    }

    private static Dictionary<Scene, Action> loadSceneActions
        = new Dictionary<Scene, Action>()
        {
            {Scene.Title, ChangeToTitle },
            {Scene.Play, ChangeToPlay },
            {Scene.Failed, ChangeToFailed },
            {Scene.Success, ChangeToSuccess },
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

    private static void ChangeToPlay()
    {
        SceneManager.LoadScene("PlayScene");
    }

    private static void ChangeToFailed()
    {
        SceneManager.LoadScene("ResultScene");
    }

    private static void ChangeToSuccess()
    {
        SceneManager.LoadScene("ResultScene");
    }

    private static void Error()
    {
        Debug.LogAssertion("SceneChangerÇ≈éüÇÃÉVÅ[ÉìÇ™ëIÇŒÇÍÇƒÇ¢Ç‹ÇπÇÒ");
    }

}