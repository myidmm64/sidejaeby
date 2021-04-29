using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 30f;
    private GameManager gamemanager = null;
    // Start is called before the first frame update
    void Start()
    {
        gamemanager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        if(transform.localPosition.x > gamemanager.MaxPosition.x +0.2f)
        {
            Destroy(gameObject);
        }
    }
}
