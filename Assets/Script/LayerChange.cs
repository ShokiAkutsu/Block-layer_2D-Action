using UnityEngine;
using UnityEngine.Tilemaps;

public class LayerChange : MonoBehaviour
{
    TilemapRenderer _renderer;
    string _layerNameBack = "StageA";
    string _layerNameFlont = "StageB";
	//bool _isChange = true; // Playerと重なるとき、変更できないようにする

    void Start()
    {
		_renderer = GetComponent<TilemapRenderer>();

		if (_renderer)
		{
			_renderer.sortingOrder = -1;
			Debug.Log($"Tilemap RendererのOrder in Layerを {_renderer.sortingOrder} に変更しました。");
		}
		else
		{
			Debug.LogError("このゲームオブジェクトに TilemapRenderer が見つかりません。");
		}
	}

	private void OnMouseDown()
	{
		_renderer.sortingOrder *= -1; // Rendererのレイヤーを変更する

		string layerName = _renderer.sortingOrder < 0 ? _layerNameBack : _layerNameFlont; // 衝突レイヤーの変更
		gameObject.layer = LayerMask.NameToLayer(layerName);
	}
}
