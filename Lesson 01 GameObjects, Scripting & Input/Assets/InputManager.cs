using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
        // create places to store Input values

        public int inputX;
        public int inputZ;

        // reference to player
        public GameObject player;
        // reference to start box
        public GameObject startBox;

    private void Start() {
        // set player position to start box position
        player.transform.position = startBox.transform.position;
    }
    public void Update(){
        // Get whether player is pressing w, a, s or d
        if (Input.GetKey(KeyCode.W)){
            inputZ = 1;
        } else if (Input.GetKey(KeyCode.S)){
            inputZ = -1;
        } else {
            inputZ = 0;
        }

        if (Input.GetKey(KeyCode.A)){
            inputX = -1;
        } else if (Input.GetKey(KeyCode.D)){
            inputX = 1;
        } else {
            inputX = 0;
        }

    }
}
