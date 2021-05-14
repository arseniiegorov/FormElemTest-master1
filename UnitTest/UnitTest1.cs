using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormElemTest;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindAndChangeColorTest()
        {
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Text = "Change this color";
            
            RichBoxEventsNew.FindAndChangeColor(richTextBox, "this", null, Color.Green, 0);
            
            richTextBox.Find("this", 0, RichTextBoxFinds.MatchCase);
            
            Assert.AreEqual(richTextBox.SelectionColor, Color.Green);

        }

        [TestMethod]
        public void FindAndChangeWordTest()
        {

            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Text = "Change this color";
            
            RichBoxEventsNew.FindAndChangeWord(richTextBox, "color", "word", null, 0, 20);
            
            richTextBox.Find("word", 0, RichTextBoxFinds.MatchCase);
            
            Assert.AreEqual(richTextBox.SelectedText, "word");
        
        }
    }
}
