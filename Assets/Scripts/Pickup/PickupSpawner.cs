using UnityEngine;
using System.Collections;

	public class PickupSpawner : MonoBehaviour {
		public float minCoolDownTime = 5.0f;
		public float maxCoolDownTime = 10.0f;
		public GameObject[] pickup;

		private bool _isInCoolDown = false;
		private float _coolDownTime;
		private float _timer;

		public bool IsInCoolDown {
			get {
				return _isInCoolDown;
			}
		}
		public void spwanAItem(){
			if (this._isInCoolDown)
				return;
			this._coolDownTime = Random.Range (maxCoolDownTime, minCoolDownTime);
			this._isInCoolDown = true;
			GameObject randObj = pickup[Random.Range (0, pickup.Length)];
			Instantiate (randObj, this.transform.position, Quaternion.identity);
		}
		// Use this for initialization
		void Start () {
			this._timer = 0;
		}
		
		// Update is called once per frame
		void Update () {
			if (this._isInCoolDown) {
				this._timer += Time.deltaTime;
				if(this._timer > this._coolDownTime){
					this._isInCoolDown = false;
				}
			}
		}
	}



