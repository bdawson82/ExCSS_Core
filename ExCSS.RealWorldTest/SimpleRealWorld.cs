using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExCSS.RealWorldTest
{
    public class SimpleRealWorld
    {
        public void WorkWithExCss()
        {
            // With nuget package (3.0.0) ref: https://github.com/TylerBrinks/ExCSS


            // Could read in a file here...
            string css = "html{ background-color: #5a5eed; } h2{ background-color: red }";

            var stylesheet = new ExCSS.StylesheetParser().Parse(css);

            // Get the info out.
            var info = stylesheet.Children.First(c => ((ExCSS.StyleRule)c).SelectorText == "html") as ExCSS.StyleRule;
            var selector = info.SelectorText;
            var firstCssProperty = info.Style.BackgroundColor;


            //// Create a new stylesheet
            var newParser = new ExCSS.StylesheetParser();

            ExCSS.StyleRule r = new ExCSS.StyleRule(newParser);
            r.SelectorText = "h1";
            r.Style.BackgroundColor = "red";

            ExCSS.StyleRule r2 = new ExCSS.StyleRule(newParser);
            r2.SelectorText = "h2";
            r2.Style.BackgroundColor = "green";

            var newstylesheet = r.ToCss() + System.Environment.NewLine + r2.ToCss();

        }
    }
}
