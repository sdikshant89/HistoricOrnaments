using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public GameObject indoMask;
    public GameObject pot;
    public GameObject tolima;

    // public GameObject[] objects;

    public List<GameObject> objs = new List<GameObject>();

    // public bool activeFlag = true;

    // public int num;
    void Start()
    {
        objs.Add(indoMask);
        objs.Add(pot);
        objs.Add(tolima);
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.touchCount > 0)
        // {
        //     Touch touch = Input.GetTouch(0);
        //     if (touch.phase == TouchPhase.Ended)
        //     {
        //         Debug.Log("inside touch");
        //         pot.SetActive(false);
        //         tolima.SetActive(false);
        //         //indoMask.SetActive(true);
        //         var rnd = new System.Random();
        //         int num = rnd.Next(0, 3);
        //         Debug.Log(num);
        //         objs[num].SetActive(true);
        //     }
        // }
    }
}

// if (pot.activeSelf)
// {
//     indoMask.SetActive(true);
//     pot.SetActive(false);
// }
// if (indoMask.activeSelf)
// {
//     Debug.Log("inside nested indoMask");
//     indoMask.SetActive(false);
//     pot.SetActive(true);
//     tolima.SetActive(false);
//     return;
// }
//else
// if (pot.activeSelf)
// {
//     indoMask.SetActive(true);
//     pot.SetActive(false);
//     return;
// if (pot.activeSelf)
// {
//     Debug.Log("inside nested pot");
//     indoMask.SetActive(false);
//     pot.SetActive(false);
//     tolima.SetActive(true);
// }
// else
// {
//     Debug.Log("inside nested tolima");
//     indoMask.SetActive(true);
//     pot.SetActive(false);
//     tolima.SetActive(false);
// }


// foreach (GameObject myObj in objs)
// {
//     if (myObj.activeSelf)
//     {
//         myObj.SetActive(false);
//         continue;
//     }
//     if (!activeFlag)
//     {
//         myObj.SetActive(true);
//         activeFlag = true;
//     }
//     if (num % 3 == 0)
//     {
//         myObj.SetActive(true);
//         activeFlag = true;
//     }
//     //break;
// }
// for (int i = 0; i < 3; i++)
// {
//     Debug.Log("inside loop");
//     if (objects[i].activeSelf)
//     {
//         objects[i].SetActive(false);
//     }
//     else
//     {
//         objects[i].SetActive(true);
//     }
// }