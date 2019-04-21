Feature: DocumentsPage
	In order to do trasactions
	As a exist MyAccount user
	I want to add my personal documents in Documents page

Scenario: Add documents for accreditation
	Given Documents page is opened
	When  I click on Upload button
	Then  The title is not null
	#Then Visibility of SignOut link is 'true'

#Scenario: Successful registration
	#Given Registration page is opened
	#When I input 'unique email' in email field
	#And I input '123qwe' in password field
	#And I input '123qwe' in confirm field
	#And I click on Submit button
	#Then Visibility of SignOut link is 'true'

#Scenario: Validation of confirm field
#	Given Registration page is opened
#	When I input 'unique email' in email field
#	And I input '123qwe' in password field
#	And I input '123qwe1' in confirm field
#	And I click on Submit button
#	Then Error message for confirm field is equals 'Password does not match'
#	And Visibility of SignOut link is 'false'

#Scenario: Validation of email field
	#Given Registration page is opened
	#When I input 'qwerty@' in email field
	#And I input '123qwe' in password field
	#And I input '123qwe' in confirm field
	#And I click on Submit button
	#Then Error message for email field is equals 'Email is invalid'

#Scenario: Impossibility to registration with exist email
	#Given Registration is completed with email 'unique email'
	#When I try to register with exist email
	#Then Error message is equals 'User with this email is already registered.'
		
#Scenario: Enter the authorisation by cookies
#	Given Registration page is opened
#	When  I input cookies file  
#	Then Visibility of SignOut link is 'true'
	