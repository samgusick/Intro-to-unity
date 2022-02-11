using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float speed;

    // get input values from input manager
    public InputManager inputManager;

    private void Update() {
        gameObject.transform.position += new Vector3(inputManager.inputX, 0, inputManager.inputZ).normalized * Time.deltaTime * speed;

    }
}
