using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2.0f;
    SpriteRenderer m_SpriteRenderer;

    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        Color RandomColor = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown(0))
        //{
        //    Vector2 tarPos = Input.mousePosition;
        //    tarPos = Camera.main.ScreenToWorldPoint(new Vector3(tarPos.x, tarPos.y, 0.0f));

        //    transform.position = tarPos;

        //}
        //float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");

        //Vector3 t = new Vector3(speed * x * Time.deltaTime, speed * y * Time.deltaTime, 0);
        //transform.Translate(t);
        ChangeColor();
        Move();
        if (Input.GetKeyDown("r"))
        {
            CommandManager.Instance.UndoCommand();
        }
        

    }

    void Move()
    {

        if (Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow))
        {
            ICommand c = new MoveRight(transform, 0.5f);
            CommandManager.Instance.AddCommand(c);
        }
        if (Input.GetKeyDown("a") || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ICommand c = new MoveLeft(transform, -0.5f);
            CommandManager.Instance.AddCommand(c);
        }

         if (Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.UpArrow))
        {
            ICommand c = new MoveUp(transform, 0.5f);
            CommandManager.Instance.AddCommand(c);
        }
        if (Input.GetKeyDown("s") || Input.GetKeyDown(KeyCode.DownArrow))
        {
            ICommand c = new MoveDown(transform, -0.5f);
            CommandManager.Instance.AddCommand(c);
        }

    }
    void ChangeColor()
    {
        if (Input.GetKeyDown("c"))
        {
           
            ICommand c = new ColorCommand(m_SpriteRenderer, Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
            CommandManager.Instance.AddCommand(c);
            //m_SpriteRenderer.color = Color.yellow;
        }
    }


}
