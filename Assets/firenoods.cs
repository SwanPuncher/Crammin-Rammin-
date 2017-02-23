using UnityEngine;
using System.Collections;

public class firenoods : MonoBehaviour {

    GameObject Capsule;
    GameObject hothead;
    GameObject noodle2;
    // Use this for initialization
    void Start()
    {
        Capsule = GameObject.Find("firey");
        Capsule.SetActive(false);
        hothead.SetActive(false);
    }
    void OnTriggerStay(Collider obj)
    {
        if (obj.CompareTag("noodle2"))
        {
            Capsule.SetActive(true);
            hothead.SetActive(true);
        }
    }

}

