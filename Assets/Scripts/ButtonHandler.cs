using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    private DisplayImage currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
        
    }

    public void OnRightClickArrow()
    {
        currentDisplay.CurentWallHorizontal = currentDisplay.CurentWallHorizontal + 1;
    }

    public void OnLeftClickArrow()
    {
        currentDisplay.CurentWallHorizontal = currentDisplay.CurentWallHorizontal - 1;
    }

    public void OnTopClickArrow()
    {
        currentDisplay.CurentWallVertical = currentDisplay.CurentWallVertical + 1;
    }

    public void OnBotClickArrow()
    {
        currentDisplay.CurentWallVertical = currentDisplay.CurentWallVertical - 1;
    }

}
