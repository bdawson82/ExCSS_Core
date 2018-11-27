# ExCSS With Updates for .NET Core

[ExCSS v3](https://github.com/TylerBrinks/ExCSS) could be great (as v2 was), but needed some changes from the current master to make it useable (just a couple of bit's made public and moved to .NET Standard 2.0).

I've made the changes here as the pull requests don't seem to be getting incorporated at the moment.

If the changes are made to the main repro (I've asked to be a contributor), this will be deleted.

## Example usage (simple)

```C#
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

```