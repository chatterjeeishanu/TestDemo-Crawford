# TestDemo-Crawford
Crawford technical test

## tools and packages used
Selenium, NUnit, Restsharp

## Test files
There are 2 different test groups are created 1. For webui testing 2. For API testing

##Aproaches

Test based approach has been taken. All the test cases instruct the framework what is supposed to be tested.
Framework is test case independent. It consists of 1. some generic helper methods e.g- sending a request to an API, Wait for an webelement to be available etc; 
2. some pages that return some web element on that page; 3. some user actions e.g- button click, get the link of a weburl etc. Again all these methods are re-usable for 
any website and any test case. Any number of new generic methods can be added based on test requirements and can always be re-usable.


These methods can be used for any test cases. All the test data have been passed using resource file, hence the framework does not have hardcoded data.

##Test cases
As per given test cases are concerend, the second test cases for API will always fail as the API returns Tracey Ramos but the test is asked to verify if the returned person is Sergio Ramos.
We can always handle negative test cases as passed, but in this case I preferred to fail to show how our exception handlers are in place.
