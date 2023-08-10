using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public float TimeSpawn = 1f;

    [SerializeField] Vector2 _rangeY;
    [SerializeField] Vector2 _rangeX;
    private void Start()
    {
        StartCoroutine(RandomSpawn());
    }
    IEnumerator RandomSpawn()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Vector2 pos = transform.position + new Vector3(Random.Range(-_rangeX.x, _rangeX.x), Random.Range(-_rangeY.y, _rangeY.y));
        Instantiate(enemy, pos, Quaternion.identity);
        Repeat();
    }

    void Repeat()
    {
        StartCoroutine (RandomSpawn());
    }
}
