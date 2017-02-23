using UnityEngine;
using System.Collections;

public class Gunshotguy : MonoBehaviour
{
    GameObject Cube;
	
    // Use this for initialization
	void Start ()
    {
        Cube = GameObject.Find("gunshotguy");
        Cube.SetActive(false);
     }
    void OnTriggerStay(Collider obj)
    {
        if (obj.CompareTag("Player"))
        {
            Cube.SetActive(true);
        }
    }
    void OnTriggerExit(Collider obj)
    {
        if (obj.CompareTag("Player"))
        {
            Cube.SetActive(false);
        }
    }
	
}
