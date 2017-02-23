using UnityEngine;
using System.Collections;

public class noodles : MonoBehaviour {
    public float delay = 0.1f;
    public GameObject noodle1;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("Spawn", delay, delay);
	}
	
	// Update is called once per frame
	void Spawn () {
        Instantiate(noodle1, new Vector3(Random.Range(-6, 6), 8, 0), Quaternion.identity);
	
	}
}
