﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("msubsup")]
    public class MathMLSubscriptSuperscript : MathMLElement
    {
        [MathMLAttributeName("subscriptshift")]
        public MathMLMeasuredLength SubscriptShift { get; set; }

        [MathMLAttributeName("superscriptshift")]
        public MathMLMeasuredLength SuperscriptShift { get; set; }
    }
}
