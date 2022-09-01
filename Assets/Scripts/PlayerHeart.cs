using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHeart : MonoBehaviour
{
    public  int PLhealth ;
    public int PLhearts;

    public Image[] PLheartImg;
    public Sprite PLfull;
    public Sprite PLempty;


    void Update()
    {
        if(PLhealth > PLhearts)
        {
            PLhealth = PLhearts;
        }

        for (int i = 0; i < PLheartImg.Length; i++)
        {
            if (i < PLhealth) 
            {
                PLheartImg[i].sprite = PLfull;
            }
            else
            {
                PLheartImg[i].sprite = PLempty;
            }

            if(i< PLhearts)
            {
                PLheartImg[i].enabled = true;
            }
            else
            {
                PLheartImg[i].enabled = false;
            }
        }
    }

}
