using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStartGame : MonoBehaviour
{
    public ParticleSystem particleStartGame;

    public void OnClick()
    {
        particleStartGame.Play();
    }
}
