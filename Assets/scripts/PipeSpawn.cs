using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{

    [SerializeField] float timeToSpawn = 1f;
    [SerializeField] float borderTop = 0.8f;
    [SerializeField] float borderBottom = -0.2f;
    [SerializeField] GameObject pipes;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPipes());
    }

    IEnumerator SpawnPipes()
    {
        while (true)
        {
            GameObject newpipe = Instantiate(pipes);
            Vector3 randomFactor = new Vector3(0, Random.Range(borderBottom, borderTop), 0);
            newpipe.transform.position = transform.position + randomFactor;
            Destroy(newpipe, 5f);
            yield return new WaitForSeconds(timeToSpawn);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
