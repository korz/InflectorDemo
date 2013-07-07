This is a demo project used to show people how to use the Inflector library for .Net.

This is accomplished by the use of Extension Methods and Unit tests.

The Inflector library for .Net allows you to do several actions with words. Below is a list of some of the features that I will be covering in this demo project.

Singularize - converts a plural word into it's singular form using proper grammar rules.
	Examples:
		Cars becomes Car
		Wolves becomes Wolf
		Addresses becomes Address.

Pluralize - converts a singular word into it's plural form using proper grammar rules.
	Examples:
		Car becomes Cars
		Wolf becomes Wolves
		Addresses becomes Address

Camelize - converts a string into a camelized one.
	Examples:
		Address becomes address
		CustomerContact becomes customerContact
		Customercontact becomes customercontact
		customerContact remains as customerContact

IDE: Visual Studio
Language: C#
Unit Test Framework: nUnit
Test Runner: Resharper