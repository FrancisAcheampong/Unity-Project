using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public float maxHealth;
    public float health;
   


    void Start () {
		health = maxHealth;
       
	}

	public void Hurt(float dmg){
		health -= dmg;

		if (health < 0){
			health = 0;
			OnDeath();
		}
		

		GameObject.Find("Player Panel").GetComponent<UIPlayerHUD>().UpdateHud();
		StartCoroutine(GameObject.Find("Player Panel").GetComponent<UIPlayerHUD>().Flash(Color.red));

	}

	public void IncreaseMaxHealth(float newMaxHealth){
		maxHealth = newMaxHealth;
	}

	public void HealAll(){
		health = maxHealth;
	}

	public bool isAtMaxHealth(){
		if (health == maxHealth) 
			return true;
		else if (health == 0){
			print("Health is at 0");
			return false;	
		} else 
			return false;
	}

	public void OnDeath(){
		SceneManager.LoadScene(2); //load death scene
	}

	
}

