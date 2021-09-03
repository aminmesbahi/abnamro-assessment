# Published Version
* https://web.assessment.mesbahi.net/

# Assignment
1.	Write a simple C# (Core 3.1, .NET5+) REST web service with two methods:

    a. GUID StartCalculation(some input values)  calculates ‘something’, but takes its time, somewhere between 20 seconds and 1 minute.

    b.	StatusObject GetStatus(GUID)  can be called to get a (JSON) status object back. This object should contain the status (i.e. ‘running’, ‘failed’, ‘completed’), progress(10%, 20% etc) and – when completed – the outcome of the calculation.

2.	Write a simple C# Web App that consists of a single page where a user can enter some input data for the calculation. It also contains a ‘start’ button.
The web app performs both client and server side validation of the user input (are fields empty, is the value numeric). The Start button will only be enabled when the client validation passes.
When the user clicks the button, the REST web service’s startCalculation is fed with the user input. The progress of the calculation is visualised (knock yourself out!) and when the calculation is done, the result is displayed.
 
3.	Both client and server app have sufficient unit tests to prove they work.
4.	Version control of the code is done through GitHub (you can create a free account there).
 ---
Bonus 1: The server and/or client use SQL Server to persist their data

Bonus 2: The calculation(s) is/are written in stored procedures which are also unit tested

Bonus 3: The solution is deployed to an Azure App Service (free account available here: https://azure.microsoft.com/en-us/free )