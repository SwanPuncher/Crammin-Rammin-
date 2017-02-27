using UnityEngine;
using System.Collections;

public class ClickedMoveToPosition : MonoBehaviour
{

    // Use this for initialization
    void Clicked()
    {
        // Get the target position
        Vector3 relativeLocation = new Vector3(0, -10, 0);
        Vector3 targetLocation = Pic.transform.position + relativeLocation;
        float timeDelta = 0.05f;

        // Start your coroutine
        this.StartCoroutine(SmoothMove(targetLocation, timeDelta));
    }

    IEnumerator SmoothMove(Vector3 target, float delta)
    {
        // Will need to perform some of this process and yield until next frames
        float closeEnough = 0.2f;
        float distance = (Pic.transform.position - target).magnitude;

        // GC will trigger unless we define this ahead of time
        WaitForEndOfFrame wait = new WaitForEndOfFrame();

        // Continue until we're there
        while (distance >= closeEnough)
        {
            // Confirm that it's moving
            Debug.Log("Executing Movement");

            // Move a bit then  wait until next  frame
            transform.position = Vector3.Slerp(Pic.transform.position, target, delta);
            yield return wait;

            // Check if we should repeat
            distance = (Pic.transform.position - target).magnitude;
        }

        // Complete the motion to prevent negligible sliding
        Pic.transform.position = target;

        // Confirm  it's ended
        Debug.Log("Movement Complete");

    }
}
