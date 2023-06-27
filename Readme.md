APPLICATION DESCRIPTION:
The developed program allows you to perform two actions.
1. Check the string you entered to match the regular expression.
2. View the regular expression test using strings already defined.
Any of the actions can be repeated indefinitely until the program is closed

REGULAR EXPRESSION DESCRIPTION:
Regular expression validates a string according to certain conditions. The string must contain a mix of specific character types and fit a certain length requirement.

(?=.*[a-z]) makes sure there is at least one lowercase letter in the string.
(?=.*[A-Z]) checks that there's at least one uppercase letter in the string.
(?=.*\d) verifies the string includes at least one digit.
(?=.*[!"#$%&'()*+,-./:;<=>?@\[\]^_{|}~])` ensures there's at least one special character from the set enclosed within the brackets.
In addition to these requirements, the expression checks the length and composition of the string:

[^\s]{40,50} stipulates that the string must be at least 40 characters long and no more than 50, and it should not contain any whitespace characters.

HOW TO RUN APPLICATION:
To run the program you need to have installed Visual Studio.
Clone repository to your computer. Open \AI.Net_Case10\AI.Net_Case10 in folder, where you clonned the repository. Run AI.Net_Case10.sln. After that click on greeen arrow on the top panel.