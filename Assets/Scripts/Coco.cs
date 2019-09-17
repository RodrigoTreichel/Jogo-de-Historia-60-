﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coco : MonoBehaviour
{
    public GameObject coco;
    public GameObject historiaCoco;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Personagem")
        {
            Destroy(gameObject);

            Personagem personagem = other.GetComponent<Personagem>();

            if (personagem != null)
            {
                coco.gameObject.SetActive(true);
                historiaCoco.gameObject.SetActive(true);
                Time.timeScale = 1;
                personagem.PegaObjeto();
            }
        }
    }

    public void ResumeGame()
    {
        historiaCoco.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}