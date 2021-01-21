using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpriteColor : MonoBehaviour
{
    private SpriteRenderer sr;
    public Color color1, color2;
    
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
	    sr.color = Color.Lerp(color1, color2, Random.value);
    }
}
