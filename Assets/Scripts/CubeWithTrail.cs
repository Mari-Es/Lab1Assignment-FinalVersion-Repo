using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeWithTrail : MonoBehaviour

{
    public float speed = 5f; // Speed of the cube
    public GameObject spherePrefab; // Assign a small sphere prefab in Unity Editor
    public float spawnInterval = 0.5f; // Time interval between sphere spawns
    private float spawnTimer;

    void Update()
    {
        // Handle Cube Movement
        MoveCube();

        // Handle Sphere Trail
        HandleTrail();
    }

    void MoveCube() //Handles the cube's movement using the WASD or arrow keys.
    {
        // Get horizontal and vertical input (WASD or Arrow Keys)
        float moveX = Input.GetAxis("Horizontal"); // A/D or Left/Right Arrow keys
        float moveZ = Input.GetAxis("Vertical");   // W/S or Up/Down Arrow keys

        // Create movement vector and move the cube
        Vector3 move = new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime;
        transform.Translate(move);
    }

    void HandleTrail()  //Manages the timing of when spheres should spawn behind the cube.
    {
        // Update the timer for spawning spheres
        spawnTimer += Time.deltaTime;

        // If enough time has passed, spawn a sphere
        if (spawnTimer >= spawnInterval)
        {
            SpawnSphere();
            spawnTimer = 0f; // Reset the timer
        }
    }

    void SpawnSphere() //Spawns the sphere at the cube's current position and gives it a random color. The spheres are destroyed after 5 seconds.
    {
        // Instantiate a sphere at the cube's current position
        GameObject sphere = Instantiate(spherePrefab, transform.position, Quaternion.identity);

        // Set the scale of the sphere to be larger
        sphere.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f); // Adjust these values as needed

        // Assign a random color to the sphere
        Renderer sphereRenderer = sphere.GetComponent<Renderer>();
        sphereRenderer.material.color = new Color(Random.value, Random.value, Random.value);

        // Set the sphere to be destroyed after 5 seconds
        Destroy(sphere, 5f); 
    }
}



