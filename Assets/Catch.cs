using UnityEngine;
using System.Collections;


public class test : MonoBehaviour
{
    bool IsActive = false; // used to prevent excessive "enablings"
    Renderer[] allRenderers;
    MonoBehaviour[] allBehaviours;

    void Start()
    {
        allRenderers = GetComponentsInChildren<Renderer>();
        allBehaviours = GetComponentsInChildren<MonoBehaviour>();

        foreach (Renderer r in allRenderers)
        {
            r.enabled = false;
        }

        foreach (MonoBehaviour mb in allBehaviours)
        {
            // don't disable this script
            if (mb == this)
                continue;

            mb.enabled = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("noodle1"))
        {
            if (!IsActive)
            {
                EnableThisObject();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("noodle1"))
        {
            if (IsActive)
            {
                DisableThisObject();
            }
        }
    }

    void EnableThisObject()
    {
        IsActive = true;

        foreach (Renderer r in allRenderers)
        {
            r.enabled = true;
        }

        foreach (MonoBehaviour mb in allBehaviours)
        {
            mb.enabled = true;
        }
    }

    void DisableThisObject()
    {
        IsActive = false;

        foreach (Renderer r in allRenderers)
        {
            r.enabled = false;
        }

        foreach (MonoBehaviour mb in allBehaviours)
        {
            // don't disable this script
            if (mb == this)
                continue;

            mb.enabled = false;
        }
    }
}
