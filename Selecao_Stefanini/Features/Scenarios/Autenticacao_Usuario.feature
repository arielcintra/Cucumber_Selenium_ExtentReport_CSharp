Feature: Autenticacao Usuario

@loginValido
Scenario: Login valido
	Given que eu insiro meu usuario e senha validos
	And clico no botao Sign in
	When valido que fui redirecionada para tela myaccount
	And faco o log off
	Then valido que fui redirecionada para tela home

	@LoginInvalido
Scenario: Login invalido
	Given que eu insiro meu usuario e senha invalidos
	And clico no botao Sign in
	Then valido erro ao efetuar o login

