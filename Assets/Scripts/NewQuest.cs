using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewQuest : MonoBehaviour
{
    public GameObject Questions1;
    public GameObject Questions2;
    public GameObject Questions3;
    public GameObject Questions4;
    public GameObject Questions5;

    public void NextQuestion1()
    {
        Questions1.SetActive(false);
        Questions2.SetActive(true);
    }

    public void NextQuestion2()
    {
        Questions2.SetActive(false);
        Questions3.SetActive(true);
    }

    public void NextQuestion3()
    {
        Questions3.SetActive(false);
        Questions4.SetActive(true);
    }

    public void NextQuestion4()
    {
        Questions4.SetActive(false);
        Questions5.SetActive(true);
    }

    public void NextQuestion5()
    {
        Questions4.SetActive(false);
        Questions5.SetActive(true);
    }
}
