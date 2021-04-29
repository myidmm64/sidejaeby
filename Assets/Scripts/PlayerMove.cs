using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefeb = null;
    [SerializeField]
    private Transform bulletPosition = null;
    private Vector2 targetPosition = Vector2.zero;
    [SerializeField]
    private float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fire());
    }
    private IEnumerator Fire()
    {
        GameObject bullet;
        while (true)
        {
            bullet = Instantiate(bulletPrefeb, bulletPosition);
            bullet.transform.SetParent(null);
            yield return new WaitForSeconds(0.2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, targetPosition, speed * Time.deltaTime);
        }
        if(transform.localPosition.x > 3.6f)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if(transform.localPosition.y > 1.6f)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        if (transform.localPosition.y < -1.6f)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (transform.localPosition.x < -3.6f)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
