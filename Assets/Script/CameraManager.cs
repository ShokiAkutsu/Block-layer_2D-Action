using UnityEngine;

public class CameraManager : MonoBehaviour
{
	[SerializeField] GameObject player;
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

			transform.position = new Vector3(playerX + 5, 0, -10);
			prePlayerPos = player.transform.position;
		}
	}
}
