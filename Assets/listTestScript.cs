using UnityEngine;
using System.Collections;
using System.Collections.Generic; // for List

public class listTestScript : MonoBehaviour {

	void Test_list_duplicate_registration() {
//		List<int> [] myList = new [2] List<int> ();
//		List<int> [] myList = new List<int> ()[2];

		string [,] strList = new string[3, 2];

		strList [0, 0] = "hello";
		strList [0, 1] = "hello, Mike";

		strList [1, 0] = "hello";
		strList [1, 1] = "tadano shikabane no youda";

		strList [2, 0] = "hello";
		strList [2, 1] = "This number is not currently registered";

		int idx;
		for (int loop=0; loop<10; loop++) {
			idx = Random.Range(0,3);
			Debug.Log(strList[idx,0] + " >> " + strList[idx,1]);
		}
	}

	void Start () {
		Test_list_duplicate_registration ();
	}	
}
