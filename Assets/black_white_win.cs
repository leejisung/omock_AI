using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class black_white_win : MonoBehaviour
{
    public Sprite black_win;
    public Sprite white_win;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        if (game_manager.game_over == 1)
        {            
            spriteRenderer.sprite = black_win;
        }
        if (game_manager.game_over == 2)
        {
            spriteRenderer.sprite = white_win;
        }
    }
}
