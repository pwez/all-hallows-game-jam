using System;
using UnityEngine;

<<<<<<< HEAD
public class Readme : ScriptableObject {
	public Texture2D icon;
	public float iconMaxWidth = 128f;
	public string title;
    public string titlesub;
	public Section[] sections;
	public bool loadedLayout;
	
	[Serializable]
	public class Section {
		public string heading, text, linkText, url;
	}
=======
namespace TutorialInfo.Scripts
{
    public class Readme : ScriptableObject
    {
        public Texture2D icon;
        public string title;
        public Section[] sections;
        public bool loadedLayout;

        [Serializable]
        public class Section
        {
            public string heading, text, linkText, url;
        }
    }
>>>>>>> b9fb7124a0e92c88220e2ac54633a45e891b86ca
}
