﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	private int hp = 100;    //体力
	private int power = 25;  //攻撃力
	private int mp = 53;

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた。");
	}

	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた。");
		this.hp -= damage;
	}

	public void Magic(){
		if (this.mp >= 5) {
			mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}

}

public class hattenKadai : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Boss lastboss = new Boss ();

		lastboss.Attack ();
		lastboss.Defence (3);

		for (int i = 1; i <= 11; i++) {
			lastboss.Magic ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
