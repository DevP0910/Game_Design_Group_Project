using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpener : MonoBehaviour
{
    public GameObject[] allPanel;
    private bool[] panelOpened = { false, false, false };
    //public Text DispText;

    private void Start()
    {
        for(int i = allPanel.Length-1;i >= 0;i--)
        {
            allPanel[i].SetActive(false);
            panelOpened[i] = false;
        }
    }
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.B) && panelOpened[0])
        {
            allPanel[0].SetActive(false);
            panelOpened[0] = false;
        }
        else if(Input.GetKeyUp(KeyCode.B) && !panelOpened[0])
        {
            allPanel[0].SetActive(true);
            panelOpened[0] = true;
        }
    }

    public void OpenPanal(int index)
    {
        
        if (!panelOpened[index])
        {
            allPanel[index].SetActive(true);
            panelOpened[index] = true;

            for (int i = 0; i < allPanel.Length; i++)
            {
                if (index != i && i != 0)
                {
                    allPanel[i].SetActive(false);
                    panelOpened[i] = false;
                }
            }
        }
        else
        {

            allPanel[index].SetActive(false);
            panelOpened[index] = false;
        }
        
    }

    
    /*public void SetText(string text)
    {
        DispText.text = text;
    }*/

}
