# Bizcover_QA_PracticalExam
Selenium Exam for new QA Applicants

This solution contains a test framework which is built from Specflow, Nunit3, and Selenium WebDriver.

The framework utilises:
1. Gherkin language for the test/feature files
2. Page-Object-Model - Each Page of the website has it's own class
3. Uses the open-for-testing website: http://automationpractice.com

The solution has one test/feature file which basically tests the log in flow for a valid user.

Problem: QA Candidate is required to write a test to register a new user. Registration of a new user can be found in http://automationpractice.com/index.php?controller=authentication&back=my-account.
         Any email address can be used for registration as there is no email validation in place.

Expectations:
1. New user should be registered. Would be great if the email address is randomly generated so as for the test to be reuseable.
2. The user should be able to log in to the system after a successful registration.
3. Please upload your solution to your github account and provide us the link. It is also desirable if you can attach a Test Report which shows the test result.
