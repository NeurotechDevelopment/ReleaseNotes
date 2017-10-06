using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using CommonDataAndUtilities;

namespace ReleaseNotesEditor
{
	public partial class frmShowDuplicatePbiNumbers : Form
	{
		private readonly string[] _fileContent;

		public frmShowDuplicatePbiNumbers(string[] mdFileLines)
		{
			InitializeComponent();

			_fileContent = mdFileLines;
		}

		private void frmShowDuplicatePbiNumbers_Load(object sender, EventArgs e)
		{
			// Main parsing
			var pbiOccurencesCounts = new Dictionary<uint, uint>();
			foreach (var line in _fileContent)
			{
				uint? pbiNumber = PbiTokenParser.TryGetPbiNumber(line);
				if (pbiNumber.HasValue)
				{
					if (pbiOccurencesCounts.ContainsKey(pbiNumber.Value))
					{
						pbiOccurencesCounts[pbiNumber.Value]++;
					}
					else
					{
						pbiOccurencesCounts[pbiNumber.Value] = 1;
					}
				}
			}

			var sb = new StringBuilder();
			foreach (var kv in pbiOccurencesCounts)
			{
				if (kv.Value > 1)
				{
					sb.AppendFormat($"PBI: {kv.Key}\t\tOccurences: {kv.Value}");
					sb.AppendLine();
				}
			}

			textBox1.Text = sb.Length > 0 ? sb.ToString() : "No duplicates found.";
		}
	}
}
