using UnityEngine;
using System.Collections;

public class noodles2 : MonoBehaviour {

        public float delay = 0.1f;
        public GameObject noodle2;

        // Use this for initialization
        void Start()
        {
            InvokeRepeating("Spawn", delay, delay);
        }

        // Update is called once per frame
        void Spawn()
        {
            Instantiate(noodle2, new Vector3(Random.Range(-2, 6), 10, 0), Quaternion.identity);

        }
    }
