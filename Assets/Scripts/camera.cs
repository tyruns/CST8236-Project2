using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

    public bool orthoView;

	//Works when initialized like this
	void Start () {
        orthoView = false;
	}
	
	//code for spacebar to toggle views
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if(orthoView)
            {
                orthoView = false;
            }
            else
            {
                orthoView = true;
            }
            
            
        }

        Camera.main.orthographic = orthoView;
    }
}
