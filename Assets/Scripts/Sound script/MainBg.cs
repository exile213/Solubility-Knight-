using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBg : MonoBehaviour
{
    public  static AudioSource bgmain;

    void Start()
    {
        bgmain = GetComponent<AudioSource>();
        bgmain.loop = true;
         


    }

    void Update()
    {

        EnemyHeart hpem = GetComponent<EnemyHeart>();
        PlayerHeart hppl = GetComponent<PlayerHeart>();
        if (hpem.Enemyhealth == 0)
        {
            Destroy(this.gameObject);
        }

        else if (hppl.PLhealth == 0)
        {
            Destroy(this.gameObject);
        }
        else
        {
        DontDestroyOnLoad(this.gameObject);

        }
    }



}