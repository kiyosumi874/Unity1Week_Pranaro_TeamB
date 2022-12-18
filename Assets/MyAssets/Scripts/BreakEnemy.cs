using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            //this.img.color = new Color(0.5f, 0f, 0f, 0.5f);
            Destroy(other.gameObject);
        }
    }

    //void OnColliderEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Enemy"))
    //    {
    //        Debug.Log("ìñÇΩÇ¡ÇΩÅI");
    //        //Enemy = other.GameObject;
    //        Destroy(other);
    //    }
    //}
}
