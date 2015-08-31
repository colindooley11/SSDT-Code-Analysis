# SSDT-Code-Analysis
Published from an internal work project

- Includes 22 code analysis rules, with a further 50 to be added (bringing it in line with something like SQL code guard)
- Testing framework to provide integration testing against SSDT code analysis engine without having to fireup database project 
  and manually kick off code analysis
- T4 Templating used to gen templates for rules and associated visitors (tests could be added too)
