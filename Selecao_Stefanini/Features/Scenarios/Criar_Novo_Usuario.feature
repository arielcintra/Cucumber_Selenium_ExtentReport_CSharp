Feature: Cadastrar novo usuario

@novoUsuario
Scenario: Criar usuario
	Given que estou na tela de login
	And eu insiro meu email
	And clico no botao CRIAR CONTA
	When eu cadastrar meus dados validos
	Then valido que os meus dados cadastrados estao corretos

