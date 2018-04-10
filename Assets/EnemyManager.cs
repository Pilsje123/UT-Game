using UnityEngine;

public class EnemyManager : MonoBehaviour {

	public float speed = 10f;
	
	private Transform target;
	private int wavepointIndex = 0;
	
	void Start () {
		transform.position = new Vector3(-5f, 0, 0);
		target = WaypointManager.points[1];
	}
	
	void Update () {
		Vector3 dir = target.position - transform.position;
		transform.Translate(dir.normalized * Time.deltaTime, Space.World);
		
		if(Vector3.Distance(transform.position, target.position) <= 0.2f) {
			GetNextWaypoint();
		}
	}
	
	void GetNextWaypoint() {
		wavepointIndex++;
		target = WaypointManager.points[wavepointIndex];
	}

}
