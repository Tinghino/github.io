using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UBSExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxDisplayCounts.Text = "";
            var wordTotals = new Dictionary<string, int>();
            var sentenceToAnalyze = textBoxSentence.Text;
            var splitSentence = sentenceToAnalyze.Split(' ');
            foreach(var wordItem in splitSentence)
            {
                var itemToCount = wordItem.ToLower();
                if(wordTotals.Count == 0 || !wordTotals.ContainsKey(itemToCount))
                {
                    wordTotals.Add(itemToCount, 1);
                }
                else
                {
                    int wordTotalsCount; 
                    wordTotals.TryGetValue(itemToCount, out wordTotalsCount);
                    ++wordTotalsCount;
                    wordTotals[itemToCount] = wordTotalsCount;
                }
            }
            StringBuilder countsToDisplay = new StringBuilder();
            foreach(var countItem in wordTotals)
            {
                countsToDisplay.Append(countItem.Key + " - " + countItem.Value + "\n\r");

            }
            richTextBoxDisplayCounts.Text = countsToDisplay.ToString();
        }
    }
}
