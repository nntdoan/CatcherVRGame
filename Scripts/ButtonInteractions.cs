<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonInteractions : MonoBehaviour {

	public void startGame(){
		SceneManager.LoadScene("gameScene", LoadSceneMode.Single);
	}
	
	public void endGame(){
		Application.Quit();
	}
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonInteractions : MonoBehaviour {

	public void startGame(){
		SceneManager.LoadScene("gameScene", LoadSceneMode.Single);
	}
	
	public void endGame(){
		Application.Quit();
	}
}
>>>>>>> ed43fb966578a358e1fc938c8bd4917b4cd7ab35
