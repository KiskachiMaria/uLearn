﻿using System.Collections.Generic;
using System.Collections.Immutable;
using System.Xml.Serialization;

namespace uLearn.Model.Blocks
{
	[XmlType("include-md")]
	public class IncludeMdBlock : SlideBlock
	{
		[XmlAttribute("file")]
		public string File { get; set; }

		public IncludeMdBlock(string file)
		{
			File = file;
		}

		public IncludeMdBlock()
		{
		}

		public override IEnumerable<SlideBlock> BuildUp(BuildUpContext context, IImmutableSet<string> filesInProgress)
		{
			yield return new MdBlock(context.FileSystem.GetContent(File));
		}
	}
}