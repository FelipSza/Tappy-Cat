using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

/// <summary>
/// Simple controller for the player's cat character.
/// Handles jump input and applies upward velocity to the Rigidbody2D.
/// Uses the Unity Input System package (Keyboard.current).
/// </summary>
public class CatScript : MonoBehaviour
{
    // Reference to the Rigidbody2D component that controls physics for the cat.
    // Assign this in the Inspector or obtain it via GetComponent in Awake/Start.
    public Rigidbody2D myRigidBody;

    // Jump strength multiplier applied to the upward velocity when the player presses Space.
    // Keep this as a positive value; tune it in the Inspector to change jump height.
    public float jumpStrenght;

    void Start()
    {
        // Give the GameObject a readable name in the hierarchy for easier debugging.
        gameObject.name = "Cat";
    }

    void Update()
    {
        // Using the new Input System: check if the Space key was pressed this frame.
        // 'wasPressedThisFrame' is true only on the frame the key is initially pressed.
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // Apply an upward velocity to make the cat jump.
            // Note: modifying velocity directly affects physics immediately.
            // Consider using AddForce or performing physics changes in FixedUpdate
            // for more consistent physics simulation.
            myRigidBody.linearVelocity = Vector2.up * jumpStrenght;
        }
    }
}
