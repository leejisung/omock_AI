using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class can : MonoBehaviour
{
    public GameObject manager;
    public Sprite empty;
    public Sprite black;
    public Sprite white;
    public int x;
    public int y;

    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnMouseUp()
    {
        if(game_manager.game_over==0)
        {
            GameObject.Find("game_manager").GetComponent<game_manager>().change(x, y);

            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

            if (GameObject.Find("game_manager").GetComponent<game_manager>().color_check(x, y) == 0)
            {
                spriteRenderer.sprite = empty;
            }

            else if (GameObject.Find("game_manager").GetComponent<game_manager>().color_check(x, y) == 1)
            {
                spriteRenderer.sprite = black;
            }

            else if (GameObject.Find("game_manager").GetComponent<game_manager>().color_check(x, y) == 2)
            {
                spriteRenderer.sprite = white;
            }
        }
    }
    void Update()
    {



    }
}