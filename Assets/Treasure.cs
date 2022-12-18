using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    [SerializeField] private List<Sprite> sprites;
    // Start is called before the first frame update
    void Start()
    {
        switch (SceneLoader.GetNowScene())
        {
            case SceneLoader.Scene.Easy:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
                break;
            case SceneLoader.Scene.Normal:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
                break;
            case SceneLoader.Scene.Hard:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[2];
                break;
            case SceneLoader.Scene.None:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
                break;
            default:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
