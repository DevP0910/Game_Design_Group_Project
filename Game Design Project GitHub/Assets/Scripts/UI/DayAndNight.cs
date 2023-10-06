using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DayAndNight : MonoBehaviour
{
    
    private float currentTime = 0f;
    public GameObject nightPanel;
    public Text timeCycle;
    public Text currentTimeText;

    public int currentWave;
    public bool isNight = false;
    public float timeBetweenDayAndNight = 15f;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = timeBetweenDayAndNight;
        currentWave = 0;
        isNight = false;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        currentTimeText.text = currentTime+"";
        if(currentTime < 0f)
        {
            currentTime = timeBetweenDayAndNight;
            if(isNight)
            {
                timeCycle.text = "Night In : ";
                isNight = false;
                nightPanel.SetActive(false);
            }
            else if(!isNight)
            {
                timeCycle.text = "Day In : ";
                isNight = true;
                currentWave++;
                GameManager.Instance.spawnManager.SpawnWave();
                nightPanel.SetActive(true);
            }
        }
    }
}
