# FujimuraKAskingQuestionsEndpoint
Kenneth Fujimura

Last Revised: 10-27-2022

Program Description: This is a program that emulates the console project of the same name that we did during the coding combine. It's an API program that takes in two string inputs from the user, and returns a message that acknowledges/incorporates the two inputs.

Peer Review By: Andrew Nilsson - Great job, all the inputs work in postman and returns the string in the correct format.

How To Instuctions:
1) Load the program into VSCode.
2) Start Debugging.
3) Copy Local Host URL from the console (e.g. "http://localhost:5264")
4) Open Postman program and paste the copied URL into a new workspace, with the "GET" input field.
5) Append the URL with "AskingQuestions/AskingQuestions/{name}/{time}"
6) Replace "{name}" with the user's name, and {time} with the time the user woke up in the morning. Hit the "Send" button to the right of the input field.
