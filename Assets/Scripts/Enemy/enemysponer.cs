using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemysponer : MonoBehaviour
{
    [SerializeField]
    private GameObject swarmerPrefab;//스폰될 enemy

    [SerializeField]
    private float swarmerInterval =4f;
    
    [SerializeField]
    private int maxEnemy=2;
    private int  enemyNum=0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval,swarmerPrefab));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy){
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy,new Vector3(Random.Range(0,8),Random.Range(-6f,6),0),Quaternion.identity);
        enemyNum++;
        if(enemyNum>=maxEnemy-1){
            yield return new  WaitUntil(() => enemyNum < maxEnemy-1);
            enemyNum=0;
            StartCoroutine(spawnEnemy(interval,enemy));
        }   
        StartCoroutine(spawnEnemy(interval,enemy));
    }
}
