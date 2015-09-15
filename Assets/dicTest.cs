using UnityEngine;
using System.Collections;
using System.Collections.Generic; // for Dictionary

public class dicTest : MonoBehaviour {

	void Test_dictionary() {
		Dictionary <int, int> myDic = new Dictionary<int, int> ();

		myDic.Add (3, 1415);
		myDic.Add (2, 7182);
//		myDic.Add (3, 1234);

		foreach (KeyValuePair<int, int> pair in myDic) {
			Debug.Log(pair.Key + " : " + pair.Value);
		}

	}

	void Start () {
		Test_dictionary ();
	}	
}
