﻿using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {



	void Awake(){


	}
	// A static field accessible by code anywhere
	static public bool goalMet = false;
	void OnTriggerEnter( Collider other ) {
		// When the trigger is hit by something
		// Check to see if it's a Projectile
		if ( other.gameObject.tag == "Soldier" ) {
			print ("you won!");


			// If so, set goalMet to true
			Goal.goalMet = true;
			// Also set the alpha of the color to higher opacity
			Color c = GetComponent<Renderer>().material.color;
			c.a = 1;
			GetComponent<Renderer>().material.color = c;
		}
		if (Goal.goalMet == true) {

			Soldier.S.saveAmmoLeft();

			if(Application.loadedLevelName.Equals ("0_tutorial"))
				Application.LoadLevel ("0_menu");
			if(Application.loadedLevelName.Equals ("1_game"))
				Application.LoadLevel ("2_game");
			if(Application.loadedLevelName.Equals ("2_game"))
				Application.LoadLevel ("3_game");
			if(Application.loadedLevelName.Equals ("3_game"))
				Application.LoadLevel ("4_finalscene");
			if(Application.loadedLevelName.Equals ("4_finalscene"))
				UI_manager.S.winPanel.SetActive (true);
		}
	}
}
