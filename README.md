# PalindromeTest
This sample project returns a list of palindromes sorted by length

This sample takes the top 3 palindromes found in a given string ordered by length.
It excludes any palindrome nested in a bigger palindrome (i.e. 'aba' in 'cabac')

Solution Structure
  Test        -> Domain application. Palindrome's public methods
  Test.NUnit  -> Unit Test application. Contains PalindromeTest to unittest public methods
  TestDto     -> Data Transfer Objects to carry objects between processes and to deliver proper json from WebAPI
  Test.WebAPI -> Public Interface to access solution using Rest mode
  Test.Interfaces -> Interfaces to be implemented by domain objects. Eventually allowing use of Dependency Injection pattern.
  
To run the application download the project or clone it using Git, open it with Visual Studio 2015, set WebAPI project as Startup project 
and press F5.
Once browser is opened, set the following url on it to run the GET request:
  http://localhost:50944/api/test/Palindromes/sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop
  
Or use any other tool as "postman" to test it.

  
