using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Forms;
using System;
// using Mono.WebBrowser;

public class Test : MonoBehaviour {



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 100), "I am a button"))
        {
            print("You clicked the button!");

            Class1.Func();


            //// OpenFileDialog dialog = new OpenFileDialog();
            //// dialog.ShowDialog();
            //Form f = new Form();
            //f.Text = "hello";
            //f.Controls.Add(new Label() { Text = "good" });

            //webBrowser1 = new WebBrowser();
            //webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            //webBrowser1.Location = new System.Drawing.Point(0, 0);
            //webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            //webBrowser1.Name = "webBrowser1";
            //webBrowser1.Size = new System.Drawing.Size(284, 261);
            //webBrowser1.TabIndex = 0;



            //f.Controls.Add(webBrowser1);

            ////f.Load += (sender, e) =>
            ////{
            ////    Debug.Log("Load");
            ////    webBrowser1.Navigate("http://www.baidu.com");
            ////};


            //f.Shown += (sender, e) =>
            //{
            //    Console.WriteLine("http://www.baidu.com");
            //    webBrowser1.Navigate("http://www.baidu.com");

            //};


            //f.ShowDialog();





            // IWebBrowser browser = Mono.WebBrowser.Manager.GetNewInstance(Platform.Winforms);
            // browser.Navigation.Go("http://www.baidu.com");
        }

    }
}
