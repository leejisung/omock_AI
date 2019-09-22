using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class board
{
    int order = 1;
    public int[,] ARR = new int[19, 19];
    void Start()
    {
        for (int i = 0; i < 19; i++)
        {
            for (int j = 0; j < 19; j++)
            {
                ARR[j, i] = 0;
            }
        }
    }
    public void change(int x, int y)
    {
        if (ARR[x, y] == 0)
        {
            ARR[x, y] = order;
            if (order == 1)
            {
                order = 2;
            }
            else
            {
                order = 1;
            }
        }

    }
    public int color_check(int x, int y)
    {
        return ARR[x, y];
    }
    public int win_check()
    {
        for (int y = 0; y < 15; y++)
        {
            for (int x = 0; x < 15; x++)
            {
                if (ARR[x, y] != 0)
                {
                    int bw = ARR[x, y];
                    if (ARR[x, y + 1] == bw && ARR[x, y + 2] == bw && ARR[x, y + 3] == bw && ARR[x, y + 4] == bw)
                    {
                        return bw;
                    }
                    if (ARR[x + 1, y] == bw && ARR[x + 2, y] == bw && ARR[x + 3, y] == bw && ARR[x + 4, y] == bw)
                    {
                        return bw;
                    }
                    if (ARR[x + 1, y + 1] == bw && ARR[x + 2, y + 2] == bw && ARR[x + 3, y + 3] == bw && ARR[x + 4, y + 4] == bw)
                    {
                        return bw;
                    }
                }
            }
        }
        for (int y = 4; y < 19; y++)
        {
            
            for (int x =0; x < 15; x++)
            {
                if (ARR[x, y] != 0)
                {
                    int bw = ARR[x, y];
                    if (ARR[x + 1, y-1] == bw && ARR[x+ 2, y-2] == bw && ARR[x+3, y-3] == bw && ARR[x+4, y-4] == bw)
                    {
                        return bw;
                    }
                }
            }
        }
                return 0;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
public class game_manager : MonoBehaviour
{
    public static int game_over = 0;
    board main_board = new board();
    public Transform prefab;
    // Start is called before the first frame update
    void Start()
    {
        make_board();
    }

    void Update()
    {
        
    }

    // Update is called once per frame
    public void change(int x, int y)
    {
        main_board.change(x, y);
    }
    public int color_check(int x, int y)
    {
        int answer = main_board.color_check(x, y);

        int win = main_board.win_check();

        if (win != 0)
        {
            game_over = win;
            Debug.Log(win);
        }

        return answer;
    }



    void make_board()
    {
        for (int y = 0; y<19; y++)
        {
            for (int x = 0; x < 19; x++)
            {
                int yy = y;
                int xx = x;
                Transform cell = Instantiate(prefab, new Vector3(yy, xx, 0), Quaternion.identity);
                cell.GetComponent<can>().x = x;
                cell.GetComponent<can>().y = y;
            }
        }
    }
}
