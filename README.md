# QAAutomation_Exam_IntegrationAndSeleniumTests

QA Automation Exam 19.07.2020
    I. Integration Tests
1.1 Library
The first task is to create coded integration tests for a web service and will be rewarded with 25 points.
Base URL: 
https://libraryjuly.azurewebsites.net
You have received a postman collection with all the possible end-points for the current web service. Your task is to create three valid INDEPENDENT tests for: 
    • POST Author
    • GET Author
    • DELETE Author
Hint: Make the test independent, so if the database is dropped, the tests should pass.
    II. Selenium Tests
This section is for UI automation with Selenium WebDriver. 
There are some main conditions in every task which need to implement, if you want to get the maximum points. The conditions and the respective percentages of the points for each of the conditions are listed below:
    • Page Object Model – 40% 
    • Readability in Tests – 10% 
    • Assertions – 25% 
    • Test result – 25% 
2.1 AutoComplete
This task will give you 30 points if you fulfil all the main conditions above.
Create a test with Selenium WebDriver which does the following:
    1. Navigates to https://demoqa.com/
    2. Clicks on "Widgets"
    3. Clicks on "Auto Complete" 
    4. Types "Red" in "Multi color names" input field
    5. Clicks Enter
    6. Types "Re" in "Single color names" input filed
    7. Asserts that only one option is shown - "Green"


2.2 Date Picker 
This task will give you 45 points if you fulfil all the conditions above. 
You should implement three different tests with some shared steps. Doing this task, you should have in mind the Don't Repeat Yourself principle in programming.
Shared steps:
    1. Navigate to https://demoqa.com/
    2. Click on "Widgets"
    3. Click on "Date Picker"
    4. Remove date from "Select Date"
    5. Type RANDOM Date for 2020
Sub tasks to assert: 
    • 10 points for the following assert: 
        ◦ The selected day has:
            ▪ Background: rgba(33, 107, 165, 1)
            ▪ Color: rgba(255, 255, 255, 1)
    • 15 points for the following assert: 
        ◦ On hover the selected day has:
            ▪ Background: rgba(29, 93, 144, 1)
            ▪ Color: rgba(255, 255, 255, 1)
    • 20 points for the following assert:
        ◦ On hover any other than selected day has:
            ▪ Background: rgb(240, 240, 240, 1)
            ▪ Color: rgb(0, 0, 0, 1)
