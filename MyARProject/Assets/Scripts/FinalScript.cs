using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScript : MonoBehaviour
{
    public GameObject indoMask;
    public GameObject pot;
    public GameObject tolima;
    // Start is called before the first frame update
    void Start()
    {
        indoMask.SetActive(true);
        pot.SetActive(false);
        tolima.SetActive(false);
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended)
            {
                if (indoMask.activeSelf)
                {
                    Debug.Log("inside nested indoMask");
                    indoMask.SetActive(false);
                    pot.SetActive(true);
                    tolima.SetActive(false);
                }
                else if (pot.activeSelf)
                {
                    Debug.Log("inside nested pot");
                    indoMask.SetActive(false);
                    pot.SetActive(false);
                    tolima.SetActive(true);
                }
                else if (tolima.activeSelf)
                {
                    Debug.Log("inside nested tolima");
                    indoMask.SetActive(true);
                    pot.SetActive(false);
                    tolima.SetActive(false);
                }
            }
        }
    }
}
