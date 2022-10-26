using UnityEngine;

using System.Collections;


	public class PickupManager : MonoBehaviour {
		public float  startTime = 10.0f;
		public float  coolDownTime = 10.0f;
		public PickupSpawner[] _pickupSpawners;
			// Use this for initialization
		void Start () {
			InvokeRepeating ("spwanItems", startTime, coolDownTime);
		}

		void spwanItems(){
		PickupSpawner pickupSpawners = _pickupSpawners[Random.Range(0, _pickupSpawners.Length)];
		pickupSpawners.spwanAItem ();
		}
//		
//		// Update is called once per frame
//		void Update () {
//			
//		}
	}


