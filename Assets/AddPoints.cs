using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
    [SerializeField] public ScoreKeeper score;
    public PointsSpawner ps;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ring")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            if (collision.gameObject.transform.position.y < 200 && collision.gameObject.transform.position.y > 100)
            {
                score.AddPoints(3);
            }
            else if (collision.gameObject.transform.position.y < 100)
            {
                score.AddPoints(5);
            }
            else
            {
                score.AddPoints(1);
            }
            Destroy(collision.gameObject);
            ps.SpawnObject();
        }
    }
}
