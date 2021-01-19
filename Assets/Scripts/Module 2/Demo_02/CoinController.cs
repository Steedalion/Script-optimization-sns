using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
	SpriteRenderer sprite;
	Color nextColor;
    // Start is called before the first frame update
    void Start()
	{
		sprite = GetComponent<SpriteRenderer>();
        //InvokeRepeating("ChangeColor", 0, 1);
		StartCoroutine(ChangeColorCoroutine());
        
    }

    private void ChangeColor()
    {
        sprite.color = GetRandomColor();
    }

    private IEnumerator ChangeColorCoroutine()
    {
        while (true)
        {
	        ChangeColor();
            yield return new WaitForSeconds(1);
        }
    }
	private IEnumerator GenerateNextColor()
    {
	    yield return new WaitForSeconds(Random.Range(0f, 1f));
            
     
    }

    private Color GetRandomColor()
    {
        return new Color
            (
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f)
            );
    }
}
