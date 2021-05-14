using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormElemTest
{
    static public class RichBoxEventsNew
    {

        // textBox - целевой контейнер
        // target - целевое слово для замены
        // fileLocation - путь к файлу на диске
        // color - цвет 
        // start - начальная позиция поиска
        static public void FindAndChangeColor(RichTextBox textBox, string target, string fileLocation, Color color, int start)
        {
            try
            {
                textBox.LoadFile(fileLocation);
            }
            catch (ArgumentNullException exception) { }
            
            int newPosition = textBox.Find(target, start + target.Length, RichTextBoxFinds.MatchCase);
            textBox.SelectionColor = color;
            
            try
            {
                textBox.SaveFile(fileLocation, RichTextBoxStreamType.RichText);
            }
            catch (ArgumentNullException exception) { }
            
            
        }
        
        // 3. Опишите перегрузку метода  FindAndChangeColor позволяющая задавать границы поиска в тексте (start, end).
        static public void FindAndChangeColor(RichTextBox textBox, string target, string fileLocation, Color color, int start, int end)
        {
            try
            {
                textBox.LoadFile(fileLocation);
            }
            catch (ArgumentNullException exception) { }
            
            int newPosition = textBox.Find(target,start,end, RichTextBoxFinds.MatchCase); // Поиск с заданными границами
            textBox.SelectionColor = color;
            
            try
            {
                textBox.SaveFile(fileLocation, RichTextBoxStreamType.RichText);
            }
            catch (ArgumentNullException exception) { }
        }

        // 4. Опишите метод FindAndChangeWord, позволяющий заменить слово в тексте
        public static void FindAndChangeWord(RichTextBox textBox ,string target, string sample, string fileLocation, int start, int end)
        {
            try
            {
                textBox.LoadFile(fileLocation);
            } 
            catch (ArgumentNullException exception) { }
            
            int newPosition = textBox.Find(target,start,end, RichTextBoxFinds.MatchCase);

            textBox.SelectedText = sample;
            
            try
            {
                textBox.SaveFile(fileLocation, RichTextBoxStreamType.RichText);
            }
            catch (ArgumentNullException exception) { }
            
        }
    }
}
