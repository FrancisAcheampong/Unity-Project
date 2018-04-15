﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	public Sprite smallDoor;
	public Sprite gateDoor;

	public enum d{
		small,
		gate
	}
	public d type;

	void OnCollisionEnter2D(Collision2D other){
		if (other.transform.name.Contains("player")){
			if (other.gameObject.GetComponent<PlayerController>().keys > 0){
				var p = other.gameObject.GetComponent<PlayerController>();
				p.keys--;
				p.UpdateHUD();
				OpenDoor();
			}
		}
	}

	void Start(){

		var sr = GetComponent<SpriteRenderer>();

		if (type == d.small){
			sr.sprite = smallDoor;
		} else {
			sr.sprite = gateDoor;
		}
	}

	void OpenDoor(){
		//print("Opening Door");
		GameObject.Destroy(this.gameObject, 0.1f);
		
		
	}
}
