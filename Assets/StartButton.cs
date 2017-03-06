using UnityEngine;
using System.Collections;

public class Button: MonoBehaviour
{

    public void StartGame()
    {

        Application.LoadLevel("firstlvl");
    }

    // Use this for initialization
    public void EndGame()
    {
        Application.Quit();
    }

    public void level2()
    {
        Application.LoadLevel("information");
    }

    public void Mainmenu()
    {
        Application.LoadLevel("Mainmenu");
    }

    public void level3()
    {
        Application.LoadLevel("instructions");
    }

    public void level4()
    {
        Application.LoadLevel("credits");

    }
    public void level5()
    {
        Application.LoadLevel("LabWithTimer");

    }

    public void endlesshunger()
    {
        Application.LoadLevel("endlesshunger");
    }

    public void characterselect()
    {
        Application.LoadLevel("characterselect");
    }

    // Update is called once per frame
    void Update()
    {

    }
}