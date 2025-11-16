using UnityEngine;

public class TrackingManager : MonoBehaviour
{
	[SerializeField] GameObject player;
	[SerializeField] float _posZ = -10f;
	Vector3 prePlayerPos;

	void Update()
	{
		if (player.transform.position != prePlayerPos)
		{
			float playerX = player.transform.position.x;

			if(playerX < -5)
			{
				playerX = -5;
			}

			transform.position = new Vector3(playerX + 5, 0, _posZ);
			prePlayerPos = player.transform.position;
		}
	}
}
