using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
    public float jumpVelocity;

    private float startY;
    private GameObject character;
    private Rigidbody2D characterRB;
    private bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Character"); // mrDick
        characterRB = character.GetComponent<Rigidbody2D>();
        startY = characterRB.position.y;
    }

    private void OnMouseDown()
    {
        if (!isJumping) {
            characterRB.AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);
            isJumping = true;
        }
        //rigidbody2D.velocity = Vector2.up * jumpVelocity;
    }

    private void Update()
    {
        if (isJumping && (startY >= characterRB.position.y))
        {
            isJumping = false;
        }
    }
}
