/// Homework No.__ Exercise No.__
/// File Name:     Lab 10.sln
/// @author:       Upendra Samaranayake
/// Date:          November 9, 2020
///
/// Problem Statement: Define a class named Document that contains an instance variable of type string name text that stores any textual content for the document.
///    
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Create a method named ToString that returns the text field and also include a method to set this value.
/// 2. Define a class for Email that is derived from the Document.
/// 3. Implement setter and getter methods.
/// 4. Define a class for File derived from Document and include a instance variable for the pathname.
/// 5. Create 2 Email and Fileobjects in your Main method.
/// 
using System;

namespace Lab_9
{
    class Program
    {
		public class File : Document
		{

			private string pathname;

			public File(string textMsg, string pathDes) : base(textMsg)
			{
				pathname = pathDes;
			}

			public virtual string Pathname
			{
				get
				{
					return pathname;
				}
				set
				{
					pathname = value;
				}
			}

			public virtual string Text
			{
				get
				{
					return base.ToString();
				}
			}


			public override string ToString()
			{
				return pathname + ": " + base.ToString();
			}

			public static bool ContainsKeyword(Document docObject, string keyword)
			{
				if (docObject.ToString().IndexOf(keyword, 0, StringComparison.Ordinal) >= 0)
				{
					return true;
				}

				return false;
			}

			public static void Main(string[] args)
			{
				string sample1 = "The childrens playing cricket" + " were extremely noisy.";
				string sample2 = "The lion stared at the dog " + "across the street.";
				Document email1 = new Email(sample1, "Peter", "Martin", "Childrens");
				Document email2 = new Email(sample2, "Josh", "Lucky", "animals");

				Document file1 = new File(sample1, "childrens.txt");
				Document file2 = new File(sample2, "animals.txt");
				string testWord = "Cricket";
				if (ContainsKeyword(email1, testWord))
				{
					Console.WriteLine("Email 1 contains the word " + testWord);
				}
				else
				{
					Console.WriteLine("Email 1 does not contain " + "the word " + testWord);
				}
				if (ContainsKeyword(email2, testWord))
				{
					Console.WriteLine("Email 2 contains the word " + testWord);
				}
				else
				{
					Console.WriteLine("Email 2 does not contain" + " the word " + testWord);
				}
				if (ContainsKeyword(file1, testWord))
				{
					Console.WriteLine("File 1 contains the word " + testWord);
				}
				else
				{
					Console.WriteLine("File 1 does not contain" + " the word " + testWord);
				}
				if (ContainsKeyword(file2, testWord))
				{
					Console.WriteLine("File 2 contains the word " + testWord);
				}
				else
				{
					Console.WriteLine("File 2 does not contain" + " the word " + testWord);
				}
				Console.WriteLine("---");
				Console.WriteLine(email1.ToString());
				Console.WriteLine("---");
				Console.WriteLine(email2.ToString());
				Console.WriteLine("---");
				Console.WriteLine(file1.ToString());
				Console.WriteLine(file2.ToString());

			}
		}

		public class Document
		{
			private string text;

			public Document(string textDoc)
			{
				Text = textDoc;
			}
			public virtual string Text
			{
				set
				{
					text = value;
				}
			}
			public override string ToString()
			{
				return text;
			}
		}
		public class Email : Document
		{
			private string sender;
			private string recipient;
			private string title;

			public Email(string textDoc, string senderMsg, string recipientMsg, string titleMsg) : base(textDoc)
			{

				sender = senderMsg;
				recipient = recipientMsg;
				title = titleMsg;
			}

			public virtual string Sender
			{
				get
				{
					return sender;
				}
				set
				{
					sender = value;
				}
			}

			public virtual string Recipient
			{
				get
				{
					return recipient;
				}
				set
				{
					recipient = value;
				}
			}

			public virtual string Title
			{
				get
				{
					return title;
				}
				set
				{
					title = value;
				}
			}

			public virtual string gettext()
			{
				return base.ToString();
			}




			public override string ToString()
			{
				return "From: " + sender + "\nTo: " + recipient + "\n" + title + "\n\n" + base.ToString();

			}
		}

	}
}
