using UnityEngine;

public class BerserkerPuckScript : PuckScript
{
    private void puckParry()
    {
        returnObj = FindClosestObject(EnemyManager.instance.Enemies.ToArray());
        print(returnObj);
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);

        if (collision.gameObject.CompareTag("berserkerDash"))
        {
            puckParry();
        }
    }
}
