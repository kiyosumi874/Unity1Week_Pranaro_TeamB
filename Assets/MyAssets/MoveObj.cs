using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    [SerializeField] private float gravity = 0.2f;
    [SerializeField] private float power = 1.0f;
    [SerializeField] private float stopPower = 1.0f;
    [SerializeField] AudioSource normalSound;
    [SerializeField] AudioSource bigSound;
    [SerializeField] AudioSource strongSound;
    [SerializeField] AudioSource stopSound;
    [SerializeField] AudioClip normalSoundClip;
    [SerializeField] AudioClip bigSoundClip;
    [SerializeField] AudioClip strongSoundClip;
    [SerializeField] AudioClip stopSoundClip;
    // Start is called before the first frame update
    public float nowPower;
    private State state = null;
    public float wh;

    void Start()
    {
        nowPower = 0.0f;
        state = this.gameObject.AddComponent<State>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state.CompareState(State.StateType.Play))
        {
            // 重力の処理
            if (nowPower < 0.0f)
            {
                nowPower += gravity * 0.1f;
                if (nowPower >= 0.0f)
                {
                    nowPower = 0.0f;

                }
            }
            mouseScroll();
            //soundController();
            //以下の方法だと、はじめの音のみが出まくる
            //if (nowPower < 0.0f || nowPower > -5.0f)
            //{
            //    normalSound.PlayOneShot(normalSoundClip);
            //}
        }
        if(nowPower == 0.0f)
        {
            GetComponent<AudioSource>().Pause();
        }

    }

    public void mouseScroll()
    {

        if (this.transform.position.y > 15.0f)
        {
            nowPower = 0.0f;
            this.transform.position = new Vector3(this.transform.position.x, 15.0f, 0.0f);
            return;
        }
        this.wh = Input.mouseScrollDelta.y;
        //Debug.Log(this.wh);
        if (this.wh < 0)
        {
            GetComponent<AudioSource>().Play();
            nowPower += power * this.wh;
        }
        else if(this.wh > 0){
            if(nowPower < 0)
            {
                nowPower = 0.0f;
                stopSound.PlayOneShot(stopSoundClip);
            }
            else
            {
                strongSound.PlayOneShot(strongSoundClip);
                nowPower = 5.0f;
            }
        }
        else
        {
            nowPower += stopPower * this.wh;
            if (nowPower > 0)
            {
                nowPower -= 0.1f;
            }
            // 下に降りられなくなるようにする
            //if (nowPower > 0.0f)
            //{
            //    nowPower = 0.0f;
            //}
        }

        this.transform.Translate(0.0f, Time.deltaTime * nowPower, 0.0f);
    }
    //なぜか音出ない
    //private void soundController()
    //{
    //    if(nowPower < 0.0f || nowPower > -5.0f)
    //    {
    //        normalSound.PlayOneShot(normalSoundClip);
    //    }
    //    //else if(nowPower == 5.0f){
    //    //    strongSound.PlayOneShot(strongSoundClip);
    //    //}
    //    else if(nowPower < -5.0f)
    //    {
    //        bigSound.PlayOneShot(bigSoundClip);
    //    }
    //    else if(nowPower > 0.0f)
    //    {
    //        bigSound.PlayOneShot(bigSoundClip);
    //    }
    //}
}
