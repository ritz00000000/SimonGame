using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    public Animator anim;
    public Material idleMat;
    public Material downMat;
    
    public int numGen=99;

    public HelloARController myController;
    public delegate void ClickEV(int number);
    public event ClickEV onClick;
    public AudioSource aloha;
    public Renderer myR;

	private void Awake()
    {
        anim = GetComponent<Animator>();
        aloha = GetComponent<AudioSource>();
        myR = GetComponent<Renderer>();
        myR.enabled = true;
    }
	
	
    private void OnMouseDown()
    {
        if (myController.playable == true)
        {
            anim.SetBool("onclick", true);
            aloha.Play();
            if (myController.player)
            {
                onClick(numGen);
            }
        }
    }
    private void OnMouseUp()
    {
        anim.SetBool("onclick", false);

    }
}
