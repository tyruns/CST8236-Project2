using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

    //Array of 6 materials
    public Material[] materials;

    //Rotaion speed which should be changeable in the unity editor
    public float rotationSpeed;

    //additional vars
    Renderer render;
    Shader shader;

	void Start () {
        //unsure what this exactly does, but it must be initialized
        //found online
        shader = GetComponent<Shader>();
        render = GetComponent<Renderer>();
        render.enabled = true;
        
    }
	
	//This should be called every frame
	void Update () {

        //must multiply by time to check how much has rotated each frame
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f); 

        //Check for key input
        //render selected material
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            render.sharedMaterial = materials[0];
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            render.sharedMaterial = materials[1];
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            render.sharedMaterial = materials[2];
        }
        else if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            render.sharedMaterial = materials[3];
        }
        else if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            render.sharedMaterial = materials[4];
        }
        else if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            render.sharedMaterial = materials[5];
        }
    }
}
