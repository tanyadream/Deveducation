Feature: RegistrationPage
	In order to get personal account
	As a potential user of MyAccount
	I want to register through Registration page

Background:
	Given MyAccount page 'registration' is opened

Scenario: Successful registration in MyAccount
	When I input email 'uniqueEmail' in 'email' field
	And I input password '123qwe' in 'password' field
	And I input password '123qwe' in 'confirmPassword' field
	And I click on button 'Submit'
	Then MyAccount page 'myaccount' is opened
	And Link 'SignOut' is displayed

Scenario: Check that Contact support link is worked
	When I click on 'contact our support team' link
	Then Native mail client is opened

Scenario Outline: Validation of email and password fields
	When I input email '<email>' in 'email' field
	And I input password '<password>' in 'password' field
	And I input password '<confirm>' in 'confirmPassword' field
	And I click on button 'Submit'
	Then Error message '<message>' is displayed near field '<field>'
Examples:
	| email        | password | confirm   | message                 | field          |
	|              | 123qwe   | 123qwe    | Email is required       | email field    |
	| unique email |          |           | Password is required    | password field |
	| unique email | 123qwe   | 123qwe123 | Password does not match | confirm field  |