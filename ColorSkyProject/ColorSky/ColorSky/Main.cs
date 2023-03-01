using System;
using BepInEx;
using UnityEngine;

namespace ColorSky
{


	[BepInPlugin("comenttGT", "ColorSky", "1.0.0")]

	public class Main : BaseUnityPlugin
    {

		public float R;
		public float G;
		public float B;

		public void Update()
		{
			//Getting da base from da monk
			GameObject Monke = GameObject.Find("Global/Local VRRig/Local Gorilla Player/gorilla");
			Monke.GetComponent<SkinnedMeshRenderer>().material.shader = Shader.Find("Standard");

			//Getting Color from Da Monk
			this.R = Monke.GetComponent<SkinnedMeshRenderer>().material.color.r;
			this.G = Monke.GetComponent<SkinnedMeshRenderer>().material.color.g;
			this.B = Monke.GetComponent<SkinnedMeshRenderer>().material.color.b;

			//Setting Color of Sky to color from Da Monk
			GameObject Sky = GameObject.Find("Level/newsky");
			Sky.GetComponent<MeshRenderer>().material.shader = Shader.Find("Standard");
			Sky.GetComponent<MeshRenderer>().material.color = new Color(this.R, this.G, this.B);


		}

	}

}

