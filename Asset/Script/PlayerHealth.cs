using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {


	void Update () {
        if (gameObject.transform.position.y<=-7)
        {
            Destroy(gameObject);
            Application.LoadLevel("Home");
        }
	}
}
