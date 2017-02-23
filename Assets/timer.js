#pragma strict

var timer : float=300.0;
//float timer = 300;

function OnGUI () 
{
    GUI.Box(new Rect(10,10,50,20),""+timer.ToString("0"));
}

function Update () 
{
    timer-=Time.deltaTime;
    if(timer<=0)
    {
        Application.LoadLevel("Endgamefail");
    }
}