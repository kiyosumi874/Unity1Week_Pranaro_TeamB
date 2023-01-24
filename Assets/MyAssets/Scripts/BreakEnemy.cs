using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakEnemy : MonoBehaviour
{
    [SerializeField] AudioSource damageSound;
    [SerializeField] AudioClip damageSoundClip;
    [SerializeField] private float refrectPower;
    GameObject MoveObj;
    MoveObj script;

    // Start is called before the first frame update
    void Start()
    {
        this.MoveObj = GameObject.Find("MoveObj");
        script = MoveObj.GetComponent<MoveObj>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            damageSound.PlayOneShot(damageSoundClip);
            this.script.nowPower = refrectPower;
            //this.img.color = new Color(0.5f, 0f, 0f, 0.5f);
            //Destroy(other.gameObject);

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
