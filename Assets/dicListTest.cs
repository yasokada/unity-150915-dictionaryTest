using UnityEngine;
using System.Collections;
using System.Collections.Generic; // for List, Dictionary


/*
 * v0.1 2015/09/17
 *   - add Dictinary<List> and show all the element for (key==hello)
 */

public class dicListTest : MonoBehaviour {

	void displayAllElementWithKey(ref Dictionary<string, 
	       List<string>> myDic, string searchKey) {
		foreach(KeyValuePair<string, List<string>> pair in myDic) {
			if (pair.Key != searchKey) {
				continue;
			}
			Debug.Log("cmd:" + pair.Key.ToString());
			foreach(var element in pair.Value) {
				Debug.Log("res:" + element);
			}
		}
	}

	void Test_diclist() {
		Dictionary <string, List<string>> myDic 
			= new Dictionary<string, List<string>> ();
		string keystr;

		// command 1
		keystr = "hello";
		var res1ls = new List<string> ();
		res1ls.Add ("hello, Mike");
		res1ls.Add ("tadano shikabane no youda");
		res1ls.Add ("This number is not currently registered");
		myDic.Add (keystr, res1ls);

		// command 2 
		keystr = "Ca va bien?";
		var res2ls = new List<string> ();
		res2ls.Add ("Merci, beaucoup");
		res2ls.Add ("honjitsu wa sentenn nari");
		res2ls.Add ("Je nous peut pas parler Francaise.");
		myDic.Add (keystr, res2ls);

		displayAllElementWithKey (ref myDic, /* searchKey=*/"hello");
	}

	void Start () {
		Test_diclist ();
	}
	
}
