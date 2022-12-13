using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private SceneLoader.Scene nextScene = SceneLoader.Scene.None;

    public void ChangeScene()
    {
        SceneLoader.ChangeScene(nextScene);
    }
}
