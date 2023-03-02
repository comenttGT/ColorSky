using System;
using BepInEx;
using UnityEngine;

namespace ColorSky
{


	[BepInPlugin("comenttGT", "ColorSky", "1.1.0")]

	public class Main : BaseUnityPlugin
    {

		//Mod Made by ComenttGT#9344


		public float R;
		public float G;
		public float B;

		public GameObject Monkey;
		public GameObject Sky;


		public void Awake()
        {
			//Finding da Monk
		    GameObject Monke = GameObject.Find("Global/Local VRRig/Local Gorilla Player/gorilla");

			//Setting Monkey as Monke
			Monkey = Monke;

			//Finding da Sky
			GameObject Skys = GameObject.Find("Level/newsky");

			//Setting Sky as Skys
			Sky = Skys;
		}

		public void Update()
		{

			//Getting the color form da Monk
			var color = Monkey.GetComponent<SkinnedMeshRenderer>().material.color;

			//Setting Color from da Monk to R, G and B Values
			this.R = color.r;
			this.G = color.g;
			this.B = color.b;

			//Making Sky Color as Monke Color :)
			Sky.GetComponent<MeshRenderer>().material.color = new Color(this.R, this.G, this.B);


		}

	}

}

