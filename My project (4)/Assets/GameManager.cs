using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource note1;
    public AudioSource note2;
    public AudioSource note3;
    public AudioSource note4; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            note1.Play();
        }
		if (Input.GetKeyDown(KeyCode.S))
		{
			note2.Play();
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			note3.Play();
		}
		if (Input.GetKeyDown(KeyCode.W))
		{
			note4.Play();
		}
	}
}
