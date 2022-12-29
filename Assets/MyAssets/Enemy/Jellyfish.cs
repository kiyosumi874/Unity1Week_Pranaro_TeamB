using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jellyfish : MonoBehaviour
{
    [SerializeField] private float stealthTime;
    [SerializeField] private float attackTime;
    public GameObject player;
    public GameObject jellyfish;
    private bool isInvate;

    // Start is called before the first frame update
    void Start()
    {
        isInvate = false;
        jellyfish.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //èôÅXÇ…åªÇÍÇÈÇÊÇ§Ç…Ç∑ÇÈÅ®Ç»Ç¡ÇƒÇ»Ç¢
        if (isInvate)
        {
            jellyfish.GetComponent<SpriteRenderer>().color += new Color(255, 255, 255, 25);
        } 
    }

    /*
    void OnTriggerEnter2D(Collider2D other)
    {
        jellyfish.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
    }
    */

    void OnTriggerEnter2D(Collider2D other)
    {
        isInvate = true;
    }
    
}
