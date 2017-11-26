=== SitecoreHacker Value List field ===
This is a small custom Sitecore Field that provides functionality to have simple 
value drop lists that aren't tied to Sitecore items. The value of the field is a simple string.


== INSTALL THE SITECORE PACKAGE ==
There is a Content Package that needs to be installed in order to get this to work.
You can find the Sitecore Package to install in the /temp of the project that you 
added the NuGet reference to.

== TO USE ==
Once the package is installed, there is an Example Template that shows how to reference the Value List field.
There are a few built in Datasources, in Fields\Datasources of the module that show how to create a datasource
and reference it in your own project.

== Creating Custom Datasources ==
By simply referencing the ValueListField DLL in your project (via NuGet, Duh), you can build custom Datasources.
These Datasources are simple classes that need to implement the 
SitecoreHacker.Foundation.ValueListField.Abstraction.IValueList interface.
Implement the string[] ValueListQuery(); method.

== Comments / Suggestions ==
This is my first NuGet package that I have provided. I'm learning, and could use any advice or 
suggestions to make this package better.

Email me: pete@sitecorehacker.com


MIT License

Copyright (c) 2017 Pete Navarra

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.