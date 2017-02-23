using UnityEngine;
using System.Collections;

public class cursor : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Cursor.visible = (true);
    }

    void OnMouseDown()
    {

        Cursor.visible = (false);
    }

    void OnMouseUp()
    {
            Cursor.visible = true;
    }
}
