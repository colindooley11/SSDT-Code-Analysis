# SSDT-Code-Analysis

Developed using:
-  Visual Studio 2012
-  C#
-  Style cop
-  MSTest
-  SSDT March 2014

Initially provided to help reduce kick back in DB review prior to releases, and also to be included as part of continuous integration builds 

- Includes 22 code analysis rules, with a further 50 to be added (bringing it in line with something like SQL code guard)
- Testing framework to provide integration testing against SSDT code analysis engine without having to fireup database project 
  and manually kick off code analysis
- T4 Templating used to gen templates for rules and associated visitors (tests could be added too)

Utilising the visitor pattern, SQL scripts are traversed and broken down and passed to code analysis rules as fragments. 
Fragments accept specific visitors which, when invoked, visit on the fragment and interrogate the underlying SQL and determine whether or not it adheres to a set of rules which you/or your organisation define, reporting back failures through SSDT using the relevant API methods, to report an error to the IDE/build process. Detailed error reporting can help pinpoint, to the line and column, specific errors/violations to rules.  All very useful! 
