using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShop : MonoBehaviour
{
    //buys weapon for the player
    //this function is called by the buttons in UI
    public void BuyWeapon(GameObject prefab)
    {
        //cheaks the conditions to buy the weapon
        if (prefab.GetComponent<PlayerCombat>().costToBuy <= GameStats.currentGold)
        {
            GameStats.currentGold -= prefab.GetComponent<PlayerCombat>().costToBuy;//reduse the weapon cost
            GameObject instantiatedPrefab = Instantiate(prefab,GameManager.Instance.player.transform.position,GameManager.Instance.player.transform.rotation);//spawns the weapon
            instantiatedPrefab.transform.parent = GameObject.FindWithTag("WeaponHolder").transform;//set player as the parent gameobject
        }
    }
}