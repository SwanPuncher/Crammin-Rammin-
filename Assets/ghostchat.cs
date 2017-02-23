using UnityEngine;
using System.Collections;

public class ghostchat : MonoBehaviour
{

    public GameObject canvas;

    // Use this for initialization
    void Start()
    {
        //canvas = GameObject.Find("ghostchat");
        canvas.SetActive(false);
    }
    void OnTriggerStay(Collider obj)
    {
        if (obj.CompareTag("Player"))
        {
            canvas.SetActive(true);
        }
    }
    void OnTriggerExit(Collider obj)
    {
        if (obj.CompareTag("Player"))
        {
            canvas.SetActive(false);
        }
    }

}
