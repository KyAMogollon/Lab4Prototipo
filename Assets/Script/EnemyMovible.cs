using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovible : MonoBehaviour
{
    public int value;
    public SpriteRenderer _sp;
    public Transform[] _transform;
    public int index=0;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        _sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _transform[index].position, speed * Time.deltaTime);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Points"))
        {
            index++;

            if (index == _transform.Length)
            {
                index = 0;
            }
        }else if (collision.gameObject.CompareTag("Player"))
        {
            HealthSystem.ModifyHealth?.Invoke(-value);
            HealthSystem.UpdateHealth?.Invoke();
        }
        

    }
}
