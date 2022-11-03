using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetManager : MonoBehaviour
{
    private DisplayImage currentDisplay;

    public GameObject[] ObjectToManage;
    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
    }

    void Update()
    {
        MangeObjects();   
    }
    void MangeObjects()
    {
        for ( int i = 0; i < ObjectToManage.Length; i++)
        {
            if (ObjectToManage[i].name == currentDisplay.GetComponent<SpriteRenderer>().sprite.name)
            {
                ObjectToManage[i].SetActive(true);
            }
            else
            {
                ObjectToManage[i].SetActive(false);
            }
        }
    }
}
