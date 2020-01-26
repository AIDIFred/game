using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boi_Script : MonoBehaviour {
    int frame = 0;
    public Rigidbody2D body;
    bool A_down = false;
    bool D_down = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        check_keys();
        Debug.Log(A_down);
        if (A_down == true) {
            body.AddForce(new Vector2(-10, 0));
        }


        



        frame++;
	}

    void check_keys() {
        if (Input.GetKeyDown(KeyCode.A)) {
            A_down = true;
        }
        if (Input.GetKeyUp(KeyCode.A)) {
            A_down = false;
        }
    }
}
