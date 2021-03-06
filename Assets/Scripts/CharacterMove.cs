﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public enum MoveAxis{ X, Y, Z }
    
    public enum InputAxis{ Horizontal, Vertical}
    
    [Tooltip("Vitesse de déplacement")]
    public float speed = 0.5f;
    
    [Tooltip("Axe de déplacement")]
    public MoveAxis movement = MoveAxis.X;
    
    [Tooltip("L'objet est-il déplacé avec les commandes gauche-droite ou haut-bas?")]
    public InputAxis inputAxis = InputAxis.Horizontal;
    
    [Range(0,10)]
    [Tooltip("Gravité positive fait tomber l'objet. Permet de suivre le relief d'un terrain.")]
    public float gravity = 0f;
   
    private Vector3 vectAxis;
    private string inputAxisName;
    private CharacterController chara;
    
    void Start()
    {
        chara = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        switch (movement) {
            case MoveAxis.X:
                vectAxis = transform.right;
                break;
            case MoveAxis.Y:
                vectAxis = transform.up;
                break;
            case MoveAxis.Z:
                vectAxis = transform.forward;
                break;
        }

        switch (inputAxis) {
            case InputAxis.Horizontal:
                inputAxisName = "Horizontal";
                break;
            case InputAxis.Vertical:
                inputAxisName = "Vertical";
                break;
        }

        Vector3 vectMove = speed * Time.deltaTime * Input.GetAxis(inputAxisName) * vectAxis;
        
        if (!chara.isGrounded && gravity>0f) {
            Vector3 vectGravity = new Vector3(0, -gravity * Time.deltaTime,0);
            vectMove += vectGravity;
        }

        chara.Move(vectMove);

    }
}
