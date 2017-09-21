To use InnerLock.cs follow this guide below until i can release a video. Creds to SDK

Step 1: Import InnerLock.cs into your project.

Step 2: Open InnerLock.cs and the Admin panel.

Step 3: Make all the changes you need to NETLock.dll and compile it for use under release not debug, if you haven't 
already done so and move it from the folder release to somewhere else if you want and then reference it to your application. 
(If you already compiled your NETLock.dll and are using it for an application dont worry about this step)

Step 4: On the Admin panel open up the File Hash Calculator tab and click the "Select a File" button and naviagate to
NETLock.dll which we just compiled should be in the  release folder or if you moved it, it will be where you moved it too. 
If you already have your application using a compiled NETLock.dll then you would navigate to your application folder 
and find that NETLock.dll.

Step 5: Copy the Hash that was calculated in the hash calculator.

Step 6: in InnerLock.cs paste the hash value we just copied inside the CurrentMD5 string right above the method Check()


Application Example:
//Pretend this is our usings
using System;
using System.blah;
using System.Cake;

//Pretend this is our login button
Login_button(object sender, EventArgs e)
{
	InnerLock.Check(); //This will check to make sure that NETLock.dll wasn't modified or recompield to work a differnet way by checking the MD5 hash of the file.
	//It's a good idea to call InnerLock.Check(); every time you use something that is in NETLock.dll no matter what it is.
	LoginResponse log = new LoginResponse();
	if(log.Login(textBox1.Text, textBox2.Text))
	{
		//Login was successful
		Hide();
		new Form2().Show();
	}
}

//I hoped this helped some people for those who still can't get it my Discord is in the project NETLock within NETLock.cs
at the top so feel free to message me or just wait till i release a tutorial video