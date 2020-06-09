using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire : MonoBehaviour
{
    public ParticleSystem fire;
    public int timer = 20;
    public Text txtTimer;
    public ParticleSystem[] fires_12;
    public ParticleSystem[] fires_34;
    public ParticleSystem[] fires_56;
    public ParticleSystem[] fires_78;
    public ParticleSystem[] fires_910;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            fires_12[0].Play(); fires_12[1].Play();
            countDownTimer();
        }
    }

    void countDownTimer()
    {
        if(timer > 0)
        {
            Debug.Log(timer);
            timer--;

            if(timer == 18)
                fires_34[0].Play(); fires_34[1].Play();

            if (timer == 16)
                fires_56[0].Play(); fires_56[1].Play();

            if (timer == 14)
                fires_78[0].Play(); fires_78[1].Play();

            if (timer == 12)
                fires_910[0].Play(); fires_910[1].Play();


            txtTimer.text = timer.ToString();
            Invoke("countDownTimer", 1.0f);
        } else
        {
            txtTimer.text = "game over" ;
        }
    }

}
