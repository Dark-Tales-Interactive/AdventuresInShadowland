using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

	GameObject player;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Target ();
	}

	void Target()
	{
		if (this.GetComponent<CircleCollider2D>().IsTouching(player.GetComponent<BoxCollider2D> ()))
		{
			Debug.Log ("Player within range");
			//this.transform.Translate
		}
	}
}
