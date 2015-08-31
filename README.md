# SSDT-Code-Analysis

Published from an internal work project and developed using:
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
