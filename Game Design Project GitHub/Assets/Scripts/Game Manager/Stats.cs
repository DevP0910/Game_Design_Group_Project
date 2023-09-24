using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Stats : MonoBehaviour
{
    public int startGold = 1000;
    public static int currentGold;
    public Text goldText;
    // Start is called before the first frame update
    void Start()
    {
        currentGold = startGold;
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = " : " + currentGold;
    }
}
