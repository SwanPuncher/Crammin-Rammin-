using UnityEngine;
using System.Collections;

public class ghosttwins : MonoBehaviour
{
    GameObject canvas;
    GameObject ghost1;
    GameObject ghost2;
    void Start()
    {
        canvas = GameObject.Find("ghostchat");
       ghost1 = GameObject.Find("ghost1");
        ghost2 = GameObject.Find("ghost2");
        ghost1.SetActive(false);
        ghost2.SetActive(false);
        canvas.SetActive(false);
    }
        void OnTriggerEnter(Collider obj)
       {
        if (obj.CompareTag("Player"))
        {
            ghost1.SetActive(true);
            ghost2.SetActive(true);
            canvas.SetActive(true);
        }
       }
        void OnTriggerExit(Collider obj)
        {
        if (obj.CompareTag("Player"))
          {
            ghost1.SetActive(false);
            ghost2.SetActive(false);
            canvas.SetActive(false);
          }
        }
    }