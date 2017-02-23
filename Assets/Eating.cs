using UnityEngine;
using System.Collections;

public class Eating : MonoBehaviour 
    {
        public Animation target;
        public string eatfast;
     void OnDestroy()
        {
            target.Play(eatfast);
        }
    }