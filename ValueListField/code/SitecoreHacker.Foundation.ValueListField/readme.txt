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