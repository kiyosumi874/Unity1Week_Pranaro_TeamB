using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    //ダメージ
    [SerializeField] private float rockDamage;
    //[SerializeField] private float painRockDamage;
    [SerializeField] private float falliingRockDamage;
    //[SerializeField] private float cannonDamage;
    [SerializeField] private float normalFishDamage;
    //[SerializeField] private float kurageDamage;

    //敵オブジェクト
    public GameObject rock;
    //public GameObject painRock;
    public GameObject fallingRock;
    //public GameObject cannon;
    public GameObject normalFish;
    //public GameObject kurage;

    private float damage;

    // Start is called before the first frame update
    void Start()
    {
        damage = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collider2D other)
    {
        if(other.gameObject.name == rock.name) {
            ReturnDamage(rockDamage);
        }
        /*
        if (other.gameObject.name == painRock.name)
        {
            ReturnDamage(painRockDamage);
        }
        */
        if (other.gameObject.name == fallingRock.name)
        {
            ReturnDamage(falliingRockDamage);
        }
        /*
        if (other.gameObject.name == cannon.name)
        {
            ReturnDamage(cannonDamage);
        }
        */
        if (other.gameObject.name == normalFish.name)
        {
            ReturnDamage(normalFishDamage);
        }
        /*
        if (other.gameObject.name == kurage.name)
        {
            ReturnDamage(kurageDamage);
        }
        */
    }

    void OnCollisionExit2D(Collider2D ohter)
    {
        ResetDamage();
    }

    float ReturnDamage(float enemyDamage)
    {
        damage = enemyDamage;
        return damage;
    }

    float ResetDamage()
    {
        damage = 0.0f;
        return damage;
    }
}
